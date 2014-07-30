namespace yoogacatering
{
    partial class FormMessage
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
            this.lbmsg = new System.Windows.Forms.Label();
            this.lbOK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbmsg
            // 
            this.lbmsg.AutoSize = true;
            this.lbmsg.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbmsg.Location = new System.Drawing.Point(57, 51);
            this.lbmsg.Name = "lbmsg";
            this.lbmsg.Size = new System.Drawing.Size(110, 31);
            this.lbmsg.TabIndex = 0;
            this.lbmsg.Text = "消息内容";
            // 
            // lbOK
            // 
            this.lbOK.BackColor = System.Drawing.Color.LimeGreen;
            this.lbOK.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbOK.ForeColor = System.Drawing.Color.White;
            this.lbOK.Location = new System.Drawing.Point(171, 155);
            this.lbOK.Name = "lbOK";
            this.lbOK.Size = new System.Drawing.Size(116, 53);
            this.lbOK.TabIndex = 1;
            this.lbOK.Text = "确定";
            this.lbOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbOK.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 252);
            this.ControlBox = false;
            this.Controls.Add(this.lbOK);
            this.Controls.Add(this.lbmsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMessage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMessage";
            this.Load += new System.EventHandler(this.FormMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbmsg;
        private System.Windows.Forms.Label lbOK;
    }
}