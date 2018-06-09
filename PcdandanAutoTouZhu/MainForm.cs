using DevExpress.XtraEditors;
using OpenQA.Selenium;
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

        FirefoxOptions firefoxOptions = new FirefoxOptions();
        IWebDriver driver;
        bool isTimerStart = false;

        public MainForm()
        {

            InitializeComponent();
            string profile_ff = Properties.Settings.Default.profile;
            firefoxOptions.Profile = new FirefoxProfile(profile_ff);
            this.driver = new FirefoxDriver(firefoxOptions);

            // 计时器间隔
            timer1.Interval = Properties.Settings.Default.jiange;
        }
        // 开始投注
        private void button_startTouZhu_Click(object sender, EventArgs e)
        {
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
                button_startTouZhu.Text = "开始投注";
                isTimerStart = false;
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // 没到02分或者07分时,开始投注
            if (DateTime.Now.Minute % 5 != 2) { return; }
            TouZhu(TouzhuType._根据xml, null);
        }
        // 投注
        private void TouZhu(TouzhuType touzhuType, string[] d)
        {

            XmlConfig xmlConfig = new XmlConfig("./xml/autotouzhuReal.xml");
            // 进入娱乐大厅
            driver.Url = "http://www.pceggs.com/play/pxya.aspx";

            IWebElement touzhuButton = driver.FindElement(By.XPath(@"//*[@id=""panel""]/tbody/tr[7]/td[8]/a"));
            if (touzhuButton.Text == "投注")
            {
                while (true)
                {
                    touzhuButton.Click();
                    Thread.Sleep(3000);
                    if (driver.Url.Contains("http://www.pceggs.com/play/pg28Insert.aspx?LID")) { break; }
                }
                string[] touzhu = null;
                if (touzhuType == TouzhuType._根据xml)
                {
                    // 填入数据
                    touzhu = xmlConfig.Search("touzhuNumber").Split(',');
                }
                if (touzhuType == TouzhuType._根据自定义)
                {
                    // 填入数据
                    touzhu = d;
                }
                for (int i = 0; i <= 27; i++)
                {
                    if (touzhu[i] != "0")
                    {
                        IWebElement ee = driver.FindElement(By.Id("txt" + i.ToString()));

                        ee.SendKeys(touzhu[i]);
                    }
                }
                //点击确认投注
                driver.FindElement(By.Id(@"conform_btn")).Click();
                // 确认投注
                driver.FindElement(By.Id(@"fc_an_l170223")).Click();
                // 返回娱乐大厅
                driver.Url = "http://www.pceggs.com/play/pxya.aspx";
            }
        }
        // 手动按钮
        private void button_shoudong_Click(object sender, EventArgs e)
        {
            if (driver == null)
            {
                this.driver = new FirefoxDriver(firefoxOptions);
            }
            TouZhu(TouzhuType._根据xml, null);
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
 

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button_shoudong_zidingyi_Click(object sender, EventArgs e)
        {
            Util util = new Util();
            int start = int.Parse(spinEdit_startCode.Value.ToString());
            int end = int.Parse(spinEdit_endCode.Value.ToString());

            List<int> list = new List<int>();
            for (int i = start; i <= end; i++)
            {
                list.Add(i);
            }
            double[] touzhu = util._计算投注数量(int.Parse(spinEdit_dandanNumber.Value.ToString()), list);

            TouZhu(TouzhuType._根据自定义, string.Join(",", touzhu).Split(','));
        }
    }
}
