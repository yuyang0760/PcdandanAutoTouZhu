namespace PcdandanAutoTouZhu
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_startTouZhu = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_shoudong_byxml = new DevExpress.XtraEditors.SimpleButton();
            this.button_shoudong_zidingyi = new DevExpress.XtraEditors.SimpleButton();
            this.spinEdit_dandanNumber = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl_touzhuNumber = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_startCode = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit_startCode = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit_endCode = new DevExpress.XtraEditors.SpinEdit();
            this.checkEdit_topMost = new DevExpress.XtraEditors.CheckEdit();
            this.button_moshibianji = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_saveName = new DevExpress.XtraEditors.TextEdit();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.comboBoxEdit_N余 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit_余N = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Button_openChrome = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl_N余 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl_startEnd = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_dandanNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_startCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_endCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_topMost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_saveName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_N余.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_余N.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_N余)).BeginInit();
            this.panelControl_N余.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_startEnd)).BeginInit();
            this.panelControl_startEnd.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_startTouZhu
            // 
            this.button_startTouZhu.Location = new System.Drawing.Point(164, 59);
            this.button_startTouZhu.Name = "button_startTouZhu";
            this.button_startTouZhu.Size = new System.Drawing.Size(138, 33);
            toolTipTitleItem1.Text = "自动投注";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "会根据 autotouzhuReal.xml 文件进行投注\r\n每到02分和07分会投注";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.button_startTouZhu.SuperTip = superToolTip1;
            this.button_startTouZhu.TabIndex = 0;
            this.button_startTouZhu.Text = "自动投注(根据xml)";
            this.button_startTouZhu.Click += new System.EventHandler(this.button_startTouZhu_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_shoudong_byxml
            // 
            this.button_shoudong_byxml.Location = new System.Drawing.Point(164, 104);
            this.button_shoudong_byxml.Name = "button_shoudong_byxml";
            this.button_shoudong_byxml.Size = new System.Drawing.Size(138, 33);
            toolTipTitleItem2.Text = "手动投注";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "会根据 autotouzhuReal.xml 文件进行投注";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.button_shoudong_byxml.SuperTip = superToolTip2;
            this.button_shoudong_byxml.TabIndex = 2;
            this.button_shoudong_byxml.Text = "手动投注(根据xml)";
            this.button_shoudong_byxml.Click += new System.EventHandler(this.button_shoudong_Click);
            // 
            // button_shoudong_zidingyi
            // 
            this.button_shoudong_zidingyi.Location = new System.Drawing.Point(164, 149);
            this.button_shoudong_zidingyi.Name = "button_shoudong_zidingyi";
            this.button_shoudong_zidingyi.Size = new System.Drawing.Size(138, 33);
            this.button_shoudong_zidingyi.TabIndex = 4;
            this.button_shoudong_zidingyi.Text = "手动投注(根据左边)";
            this.button_shoudong_zidingyi.Click += new System.EventHandler(this.button_shoudong_zidingyi_Click);
            // 
            // spinEdit_dandanNumber
            // 
            this.spinEdit_dandanNumber.EditValue = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.spinEdit_dandanNumber.Location = new System.Drawing.Point(11, 65);
            this.spinEdit_dandanNumber.Name = "spinEdit_dandanNumber";
            this.spinEdit_dandanNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_dandanNumber.Properties.Mask.EditMask = "\\d{1,9}";
            this.spinEdit_dandanNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.spinEdit_dandanNumber.Properties.MaxValue = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.spinEdit_dandanNumber.Size = new System.Drawing.Size(147, 20);
            this.spinEdit_dandanNumber.TabIndex = 5;
            // 
            // labelControl_touzhuNumber
            // 
            this.labelControl_touzhuNumber.Location = new System.Drawing.Point(31, 42);
            this.labelControl_touzhuNumber.Name = "labelControl_touzhuNumber";
            this.labelControl_touzhuNumber.Size = new System.Drawing.Size(48, 14);
            this.labelControl_touzhuNumber.TabIndex = 6;
            this.labelControl_touzhuNumber.Text = "投注数量";
            // 
            // labelControl_startCode
            // 
            this.labelControl_startCode.Location = new System.Drawing.Point(5, 8);
            this.labelControl_startCode.Name = "labelControl_startCode";
            this.labelControl_startCode.Size = new System.Drawing.Size(52, 14);
            this.labelControl_startCode.TabIndex = 7;
            this.labelControl_startCode.Text = "开始号码:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 14);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "结束号码:";
            // 
            // spinEdit_startCode
            // 
            this.spinEdit_startCode.EditValue = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.spinEdit_startCode.Location = new System.Drawing.Point(77, 5);
            this.spinEdit_startCode.Name = "spinEdit_startCode";
            this.spinEdit_startCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_startCode.Properties.Mask.EditMask = "\\d{1,2}";
            this.spinEdit_startCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.spinEdit_startCode.Properties.MaxValue = new decimal(new int[] {
            27,
            0,
            0,
            0});
            this.spinEdit_startCode.Size = new System.Drawing.Size(57, 20);
            this.spinEdit_startCode.TabIndex = 9;
            // 
            // spinEdit_endCode
            // 
            this.spinEdit_endCode.EditValue = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.spinEdit_endCode.Location = new System.Drawing.Point(77, 31);
            this.spinEdit_endCode.Name = "spinEdit_endCode";
            this.spinEdit_endCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_endCode.Properties.Mask.EditMask = "\\d{1,2}";
            this.spinEdit_endCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.spinEdit_endCode.Properties.MaxValue = new decimal(new int[] {
            27,
            0,
            0,
            0});
            this.spinEdit_endCode.Size = new System.Drawing.Size(57, 20);
            this.spinEdit_endCode.TabIndex = 10;
            // 
            // checkEdit_topMost
            // 
            this.checkEdit_topMost.Location = new System.Drawing.Point(164, 40);
            this.checkEdit_topMost.Name = "checkEdit_topMost";
            this.checkEdit_topMost.Properties.Caption = "总在最上";
            this.checkEdit_topMost.Size = new System.Drawing.Size(75, 19);
            this.checkEdit_topMost.TabIndex = 11;
            this.checkEdit_topMost.CheckedChanged += new System.EventHandler(this.checkEdit_topMost_CheckedChanged);
            // 
            // button_moshibianji
            // 
            this.button_moshibianji.Location = new System.Drawing.Point(164, 194);
            this.button_moshibianji.Name = "button_moshibianji";
            this.button_moshibianji.Size = new System.Drawing.Size(138, 33);
            this.button_moshibianji.TabIndex = 12;
            this.button_moshibianji.Text = "投注模式编辑(根据左边)";
            this.button_moshibianji.Click += new System.EventHandler(this.Button_moshibianji_Click);
            // 
            // textEdit_saveName
            // 
            this.textEdit_saveName.Location = new System.Drawing.Point(71, 203);
            this.textEdit_saveName.Name = "textEdit_saveName";
            this.textEdit_saveName.Size = new System.Drawing.Size(87, 20);
            this.textEdit_saveName.TabIndex = 13;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(11, 91);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Columns = 2;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "开始结束"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "N余")});
            this.radioGroup1.Size = new System.Drawing.Size(147, 31);
            this.radioGroup1.TabIndex = 14;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // comboBoxEdit_N余
            // 
            this.comboBoxEdit_N余.EditValue = "5";
            this.comboBoxEdit_N余.Location = new System.Drawing.Point(15, 13);
            this.comboBoxEdit_N余.Name = "comboBoxEdit_N余";
            this.comboBoxEdit_N余.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_N余.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxEdit_N余.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit_N余.Size = new System.Drawing.Size(45, 20);
            this.comboBoxEdit_N余.TabIndex = 15;
            this.comboBoxEdit_N余.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit_N余_SelectedIndexChanged);
            // 
            // comboBoxEdit_余N
            // 
            this.comboBoxEdit_余N.EditValue = "0";
            this.comboBoxEdit_余N.Location = new System.Drawing.Point(87, 13);
            this.comboBoxEdit_余N.Name = "comboBoxEdit_余N";
            this.comboBoxEdit_余N.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_余N.Properties.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxEdit_余N.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit_余N.Size = new System.Drawing.Size(45, 20);
            this.comboBoxEdit_余N.TabIndex = 16;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(66, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(12, 14);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "余";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 203);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 14);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "模式名字:";
            // 
            // Button_openChrome
            // 
            this.Button_openChrome.Location = new System.Drawing.Point(11, 3);
            this.Button_openChrome.Name = "Button_openChrome";
            this.Button_openChrome.Size = new System.Drawing.Size(293, 33);
            this.Button_openChrome.TabIndex = 19;
            this.Button_openChrome.Text = "打开 Chrome 浏览器";
            this.Button_openChrome.Click += new System.EventHandler(this.Button_openChrome_Click);
            // 
            // panelControl_N余
            // 
            this.panelControl_N余.Controls.Add(this.comboBoxEdit_N余);
            this.panelControl_N余.Controls.Add(this.comboBoxEdit_余N);
            this.panelControl_N余.Controls.Add(this.labelControl1);
            this.panelControl_N余.Location = new System.Drawing.Point(11, 126);
            this.panelControl_N余.Name = "panelControl_N余";
            this.panelControl_N余.Size = new System.Drawing.Size(147, 44);
            this.panelControl_N余.TabIndex = 20;
            // 
            // panelControl_startEnd
            // 
            this.panelControl_startEnd.Controls.Add(this.labelControl_startCode);
            this.panelControl_startEnd.Controls.Add(this.labelControl2);
            this.panelControl_startEnd.Controls.Add(this.spinEdit_startCode);
            this.panelControl_startEnd.Controls.Add(this.spinEdit_endCode);
            this.panelControl_startEnd.Location = new System.Drawing.Point(11, 126);
            this.panelControl_startEnd.Name = "panelControl_startEnd";
            this.panelControl_startEnd.Size = new System.Drawing.Size(147, 56);
            this.panelControl_startEnd.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 236);
            this.Controls.Add(this.panelControl_startEnd);
            this.Controls.Add(this.panelControl_N余);
            this.Controls.Add(this.Button_openChrome);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.radioGroup1);
            this.Controls.Add(this.textEdit_saveName);
            this.Controls.Add(this.button_moshibianji);
            this.Controls.Add(this.checkEdit_topMost);
            this.Controls.Add(this.labelControl_touzhuNumber);
            this.Controls.Add(this.spinEdit_dandanNumber);
            this.Controls.Add(this.button_shoudong_zidingyi);
            this.Controls.Add(this.button_shoudong_byxml);
            this.Controls.Add(this.button_startTouZhu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动投注(chrome)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_dandanNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_startCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_endCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_topMost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_saveName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_N余.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_余N.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_N余)).EndInit();
            this.panelControl_N余.ResumeLayout(false);
            this.panelControl_N余.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl_startEnd)).EndInit();
            this.panelControl_startEnd.ResumeLayout(false);
            this.panelControl_startEnd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private DevExpress.XtraEditors.SimpleButton button_startTouZhu;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton button_shoudong_byxml;
        private DevExpress.XtraEditors.SimpleButton button_shoudong_zidingyi;
        private DevExpress.XtraEditors.SpinEdit spinEdit_dandanNumber;
        private DevExpress.XtraEditors.LabelControl labelControl_touzhuNumber;
        private DevExpress.XtraEditors.LabelControl labelControl_startCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit spinEdit_startCode;
        private DevExpress.XtraEditors.SpinEdit spinEdit_endCode;
        private DevExpress.XtraEditors.CheckEdit checkEdit_topMost;
        private DevExpress.XtraEditors.SimpleButton button_moshibianji;
        private DevExpress.XtraEditors.TextEdit textEdit_saveName;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_N余;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_余N;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton Button_openChrome;
        private DevExpress.XtraEditors.PanelControl panelControl_N余;
        private DevExpress.XtraEditors.PanelControl panelControl_startEnd;
    }
}

