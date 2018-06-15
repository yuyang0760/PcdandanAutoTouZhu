using DevExpress.XtraEditors;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using PcdandanAutoTouZhu.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using yy.util;

namespace PcdandanAutoTouZhu
{
    public partial class MainForm : XtraForm
    {

        IWebDriver driver;
        bool isTimerStart = false;

        public MainForm()
        {

            InitializeComponent();
            // 计时器间隔
            timer1.Interval = Properties.Settings.Default.jiange;
        }
        // 开始投注
        private void button_startTouZhu_Click(object sender, EventArgs e)
        {
            if (!isChromeOpen())
            {
                XtraMessageBox.Show("请点击打开chrome浏览器,并登陆");
                return;
            }

            if (!isTimerStart)
            {
                timer1.Stop();
                timer1.Start();
                button_startTouZhu.Text = "停止投注";
                isTimerStart = true;
            }
            else
            {
                timer1.Stop();
                button_startTouZhu.Text = "自动投注(根据xml)";
                isTimerStart = false;
            }

        }

        // 自动投注
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isChromeOpen())
            {
                Button_openChrome.PerformClick();
            }
            // 每到02分或者07分时,开始投注
            if (DateTime.Now.Minute % 5 != 2) { return; }
            TouZhu(TouzhuType._根据xml, null);
        }
        // 投注函数
        private void TouZhu(TouzhuType touzhuType, string[] d)
        {

            XmlConfig xmlConfig = new XmlConfig("./xml/autotouzhuReal.xml");
            // 进入娱乐大厅
            driver.Url = "http://www.pceggs.com/play/pxya.aspx";
            IWebElement touzhuButton = driver.FindElement(By.XPath(@"//*[@id=""panel""]/tbody/tr[7]/td[8]/a"));
            // 如果按钮不是投注,则提示,您已投注
            if (touzhuButton.Text != "投注")
            {
                XtraMessageBox.Show("您已投注");
                return;
            }

            // 如果按钮是投注的话才投注
            if (touzhuButton.Text == "投注")
            {
                // 点击这个投注按钮
                touzhuButton.Click();
                // 等到跳转
                while (true)
                {
                    if (driver.Url.Contains("http://www.pceggs.com/play/pg28Insert.aspx?LID")) { break; }
                }
                string[] touzhuNumber = null;
                // 根据xml
                if (touzhuType == TouzhuType._根据xml)
                {
                    // 填入数据
                    touzhuNumber = xmlConfig.Search("touzhuNumber").Split(',');
                }
                // 根据自定义参数
                if (touzhuType == TouzhuType._根据自定义)
                {
                    // 填入数据
                    touzhuNumber = d;
                }
                // 开始填充
                for (int i = 0; i <= 27; i++)
                {
                    if (touzhuNumber[i] != "0")
                    {
                        IWebElement ee = driver.FindElement(By.Id("txt" + i.ToString()));

                        ee.SendKeys(touzhuNumber[i]);
                    }
                }
                //点击确认投注
                driver.FindElement(By.Id(@"conform_btn")).Click();
                try
                {
                    // 确认投注
                    driver.FindElement(By.Id(@"fc_an_l170223")).Click();

                }
                catch (Exception)
                {

                }
                // 返回娱乐大厅
                driver.Url = "http://www.pceggs.com/play/pxya.aspx";
            }
        }

        // 根据xml手动投注
        private void button_shoudong_Click(object sender, EventArgs e)
        {
            if (!isChromeOpen())
            {
                XtraMessageBox.Show("请点击打开chrome浏览器,并登陆");
                return;
            }
            TouZhu(TouzhuType._根据xml, null);
        }

        // 手动投注
        private void button_shoudong_zidingyi_Click(object sender, EventArgs e)
        {
            if (!isChromeOpen())
            {
                XtraMessageBox.Show("请点击打开chrome浏览器,并登陆");
                return;
            }
            Util util = new Util();

            double[] touzhu = 计算投注值();
            if (touzhu == null) { return; }
            TouZhu(TouzhuType._根据自定义, string.Join(",", touzhu).Split(','));
        }
        // 总在最上
        private void checkEdit_topMost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkEdit_topMost.Checked;
        }
        // 模式
        int name = 0;
        private void Button_moshibianji_Click(object sender, EventArgs e)
        {
            if (!isChromeOpen())
            {
                XtraMessageBox.Show("请点击打开chrome浏览器,并登陆");
                return;
            }
            driver.Url = "http://www.pceggs.com/play/pg28ModesEdit.aspx";
            // 计算值
            double[] touzhu = 计算投注值();
            if (touzhu == null) { return; }
            // 名字
            if (textEdit_saveName.Text.Trim() == "")
            {
                textEdit_saveName.Text = "_" + (++name).ToString();

            }
            //*[@id="form1"]/div[4]/div[2]/table[3]/tbody/tr[2]/td/table/tbody/tr/td[3]/button[1]
            driver.FindElement(By.XPath(@"//*[@id=""form1""]/div[4]/div[2]/table[3]/tbody/tr[2]/td/table/tbody/tr/td[3]/button[1]")).Click();

            for (int i = 0; i <= 27; i++)
            {
                if (touzhu[i] == 0)
                {
                    continue;
                }
                //IWebElement ee = driver.FindElement(By.Id("txt" + i.ToString()));
                IWebElement touzhuButton = driver.FindElement(By.XPath($@"//*[@id=""form1""]/div[4]/div[2]/table[3]/tbody/tr[{i + 4}]/td[2]/input[1]"));
                touzhuButton.SendKeys(touzhu[i].ToString());
            }
            ////点击保存
            driver.FindElement(By.XPath(@"//*[@id=""form1""]/div[4]/div[2]/table[3]/tbody/tr[2]/td/table/tbody/tr/td[3]/button[2]")).Click();
            // 填写保存名字
            driver.FindElement(By.Id("SaveModename")).SendKeys(textEdit_saveName.Text);
            //// 保存
            driver.FindElement(By.XPath(@"//*[@id=""Notice_btn""]/div[1]/a")).Click();
        }

        private double[] 计算投注值()
        {
            Util util = new Util();

            if (radioGroup1.SelectedIndex == 0)
            {
                int start = int.Parse(spinEdit_startCode.Value.ToString());
                int end = int.Parse(spinEdit_endCode.Value.ToString());

                List<int> list = new List<int>();
                for (int i = start; i <= end; i++)
                {
                    list.Add(i);
                }
                double[] touzhu = util._计算投注数量(int.Parse(spinEdit_dandanNumber.Value.ToString()), list);
                return touzhu;

            }
            if (radioGroup1.SelectedIndex == 1)
            {
                int start = int.Parse(comboBoxEdit_N余.Text);
                int end = int.Parse(comboBoxEdit_余N.Text);

                List<int> list = new List<int>();
                for (int i = 0; i <= 27; i++)
                {
                    if (i % start == end)
                    {
                        list.Add(i);
                    }
                }
                double[] touzhu = util._计算投注数量(int.Parse(spinEdit_dandanNumber.Value.ToString()), list);
                return touzhu;
            }
            return null;
        }

        private void comboBoxEdit_N余_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = int.Parse(comboBoxEdit_N余.Text);
            comboBoxEdit_余N.Properties.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                comboBoxEdit_余N.Properties.Items.Add(i);
            }
            comboBoxEdit_余N.SelectedIndex = 0;
        }

        // 关闭窗口
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (driver != null)
            {
                driver.Quit();

                e.Cancel = false;
                this.Dispose();
            }
        }

        public bool isChromeOpen()
        {
            if (driver == null)
            {
                return false;
            }
            try
            {
                string title = driver.Title;
                if (driver != null)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        // 打开浏览器
        private void Button_openChrome_Click(object sender, EventArgs e)
        {

            try
            {
                string title = driver.Title;
                if (driver != null)
                {
                    DialogResult dr = XtraMessageBox.Show("您已打开chrome,点击确定重新打开chrome", "", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        driver.Quit();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception)
            {
            }

            ChromeOptions options = new ChromeOptions();
            //options.AddArguments(@"user-data-dir=C:\Users\Administrator\AppData\Local\Google\Chrome\User Data");
            this.driver = new ChromeDriver(options);
            driver.Url = "http://www.pceggs.com";
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 0)
            {
                panelControl_N余.Visible = false;
                panelControl_startEnd.Visible = true;
            }
            if (radioGroup1.SelectedIndex == 1)
            {
                panelControl_N余.Visible = true;
                panelControl_startEnd.Visible = false;
            }
        }
    }
}
