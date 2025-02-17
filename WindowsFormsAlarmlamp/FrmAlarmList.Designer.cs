namespace WindowsFormsAlarmlamp
{
    partial class FrmAlarmList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAlarmList = new System.Windows.Forms.DataGridView();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlarmTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlarmState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlarmNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlarmList
            // 
            this.dgvAlarmList.AllowUserToAddRows = false;
            this.dgvAlarmList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlarmList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlarmList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAlarmList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlarmList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlarmList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlarmList.ColumnHeadersHeight = 35;
            this.dgvAlarmList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid,
            this.colAlarmTime,
            this.colType,
            this.colAlarmState,
            this.colValue,
            this.colAlarmNote});
            this.dgvAlarmList.EnableHeadersVisualStyles = false;
            this.dgvAlarmList.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvAlarmList.Location = new System.Drawing.Point(26, 25);
            this.dgvAlarmList.Name = "dgvAlarmList";
            this.dgvAlarmList.RowTemplate.Height = 23;
            this.dgvAlarmList.Size = new System.Drawing.Size(808, 500);
            this.dgvAlarmList.TabIndex = 0;
            this.dgvAlarmList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlarmList_CellContentClick);
            // 
            // colid
            // 
            this.colid.DataPropertyName = "id";
            this.colid.HeaderText = "编号";
            this.colid.Name = "colid";
            // 
            // colAlarmTime
            // 
            this.colAlarmTime.DataPropertyName = "AlarmTime";
            this.colAlarmTime.FillWeight = 150F;
            this.colAlarmTime.HeaderText = "报警时间";
            this.colAlarmTime.Name = "colAlarmTime";
            // 
            // colType
            // 
            this.colType.DataPropertyName = "AlarmType";
            this.colType.HeaderText = "报警类型";
            this.colType.Name = "colType";
            // 
            // colAlarmState
            // 
            this.colAlarmState.HeaderText = "报警状态";
            this.colAlarmState.Name = "colAlarmState";
            // 
            // colValue
            // 
            this.colValue.DataPropertyName = "Value";
            this.colValue.FillWeight = 50F;
            this.colValue.HeaderText = "当前值";
            this.colValue.Name = "colValue";
            // 
            // colAlarmNote
            // 
            this.colAlarmNote.DataPropertyName = "AlarmNote";
            this.colAlarmNote.FillWeight = 150F;
            this.colAlarmNote.HeaderText = "报警描述";
            this.colAlarmNote.Name = "colAlarmNote";
            // 
            // FrmAlarmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 575);
            this.Controls.Add(this.dgvAlarmList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAlarmList";
            this.Text = "预警记录列表";
            this.Load += new System.EventHandler(this.FrmAlarmList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlarmList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlarmTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlarmState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlarmNote;
    }
}