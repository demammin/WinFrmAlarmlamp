namespace WindowsFormsAlarmlamp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.uPump2 = new WindowsFormsAlarmlamp.UControler.UPump();
            this.uPump1 = new WindowsFormsAlarmlamp.UControler.UPump();
            this.lightPump01Fre = new WindowsFormsAlarmlamp.UControler.UCAlarmControl();
            this.lightPump02Fre = new WindowsFormsAlarmlamp.UControler.UCAlarmControl();
            this.lblState = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.uPump3 = new WindowsFormsAlarmlamp.UControler.UPump();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAlarmList = new System.Windows.Forms.Button();
            this.txtPump01Fre = new WindowsFormsAlarmlamp.UControler.ParaTextBox();
            this.lightPump01Power = new WindowsFormsAlarmlamp.UControler.UCAlarmControl();
            this.lightPump02Power = new WindowsFormsAlarmlamp.UControler.UCAlarmControl();
            this.lightPump03Power = new WindowsFormsAlarmlamp.UControler.UCAlarmControl();
            this.lightPump03Fre = new WindowsFormsAlarmlamp.UControler.UCAlarmControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPump01Power = new WindowsFormsAlarmlamp.UControler.ParaTextBox();
            this.txtPump02Fre = new WindowsFormsAlarmlamp.UControler.ParaTextBox();
            this.txtPump02Power = new WindowsFormsAlarmlamp.UControler.ParaTextBox();
            this.txtPump03Fre = new WindowsFormsAlarmlamp.UControler.ParaTextBox();
            this.txtPump03Power = new WindowsFormsAlarmlamp.UControler.ParaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uPump2
            // 
            this.uPump2.ActualState = false;
            this.uPump2.BtnBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uPump2.BtnText = "OFF";
            this.uPump2.LightImg = ((System.Drawing.Bitmap)(resources.GetObject("uPump2.LightImg")));
            this.uPump2.Location = new System.Drawing.Point(319, 203);
            this.uPump2.Name = "uPump2";
            this.uPump2.PumpStateName = "Pump02State";
            this.uPump2.Size = new System.Drawing.Size(122, 144);
            this.uPump2.TabIndex = 4;
            // 
            // uPump1
            // 
            this.uPump1.ActualState = false;
            this.uPump1.BtnBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uPump1.BtnText = "OFF";
            this.uPump1.LightImg = ((System.Drawing.Bitmap)(resources.GetObject("uPump1.LightImg")));
            this.uPump1.Location = new System.Drawing.Point(108, 203);
            this.uPump1.Name = "uPump1";
            this.uPump1.PumpStateName = "Pump01State";
            this.uPump1.Size = new System.Drawing.Size(122, 144);
            this.uPump1.TabIndex = 3;
            // 
            // lightPump01Fre
            // 
            this.lightPump01Fre.AlarmLightColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Yellow};
            this.lightPump01Fre.IsOn = false;
            this.lightPump01Fre.Location = new System.Drawing.Point(244, 394);
            this.lightPump01Fre.Name = "lightPump01Fre";
            this.lightPump01Fre.Size = new System.Drawing.Size(35, 30);
            this.lightPump01Fre.TabIndex = 5;
            this.lightPump01Fre.TwinkleInterval = 200;
            this.lightPump01Fre.VarName = null;
            // 
            // lightPump02Fre
            // 
            this.lightPump02Fre.AlarmLightColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Olive};
            this.lightPump02Fre.IsOn = true;
            this.lightPump02Fre.Location = new System.Drawing.Point(477, 390);
            this.lightPump02Fre.Name = "lightPump02Fre";
            this.lightPump02Fre.Size = new System.Drawing.Size(40, 30);
            this.lightPump02Fre.TabIndex = 6;
            this.lightPump02Fre.TwinkleInterval = 100;
            this.lightPump02Fre.VarName = null;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblState.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblState.Location = new System.Drawing.Point(228, 64);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(51, 20);
            this.lblState.TabIndex = 7;
            this.lblState.Text = "未启动";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.SandyBrown;
            this.label2.Location = new System.Drawing.Point(132, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "1#水泵";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.SandyBrown;
            this.label3.Location = new System.Drawing.Point(487, -49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "2#水泵";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.SandyBrown;
            this.label4.Location = new System.Drawing.Point(361, -93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "3#水泵";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(104, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "频率";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(104, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "功率";
            // 
            // uPump3
            // 
            this.uPump3.ActualState = false;
            this.uPump3.BtnBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uPump3.BtnText = "OFF";
            this.uPump3.LightImg = ((System.Drawing.Bitmap)(resources.GetObject("uPump3.LightImg")));
            this.uPump3.Location = new System.Drawing.Point(590, 203);
            this.uPump3.Name = "uPump3";
            this.uPump3.PumpStateName = "Pump03State";
            this.uPump3.Size = new System.Drawing.Size(122, 144);
            this.uPump3.TabIndex = 17;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnStart.Location = new System.Drawing.Point(115, 64);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 30);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlarmList
            // 
            this.btnAlarmList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAlarmList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAlarmList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAlarmList.Location = new System.Drawing.Point(590, 57);
            this.btnAlarmList.Name = "btnAlarmList";
            this.btnAlarmList.Size = new System.Drawing.Size(77, 35);
            this.btnAlarmList.TabIndex = 19;
            this.btnAlarmList.Text = "预警列表";
            this.btnAlarmList.UseVisualStyleBackColor = false;
            this.btnAlarmList.Click += new System.EventHandler(this.btnAlarmList_Click);
            // 
            // txtPump01Fre
            // 
            this.txtPump01Fre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPump01Fre.DataVal = "150";
            this.txtPump01Fre.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.txtPump01Fre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPump01Fre.Location = new System.Drawing.Point(149, 391);
            this.txtPump01Fre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPump01Fre.Name = "txtPump01Fre";
            this.txtPump01Fre.Size = new System.Drawing.Size(71, 29);
            this.txtPump01Fre.TabIndex = 20;
            this.txtPump01Fre.Unit = "Hz";
            this.txtPump01Fre.VarName = "Pump01Fre";
            // 
            // lightPump01Power
            // 
            this.lightPump01Power.AlarmLightColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.Yellow};
            this.lightPump01Power.IsOn = false;
            this.lightPump01Power.Location = new System.Drawing.Point(244, 440);
            this.lightPump01Power.Name = "lightPump01Power";
            this.lightPump01Power.Size = new System.Drawing.Size(35, 33);
            this.lightPump01Power.TabIndex = 25;
            this.lightPump01Power.TwinkleInterval = 200;
            this.lightPump01Power.VarName = null;
            // 
            // lightPump02Power
            // 
            this.lightPump02Power.AlarmLightColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.Yellow};
            this.lightPump02Power.IsOn = false;
            this.lightPump02Power.Location = new System.Drawing.Point(477, 443);
            this.lightPump02Power.Name = "lightPump02Power";
            this.lightPump02Power.Size = new System.Drawing.Size(40, 30);
            this.lightPump02Power.TabIndex = 26;
            this.lightPump02Power.TwinkleInterval = 200;
            this.lightPump02Power.VarName = null;
            // 
            // lightPump03Power
            // 
            this.lightPump03Power.AlarmLightColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.Yellow};
            this.lightPump03Power.IsOn = false;
            this.lightPump03Power.Location = new System.Drawing.Point(725, 443);
            this.lightPump03Power.Name = "lightPump03Power";
            this.lightPump03Power.Size = new System.Drawing.Size(39, 30);
            this.lightPump03Power.TabIndex = 28;
            this.lightPump03Power.TwinkleInterval = 200;
            this.lightPump03Power.VarName = null;
            // 
            // lightPump03Fre
            // 
            this.lightPump03Fre.AlarmLightColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))))};
            this.lightPump03Fre.IsOn = false;
            this.lightPump03Fre.Location = new System.Drawing.Point(725, 389);
            this.lightPump03Fre.Name = "lightPump03Fre";
            this.lightPump03Fre.Size = new System.Drawing.Size(39, 30);
            this.lightPump03Fre.TabIndex = 27;
            this.lightPump03Fre.TwinkleInterval = 100;
            this.lightPump03Fre.VarName = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(315, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "功率";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(315, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "频率";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(573, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "功率";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(573, 391);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 20);
            this.label12.TabIndex = 33;
            this.label12.Text = "频率";
            // 
            // txtPump01Power
            // 
            this.txtPump01Power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPump01Power.DataVal = "150";
            this.txtPump01Power.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.txtPump01Power.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPump01Power.Location = new System.Drawing.Point(149, 443);
            this.txtPump01Power.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPump01Power.Name = "txtPump01Power";
            this.txtPump01Power.Size = new System.Drawing.Size(71, 29);
            this.txtPump01Power.TabIndex = 35;
            this.txtPump01Power.Unit = "Kw";
            this.txtPump01Power.VarName = "Pump01Power";
            // 
            // txtPump02Fre
            // 
            this.txtPump02Fre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPump02Fre.DataVal = "200";
            this.txtPump02Fre.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.txtPump02Fre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPump02Fre.Location = new System.Drawing.Point(377, 391);
            this.txtPump02Fre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPump02Fre.Name = "txtPump02Fre";
            this.txtPump02Fre.Size = new System.Drawing.Size(71, 29);
            this.txtPump02Fre.TabIndex = 36;
            this.txtPump02Fre.Unit = "Hz";
            this.txtPump02Fre.VarName = "Pump02Fre";
            // 
            // txtPump02Power
            // 
            this.txtPump02Power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPump02Power.DataVal = "100";
            this.txtPump02Power.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.txtPump02Power.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPump02Power.Location = new System.Drawing.Point(379, 443);
            this.txtPump02Power.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPump02Power.Name = "txtPump02Power";
            this.txtPump02Power.Size = new System.Drawing.Size(71, 29);
            this.txtPump02Power.TabIndex = 37;
            this.txtPump02Power.Unit = "Kw";
            this.txtPump02Power.VarName = "Pump02Power";
            // 
            // txtPump03Fre
            // 
            this.txtPump03Fre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPump03Fre.DataVal = "120";
            this.txtPump03Fre.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.txtPump03Fre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPump03Fre.Location = new System.Drawing.Point(630, 390);
            this.txtPump03Fre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPump03Fre.Name = "txtPump03Fre";
            this.txtPump03Fre.Size = new System.Drawing.Size(71, 29);
            this.txtPump03Fre.TabIndex = 38;
            this.txtPump03Fre.Unit = "Hz";
            this.txtPump03Fre.VarName = "Pump03Fre";
            // 
            // txtPump03Power
            // 
            this.txtPump03Power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPump03Power.DataVal = "110";
            this.txtPump03Power.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.txtPump03Power.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPump03Power.Location = new System.Drawing.Point(630, 443);
            this.txtPump03Power.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPump03Power.Name = "txtPump03Power";
            this.txtPump03Power.Size = new System.Drawing.Size(71, 27);
            this.txtPump03Power.TabIndex = 39;
            this.txtPump03Power.Unit = "Kw";
            this.txtPump03Power.VarName = "Pump03Power";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(338, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "2#水泵";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.SandyBrown;
            this.label8.Location = new System.Drawing.Point(586, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 41;
            this.label8.Text = "3#水泵";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 595);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPump03Power);
            this.Controls.Add(this.txtPump03Fre);
            this.Controls.Add(this.txtPump02Power);
            this.Controls.Add(this.txtPump02Fre);
            this.Controls.Add(this.txtPump01Power);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lightPump03Power);
            this.Controls.Add(this.lightPump03Fre);
            this.Controls.Add(this.lightPump02Power);
            this.Controls.Add(this.lightPump01Power);
            this.Controls.Add(this.txtPump01Fre);
            this.Controls.Add(this.btnAlarmList);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.uPump3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lightPump02Fre);
            this.Controls.Add(this.lightPump01Fre);
            this.Controls.Add(this.uPump2);
            this.Controls.Add(this.uPump1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "预警管理系统";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UControler.UPump uPump1;
        private UControler.UPump uPump2;
        private UControler.UCAlarmControl lightPump01Fre;
        private UControler.UCAlarmControl lightPump02Fre;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private UControler.UPump uPump3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAlarmList;
        private UControler.ParaTextBox txtPump01Fre;
        private UControler.UCAlarmControl lightPump01Power;
        private UControler.UCAlarmControl lightPump02Power;
        private UControler.UCAlarmControl lightPump03Power;
        private UControler.UCAlarmControl lightPump03Fre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private UControler.ParaTextBox txtPump01Power;
        private UControler.ParaTextBox txtPump02Fre;
        private UControler.ParaTextBox txtPump02Power;
        private UControler.ParaTextBox txtPump03Fre;
        private UControler.ParaTextBox txtPump03Power;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}

