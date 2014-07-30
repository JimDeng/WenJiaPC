namespace yoogacatering
{
    partial class FormChangeTab
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOrTabName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNewTabName = new System.Windows.Forms.ComboBox();
            this.lbOK = new System.Windows.Forms.Label();
            this.lbCancel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "换桌";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(2, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(530, 2);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "原桌号";
            // 
            // tbOrTabName
            // 
            this.tbOrTabName.Location = new System.Drawing.Point(119, 110);
            this.tbOrTabName.Name = "tbOrTabName";
            this.tbOrTabName.ReadOnly = true;
            this.tbOrTabName.Size = new System.Drawing.Size(72, 35);
            this.tbOrTabName.TabIndex = 3;
            this.tbOrTabName.Text = "A1";
            this.tbOrTabName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "转入桌号";
            // 
            // cbNewTabName
            // 
            this.cbNewTabName.FormattingEnabled = true;
            this.cbNewTabName.Location = new System.Drawing.Point(395, 109);
            this.cbNewTabName.Name = "cbNewTabName";
            this.cbNewTabName.Size = new System.Drawing.Size(81, 36);
            this.cbNewTabName.TabIndex = 0;
            this.cbNewTabName.Text = "A2";
            // 
            // lbOK
            // 
            this.lbOK.BackColor = System.Drawing.Color.Black;
            this.lbOK.ForeColor = System.Drawing.Color.White;
            this.lbOK.Location = new System.Drawing.Point(130, 210);
            this.lbOK.Name = "lbOK";
            this.lbOK.Size = new System.Drawing.Size(91, 48);
            this.lbOK.TabIndex = 6;
            this.lbOK.Text = "确定";
            this.lbOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbOK.Click += new System.EventHandler(this.lbOK_Click);
            // 
            // lbCancel
            // 
            this.lbCancel.BackColor = System.Drawing.Color.Black;
            this.lbCancel.ForeColor = System.Drawing.Color.White;
            this.lbCancel.Location = new System.Drawing.Point(296, 210);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(91, 48);
            this.lbCancel.TabIndex = 7;
            this.lbCancel.Text = "取消";
            this.lbCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // FormChangeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 335);
            this.ControlBox = false;
            this.Controls.Add(this.lbCancel);
            this.Controls.Add(this.lbOK);
            this.Controls.Add(this.cbNewTabName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbOrTabName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "FormChangeTab";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "换桌";
            this.Load += new System.EventHandler(this.FormChangeTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOrTabName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNewTabName;
        private System.Windows.Forms.Label lbOK;
        private System.Windows.Forms.Label lbCancel;
    }
}