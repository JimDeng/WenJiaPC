namespace yoogacatering
{
    partial class FormPrintSetting
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
            this.cbConPrinter = new System.Windows.Forms.ComboBox();
            this.cbBarPrinter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKitPrinter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbComName = new System.Windows.Forms.TextBox();
            this.lbOK = new System.Windows.Forms.Label();
            this.lbCancel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "收银打印机";
            // 
            // cbConPrinter
            // 
            this.cbConPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConPrinter.FormattingEnabled = true;
            this.cbConPrinter.Location = new System.Drawing.Point(190, 41);
            this.cbConPrinter.Name = "cbConPrinter";
            this.cbConPrinter.Size = new System.Drawing.Size(296, 36);
            this.cbConPrinter.TabIndex = 1;
            // 
            // cbBarPrinter
            // 
            this.cbBarPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBarPrinter.FormattingEnabled = true;
            this.cbBarPrinter.Location = new System.Drawing.Point(190, 102);
            this.cbBarPrinter.Name = "cbBarPrinter";
            this.cbBarPrinter.Size = new System.Drawing.Size(296, 36);
            this.cbBarPrinter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "酒吧打印机";
            // 
            // cbKitPrinter
            // 
            this.cbKitPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKitPrinter.FormattingEnabled = true;
            this.cbKitPrinter.Location = new System.Drawing.Point(190, 163);
            this.cbKitPrinter.Name = "cbKitPrinter";
            this.cbKitPrinter.Size = new System.Drawing.Size(296, 36);
            this.cbKitPrinter.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "厨房打印机";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "公司名称";
            // 
            // tbComName
            // 
            this.tbComName.Location = new System.Drawing.Point(190, 227);
            this.tbComName.Name = "tbComName";
            this.tbComName.Size = new System.Drawing.Size(296, 35);
            this.tbComName.TabIndex = 7;
            // 
            // lbOK
            // 
            this.lbOK.BackColor = System.Drawing.Color.Black;
            this.lbOK.ForeColor = System.Drawing.Color.White;
            this.lbOK.Location = new System.Drawing.Point(121, 309);
            this.lbOK.Name = "lbOK";
            this.lbOK.Size = new System.Drawing.Size(88, 54);
            this.lbOK.TabIndex = 8;
            this.lbOK.Text = "确定";
            this.lbOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbOK.Click += new System.EventHandler(this.lbOK_Click);
            // 
            // lbCancel
            // 
            this.lbCancel.BackColor = System.Drawing.Color.Black;
            this.lbCancel.ForeColor = System.Drawing.Color.White;
            this.lbCancel.Location = new System.Drawing.Point(324, 309);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(88, 54);
            this.lbCancel.TabIndex = 9;
            this.lbCancel.Text = "取消";
            this.lbCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // FormPrintSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 413);
            this.ControlBox = false;
            this.Controls.Add(this.lbCancel);
            this.Controls.Add(this.lbOK);
            this.Controls.Add(this.tbComName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbKitPrinter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbBarPrinter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbConPrinter);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "FormPrintSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打印设置";
            this.Load += new System.EventHandler(this.FormPrintSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbConPrinter;
        private System.Windows.Forms.ComboBox cbBarPrinter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKitPrinter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbComName;
        private System.Windows.Forms.Label lbOK;
        private System.Windows.Forms.Label lbCancel;
    }
}