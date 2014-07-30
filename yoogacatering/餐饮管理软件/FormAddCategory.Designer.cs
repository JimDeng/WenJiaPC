namespace yoogacatering
{
    partial class FormAddCategory
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
            this.cbCategoryBelong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.lbAddCategory = new System.Windows.Forms.Label();
            this.lbCancelAddCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "所属类别：";
            // 
            // cbCategoryBelong
            // 
            this.cbCategoryBelong.FormattingEnabled = true;
            this.cbCategoryBelong.Items.AddRange(new object[] {
            "酒吧"});
            this.cbCategoryBelong.Location = new System.Drawing.Point(193, 50);
            this.cbCategoryBelong.Name = "cbCategoryBelong";
            this.cbCategoryBelong.Size = new System.Drawing.Size(195, 36);
            this.cbCategoryBelong.TabIndex = 1;
            this.cbCategoryBelong.Text = "厨房";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "分类名称：";
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Location = new System.Drawing.Point(195, 123);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(193, 35);
            this.tbCategoryName.TabIndex = 3;
            // 
            // lbAddCategory
            // 
            this.lbAddCategory.BackColor = System.Drawing.Color.Black;
            this.lbAddCategory.ForeColor = System.Drawing.Color.White;
            this.lbAddCategory.Location = new System.Drawing.Point(108, 199);
            this.lbAddCategory.Name = "lbAddCategory";
            this.lbAddCategory.Size = new System.Drawing.Size(106, 41);
            this.lbAddCategory.TabIndex = 4;
            this.lbAddCategory.Text = "增加";
            this.lbAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAddCategory.Click += new System.EventHandler(this.lbAddCategory_Click);
            // 
            // lbCancelAddCategory
            // 
            this.lbCancelAddCategory.BackColor = System.Drawing.Color.Black;
            this.lbCancelAddCategory.ForeColor = System.Drawing.Color.White;
            this.lbCancelAddCategory.Location = new System.Drawing.Point(257, 199);
            this.lbCancelAddCategory.Name = "lbCancelAddCategory";
            this.lbCancelAddCategory.Size = new System.Drawing.Size(106, 41);
            this.lbCancelAddCategory.TabIndex = 5;
            this.lbCancelAddCategory.Text = "取消";
            this.lbCancelAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCancelAddCategory.Click += new System.EventHandler(this.lbCancelAddCategory_Click);
            // 
            // FormAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 273);
            this.ControlBox = false;
            this.Controls.Add(this.lbCancelAddCategory);
            this.Controls.Add(this.lbAddCategory);
            this.Controls.Add(this.tbCategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategoryBelong);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FormAddCategory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增分类";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoryBelong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.Label lbAddCategory;
        private System.Windows.Forms.Label lbCancelAddCategory;
    }
}