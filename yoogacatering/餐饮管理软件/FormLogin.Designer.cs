namespace yoogacatering
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbCancel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUserID
            // 
            this.tbUserID.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tbUserID.Location = new System.Drawing.Point(104, 111);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(155, 23);
            this.tbUserID.TabIndex = 0;
            this.tbUserID.Text = "admin";
            // 
            // tbPwd
            // 
            this.tbPwd.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tbPwd.Location = new System.Drawing.Point(104, 146);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.PasswordChar = '*';
            this.tbPwd.Size = new System.Drawing.Size(155, 23);
            this.tbPwd.TabIndex = 1;
            this.tbPwd.Text = "admin";
            this.tbPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPwd_KeyPress);
            // 
            // lbLogin
            // 
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Location = new System.Drawing.Point(279, 121);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(61, 48);
            this.lbLogin.TabIndex = 2;
            this.lbLogin.Click += new System.EventHandler(this.lbLogin_Click);
            // 
            // lbCancel
            // 
            this.lbCancel.BackColor = System.Drawing.Color.Transparent;
            this.lbCancel.Location = new System.Drawing.Point(361, 155);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(49, 34);
            this.lbCancel.TabIndex = 3;
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(434, 206);
            this.Controls.Add(this.lbCancel);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbUserID);
            this.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbCancel;
    }
}