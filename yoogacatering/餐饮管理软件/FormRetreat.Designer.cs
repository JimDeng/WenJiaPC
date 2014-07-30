namespace yoogacatering
{
    partial class FormRetreat
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
            this.tbReason = new System.Windows.Forms.TextBox();
            this.lbRetreat = new System.Windows.Forms.Label();
            this.lbCancel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "退菜原因";
            // 
            // tbReason
            // 
            this.tbReason.Location = new System.Drawing.Point(54, 63);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(385, 75);
            this.tbReason.TabIndex = 1;
            // 
            // lbRetreat
            // 
            this.lbRetreat.BackColor = System.Drawing.Color.Black;
            this.lbRetreat.ForeColor = System.Drawing.Color.White;
            this.lbRetreat.Location = new System.Drawing.Point(116, 165);
            this.lbRetreat.Name = "lbRetreat";
            this.lbRetreat.Size = new System.Drawing.Size(82, 44);
            this.lbRetreat.TabIndex = 2;
            this.lbRetreat.Text = "确定";
            this.lbRetreat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbRetreat.Click += new System.EventHandler(this.lbRetreat_Click);
            // 
            // lbCancel
            // 
            this.lbCancel.BackColor = System.Drawing.Color.Black;
            this.lbCancel.ForeColor = System.Drawing.Color.White;
            this.lbCancel.Location = new System.Drawing.Point(267, 165);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(82, 44);
            this.lbCancel.TabIndex = 3;
            this.lbCancel.Text = "取消";
            this.lbCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // FormRetreat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 234);
            this.ControlBox = false;
            this.Controls.Add(this.lbCancel);
            this.Controls.Add(this.lbRetreat);
            this.Controls.Add(this.tbReason);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FormRetreat";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRetreat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbReason;
        private System.Windows.Forms.Label lbRetreat;
        private System.Windows.Forms.Label lbCancel;
    }
}