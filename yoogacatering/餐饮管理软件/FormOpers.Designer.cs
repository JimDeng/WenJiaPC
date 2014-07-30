namespace yoogacatering
{
    partial class FormOpers
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbOpenID = new System.Windows.Forms.TextBox();
            this.tbOperName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOperPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbOperPos = new System.Windows.Forms.ComboBox();
            this.cbOperSex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbOK = new System.Windows.Forms.Label();
            this.lbCancel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lxGrant = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lxNoGrant = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "编码(登录名)";
            // 
            // tbOpenID
            // 
            this.tbOpenID.Location = new System.Drawing.Point(130, 34);
            this.tbOpenID.Name = "tbOpenID";
            this.tbOpenID.Size = new System.Drawing.Size(171, 34);
            this.tbOpenID.TabIndex = 1;
            // 
            // tbOperName
            // 
            this.tbOperName.Location = new System.Drawing.Point(490, 34);
            this.tbOperName.Name = "tbOperName";
            this.tbOperName.Size = new System.Drawing.Size(149, 34);
            this.tbOperName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "操作员姓名";
            // 
            // tbOperPwd
            // 
            this.tbOperPwd.Location = new System.Drawing.Point(130, 88);
            this.tbOperPwd.Name = "tbOperPwd";
            this.tbOperPwd.PasswordChar = '*';
            this.tbOperPwd.Size = new System.Drawing.Size(509, 34);
            this.tbOperPwd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "职务";
            // 
            // cbOperPos
            // 
            this.cbOperPos.FormattingEnabled = true;
            this.cbOperPos.Location = new System.Drawing.Point(130, 147);
            this.cbOperPos.Name = "cbOperPos";
            this.cbOperPos.Size = new System.Drawing.Size(155, 35);
            this.cbOperPos.TabIndex = 7;
            // 
            // cbOperSex
            // 
            this.cbOperSex.FormattingEnabled = true;
            this.cbOperSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbOperSex.Location = new System.Drawing.Point(490, 139);
            this.cbOperSex.Name = "cbOperSex";
            this.cbOperSex.Size = new System.Drawing.Size(149, 35);
            this.cbOperSex.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "性别";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbOperSex);
            this.groupBox1.Controls.Add(this.tbOpenID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbOperPos);
            this.groupBox1.Controls.Add(this.tbOperName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbOperPwd);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 199);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lxNoGrant);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lxGrant);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(25, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 275);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "权限信息";
            // 
            // lbOK
            // 
            this.lbOK.BackColor = System.Drawing.Color.Black;
            this.lbOK.ForeColor = System.Drawing.Color.White;
            this.lbOK.Location = new System.Drawing.Point(229, 508);
            this.lbOK.Name = "lbOK";
            this.lbOK.Size = new System.Drawing.Size(97, 45);
            this.lbOK.TabIndex = 12;
            this.lbOK.Text = "增加";
            this.lbOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbOK.Click += new System.EventHandler(this.lbOK_Click);
            // 
            // lbCancel
            // 
            this.lbCancel.BackColor = System.Drawing.Color.Black;
            this.lbCancel.ForeColor = System.Drawing.Color.White;
            this.lbCancel.Location = new System.Drawing.Point(399, 508);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(97, 45);
            this.lbCancel.TabIndex = 13;
            this.lbCancel.Text = "取消";
            this.lbCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label8.Location = new System.Drawing.Point(31, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "已授予权限";
            // 
            // lxGrant
            // 
            this.lxGrant.FormattingEnabled = true;
            this.lxGrant.ItemHeight = 27;
            this.lxGrant.Location = new System.Drawing.Point(31, 58);
            this.lxGrant.Name = "lxGrant";
            this.lxGrant.Size = new System.Drawing.Size(219, 193);
            this.lxGrant.TabIndex = 1;
            this.lxGrant.DoubleClick += new System.EventHandler(this.lxGrant_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 27);
            this.label9.TabIndex = 2;
            this.label9.Text = "双击==>";
            // 
            // lxNoGrant
            // 
            this.lxNoGrant.FormattingEnabled = true;
            this.lxNoGrant.ItemHeight = 27;
            this.lxNoGrant.Location = new System.Drawing.Point(422, 58);
            this.lxNoGrant.Name = "lxNoGrant";
            this.lxNoGrant.Size = new System.Drawing.Size(219, 193);
            this.lxNoGrant.TabIndex = 4;
            this.lxNoGrant.DoubleClick += new System.EventHandler(this.lxNoGrant_DoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label10.Location = new System.Drawing.Point(422, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "未授予权限";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(275, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 27);
            this.label11.TabIndex = 5;
            this.label11.Text = "<==击双";
            // 
            // FormOpers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 571);
            this.ControlBox = false;
            this.Controls.Add(this.lbCancel);
            this.Controls.Add(this.lbOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FormOpers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增操作员";
            this.Load += new System.EventHandler(this.FormOpers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOpenID;
        private System.Windows.Forms.TextBox tbOperName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOperPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbOperPos;
        private System.Windows.Forms.ComboBox cbOperSex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbOK;
        private System.Windows.Forms.Label lbCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lxGrant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lxNoGrant;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}