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
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_dandanNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_startCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_endCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button_startTouZhu
            // 
            this.button_startTouZhu.Location = new System.Drawing.Point(170, 7);
            this.button_startTouZhu.Name = "button_startTouZhu";
            this.button_startTouZhu.Size = new System.Drawing.Size(153, 45);
            this.button_startTouZhu.TabIndex = 0;
            this.button_startTouZhu.Text = "开始投注";
            this.button_startTouZhu.Click += new System.EventHandler(this.button_startTouZhu_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_shoudong_byxml
            // 
            this.button_shoudong_byxml.Location = new System.Drawing.Point(170, 69);
            this.button_shoudong_byxml.Name = "button_shoudong_byxml";
            this.button_shoudong_byxml.Size = new System.Drawing.Size(153, 45);
            this.button_shoudong_byxml.TabIndex = 2;
            this.button_shoudong_byxml.Text = "手动投注(根据xml)";
            this.button_shoudong_byxml.Click += new System.EventHandler(this.button_shoudong_Click);
            // 
            // button_shoudong_zidingyi
            // 
            this.button_shoudong_zidingyi.Location = new System.Drawing.Point(170, 130);
            this.button_shoudong_zidingyi.Name = "button_shoudong_zidingyi";
            this.button_shoudong_zidingyi.Size = new System.Drawing.Size(153, 45);
            this.button_shoudong_zidingyi.TabIndex = 4;
            this.button_shoudong_zidingyi.Text = "手动投注(根据左边)";
            this.button_shoudong_zidingyi.Click += new System.EventHandler(this.button_shoudong_zidingyi_Click);
            // 
            // spinEdit_dandanNumber
            // 
            this.spinEdit_dandanNumber.EditValue = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.spinEdit_dandanNumber.Location = new System.Drawing.Point(19, 32);
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
            this.spinEdit_dandanNumber.Size = new System.Drawing.Size(117, 20);
            this.spinEdit_dandanNumber.TabIndex = 5;
            // 
            // labelControl_touzhuNumber
            // 
            this.labelControl_touzhuNumber.Location = new System.Drawing.Point(46, 12);
            this.labelControl_touzhuNumber.Name = "labelControl_touzhuNumber";
            this.labelControl_touzhuNumber.Size = new System.Drawing.Size(48, 14);
            this.labelControl_touzhuNumber.TabIndex = 6;
            this.labelControl_touzhuNumber.Text = "投注数量";
            // 
            // labelControl_startCode
            // 
            this.labelControl_startCode.Location = new System.Drawing.Point(46, 74);
            this.labelControl_startCode.Name = "labelControl_startCode";
            this.labelControl_startCode.Size = new System.Drawing.Size(48, 14);
            this.labelControl_startCode.TabIndex = 7;
            this.labelControl_startCode.Text = "开始号码";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(46, 130);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "结束号码";
            // 
            // spinEdit_startCode
            // 
            this.spinEdit_startCode.EditValue = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.spinEdit_startCode.Location = new System.Drawing.Point(19, 94);
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
            this.spinEdit_startCode.Size = new System.Drawing.Size(117, 20);
            this.spinEdit_startCode.TabIndex = 9;
            // 
            // spinEdit_endCode
            // 
            this.spinEdit_endCode.EditValue = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.spinEdit_endCode.Location = new System.Drawing.Point(19, 150);
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
            this.spinEdit_endCode.Size = new System.Drawing.Size(117, 20);
            this.spinEdit_endCode.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 196);
            this.Controls.Add(this.spinEdit_endCode);
            this.Controls.Add(this.spinEdit_startCode);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl_startCode);
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
            this.Text = "自动投注(火狐)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_dandanNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_startCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_endCode.Properties)).EndInit();
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
    }
}

