namespace WindowsFormsAlarmlamp.UControler
{
    partial class UPump
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSwitch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picLigth = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLigth)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.Coral;
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitch.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.btnSwitch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSwitch.Location = new System.Drawing.Point(56, 3);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(65, 30);
            this.btnSwitch.TabIndex = 2;
            this.btnSwitch.Text = "ON";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsAlarmlamp.Properties.Resources.jdb;
            this.pictureBox2.Location = new System.Drawing.Point(0, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // picLigth
            // 
            this.picLigth.Image = global::WindowsFormsAlarmlamp.Properties.Resources.light_off;
            this.picLigth.Location = new System.Drawing.Point(0, 0);
            this.picLigth.Name = "picLigth";
            this.picLigth.Size = new System.Drawing.Size(50, 33);
            this.picLigth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLigth.TabIndex = 0;
            this.picLigth.TabStop = false;
            // 
            // UPump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picLigth);
            this.Name = "UPump";
            this.Size = new System.Drawing.Size(127, 142);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLigth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLigth;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSwitch;
    }
}
