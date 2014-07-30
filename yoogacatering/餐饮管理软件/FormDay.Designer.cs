namespace yoogacatering
{
    partial class FormDay
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
            this.tabShift = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbCancel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbShift = new System.Windows.Forms.Label();
            this.tbRunSum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDisSum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPreSum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbBillCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbVesaSum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCashSum = new System.Windows.Forms.TextBox();
            this.tbTurnover = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastShiftTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dvShifts = new System.Windows.Forms.DataGridView();
            this.dtDay = new System.Windows.Forms.DateTimePicker();
            this.lbDay = new System.Windows.Forms.Label();
            this.结算人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.营业额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.现金 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.刷卡 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.整单优惠 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.折扣 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.挂账 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.记录数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabShift.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // tabShift
            // 
            this.tabShift.Controls.Add(this.tabPage1);
            this.tabShift.Controls.Add(this.tabPage2);
            this.tabShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabShift.Location = new System.Drawing.Point(0, 0);
            this.tabShift.Name = "tabShift";
            this.tabShift.SelectedIndex = 0;
            this.tabShift.Size = new System.Drawing.Size(750, 554);
            this.tabShift.TabIndex = 0;
            this.tabShift.SelectedIndexChanged += new System.EventHandler(this.tabShift_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbDay);
            this.tabPage1.Controls.Add(this.dtDay);
            this.tabPage1.Controls.Add(this.lbCancel);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.lbShift);
            this.tabPage1.Controls.Add(this.tbRunSum);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.tbDisSum);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.tbPreSum);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.tbBillCount);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tbVesaSum);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tbCashSum);
            this.tabPage1.Controls.Add(this.tbTurnover);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbLastShiftTime);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbUserName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "结算";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbCancel
            // 
            this.lbCancel.BackColor = System.Drawing.Color.Black;
            this.lbCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCancel.ForeColor = System.Drawing.Color.White;
            this.lbCancel.Location = new System.Drawing.Point(557, 454);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(97, 40);
            this.lbCancel.TabIndex = 45;
            this.lbCancel.Text = "取消";
            this.lbCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(56, 417);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(630, 2);
            this.label13.TabIndex = 44;
            this.label13.Text = "交班人";
            // 
            // lbShift
            // 
            this.lbShift.BackColor = System.Drawing.Color.Black;
            this.lbShift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbShift.ForeColor = System.Drawing.Color.White;
            this.lbShift.Location = new System.Drawing.Point(398, 454);
            this.lbShift.Name = "lbShift";
            this.lbShift.Size = new System.Drawing.Size(97, 40);
            this.lbShift.TabIndex = 43;
            this.lbShift.Text = "结算";
            this.lbShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbShift.Click += new System.EventHandler(this.lbShift_Click);
            // 
            // tbRunSum
            // 
            this.tbRunSum.Location = new System.Drawing.Point(231, 363);
            this.tbRunSum.Name = "tbRunSum";
            this.tbRunSum.ReadOnly = true;
            this.tbRunSum.Size = new System.Drawing.Size(125, 34);
            this.tbRunSum.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(98, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 27);
            this.label11.TabIndex = 41;
            this.label11.Text = "挂账合计";
            // 
            // tbDisSum
            // 
            this.tbDisSum.Location = new System.Drawing.Point(539, 304);
            this.tbDisSum.Name = "tbDisSum";
            this.tbDisSum.ReadOnly = true;
            this.tbDisSum.Size = new System.Drawing.Size(125, 34);
            this.tbDisSum.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(406, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 27);
            this.label10.TabIndex = 39;
            this.label10.Text = "打折合计";
            // 
            // tbPreSum
            // 
            this.tbPreSum.Location = new System.Drawing.Point(231, 304);
            this.tbPreSum.Name = "tbPreSum";
            this.tbPreSum.ReadOnly = true;
            this.tbPreSum.Size = new System.Drawing.Size(125, 34);
            this.tbPreSum.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 27);
            this.label9.TabIndex = 37;
            this.label9.Text = "整单优惠合计";
            // 
            // tbBillCount
            // 
            this.tbBillCount.Location = new System.Drawing.Point(539, 170);
            this.tbBillCount.Name = "tbBillCount";
            this.tbBillCount.ReadOnly = true;
            this.tbBillCount.Size = new System.Drawing.Size(125, 34);
            this.tbBillCount.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 27);
            this.label8.TabIndex = 35;
            this.label8.Text = "交易数量";
            // 
            // tbVesaSum
            // 
            this.tbVesaSum.Location = new System.Drawing.Point(539, 235);
            this.tbVesaSum.Name = "tbVesaSum";
            this.tbVesaSum.ReadOnly = true;
            this.tbVesaSum.Size = new System.Drawing.Size(125, 34);
            this.tbVesaSum.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 27);
            this.label7.TabIndex = 33;
            this.label7.Text = "刷卡合计";
            // 
            // tbCashSum
            // 
            this.tbCashSum.Location = new System.Drawing.Point(231, 235);
            this.tbCashSum.Name = "tbCashSum";
            this.tbCashSum.ReadOnly = true;
            this.tbCashSum.Size = new System.Drawing.Size(125, 34);
            this.tbCashSum.TabIndex = 32;
            // 
            // tbTurnover
            // 
            this.tbTurnover.Location = new System.Drawing.Point(231, 177);
            this.tbTurnover.Name = "tbTurnover";
            this.tbTurnover.ReadOnly = true;
            this.tbTurnover.Size = new System.Drawing.Size(125, 34);
            this.tbTurnover.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 27);
            this.label6.TabIndex = 30;
            this.label6.Text = "营业合计";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 27);
            this.label5.TabIndex = 29;
            this.label5.Text = "现金合计";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 27);
            this.label4.TabIndex = 27;
            this.label4.Text = "日期";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(56, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(630, 2);
            this.label3.TabIndex = 26;
            this.label3.Text = "交班人";
            // 
            // tbLastShiftTime
            // 
            this.tbLastShiftTime.Location = new System.Drawing.Point(419, 34);
            this.tbLastShiftTime.Name = "tbLastShiftTime";
            this.tbLastShiftTime.ReadOnly = true;
            this.tbLastShiftTime.Size = new System.Drawing.Size(245, 34);
            this.tbLastShiftTime.TabIndex = 25;
            this.tbLastShiftTime.Text = "2014-03-11 12：25：11";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "上次结算时间";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(143, 34);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.ReadOnly = true;
            this.tbUserName.Size = new System.Drawing.Size(125, 34);
            this.tbUserName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "结算人";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dvShifts);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "日结记录";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dvShifts
            // 
            this.dvShifts.AllowUserToAddRows = false;
            this.dvShifts.AllowUserToDeleteRows = false;
            this.dvShifts.AllowUserToResizeRows = false;
            this.dvShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvShifts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.结算人,
            this.时间,
            this.营业额,
            this.现金,
            this.刷卡,
            this.整单优惠,
            this.折扣,
            this.挂账,
            this.记录数});
            this.dvShifts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvShifts.Location = new System.Drawing.Point(3, 3);
            this.dvShifts.Name = "dvShifts";
            this.dvShifts.ReadOnly = true;
            this.dvShifts.RowHeadersVisible = false;
            this.dvShifts.RowTemplate.Height = 23;
            this.dvShifts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvShifts.Size = new System.Drawing.Size(736, 508);
            this.dvShifts.TabIndex = 0;
            // 
            // dtDay
            // 
            this.dtDay.Location = new System.Drawing.Point(231, 109);
            this.dtDay.Name = "dtDay";
            this.dtDay.Size = new System.Drawing.Size(237, 34);
            this.dtDay.TabIndex = 46;
            // 
            // lbDay
            // 
            this.lbDay.BackColor = System.Drawing.Color.Black;
            this.lbDay.ForeColor = System.Drawing.Color.White;
            this.lbDay.Location = new System.Drawing.Point(534, 109);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(66, 34);
            this.lbDay.TabIndex = 47;
            this.lbDay.Text = "计算";
            this.lbDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDay.Click += new System.EventHandler(this.lbDay_Click);
            // 
            // 结算人
            // 
            this.结算人.HeaderText = "结算人";
            this.结算人.Name = "结算人";
            this.结算人.ReadOnly = true;
            // 
            // 时间
            // 
            this.时间.HeaderText = "时间";
            this.时间.Name = "时间";
            this.时间.ReadOnly = true;
            this.时间.Width = 220;
            // 
            // 营业额
            // 
            this.营业额.HeaderText = "营业额";
            this.营业额.Name = "营业额";
            this.营业额.ReadOnly = true;
            // 
            // 现金
            // 
            this.现金.HeaderText = "现金";
            this.现金.Name = "现金";
            this.现金.ReadOnly = true;
            this.现金.Width = 82;
            // 
            // 刷卡
            // 
            this.刷卡.HeaderText = "刷卡";
            this.刷卡.Name = "刷卡";
            this.刷卡.ReadOnly = true;
            this.刷卡.Width = 81;
            // 
            // 整单优惠
            // 
            this.整单优惠.HeaderText = "整单优惠";
            this.整单优惠.Name = "整单优惠";
            this.整单优惠.ReadOnly = true;
            this.整单优惠.Width = 160;
            // 
            // 折扣
            // 
            this.折扣.HeaderText = "折扣";
            this.折扣.Name = "折扣";
            this.折扣.ReadOnly = true;
            this.折扣.Width = 81;
            // 
            // 挂账
            // 
            this.挂账.HeaderText = "挂账";
            this.挂账.Name = "挂账";
            this.挂账.ReadOnly = true;
            this.挂账.Width = 82;
            // 
            // 记录数
            // 
            this.记录数.HeaderText = "记录数";
            this.记录数.Name = "记录数";
            this.记录数.ReadOnly = true;
            this.记录数.Width = 140;
            // 
            // FormDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 554);
            this.ControlBox = false;
            this.Controls.Add(this.tabShift);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FormDay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "日结算";
            this.Load += new System.EventHandler(this.FormDay_Load);
            this.tabShift.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvShifts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabShift;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbShift;
        private System.Windows.Forms.TextBox tbRunSum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbDisSum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPreSum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbBillCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbVesaSum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCashSum;
        private System.Windows.Forms.TextBox tbTurnover;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastShiftTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCancel;
        private System.Windows.Forms.DataGridView dvShifts;
        private System.Windows.Forms.DateTimePicker dtDay;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结算人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 营业额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 现金;
        private System.Windows.Forms.DataGridViewTextBoxColumn 刷卡;
        private System.Windows.Forms.DataGridViewTextBoxColumn 整单优惠;
        private System.Windows.Forms.DataGridViewTextBoxColumn 折扣;
        private System.Windows.Forms.DataGridViewTextBoxColumn 挂账;
        private System.Windows.Forms.DataGridViewTextBoxColumn 记录数;
    }
}