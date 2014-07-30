namespace yoogacatering
{
    partial class FormAddPlan
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
            this.dvFood = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchStr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCnName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nuCount = new System.Windows.Forms.NumericUpDown();
            this.lbAdd = new System.Windows.Forms.Label();
            this.lbCancel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dvFood
            // 
            this.dvFood.AllowUserToAddRows = false;
            this.dvFood.AllowUserToResizeRows = false;
            this.dvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cnname,
            this.enName,
            this.price,
            this.category,
            this.foodunit});
            this.dvFood.Location = new System.Drawing.Point(28, 13);
            this.dvFood.Name = "dvFood";
            this.dvFood.ReadOnly = true;
            this.dvFood.RowHeadersVisible = false;
            this.dvFood.RowTemplate.Height = 23;
            this.dvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvFood.Size = new System.Drawing.Size(595, 284);
            this.dvFood.TabIndex = 0;
            this.dvFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvFood_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "搜索";
            // 
            // tbSearchStr
            // 
            this.tbSearchStr.Location = new System.Drawing.Point(148, 316);
            this.tbSearchStr.Name = "tbSearchStr";
            this.tbSearchStr.Size = new System.Drawing.Size(420, 35);
            this.tbSearchStr.TabIndex = 2;
            this.tbSearchStr.TextChanged += new System.EventHandler(this.tbSearchStr_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "所选餐品名称";
            // 
            // tbCnName
            // 
            this.tbCnName.Location = new System.Drawing.Point(215, 381);
            this.tbCnName.Name = "tbCnName";
            this.tbCnName.ReadOnly = true;
            this.tbCnName.Size = new System.Drawing.Size(149, 35);
            this.tbCnName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "数量";
            // 
            // nuCount
            // 
            this.nuCount.Location = new System.Drawing.Point(467, 381);
            this.nuCount.Name = "nuCount";
            this.nuCount.Size = new System.Drawing.Size(101, 35);
            this.nuCount.TabIndex = 6;
            this.nuCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbAdd
            // 
            this.lbAdd.BackColor = System.Drawing.Color.Black;
            this.lbAdd.ForeColor = System.Drawing.Color.White;
            this.lbAdd.Location = new System.Drawing.Point(180, 447);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(106, 41);
            this.lbAdd.TabIndex = 7;
            this.lbAdd.Text = "确定";
            this.lbAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAdd.Visible = false;
            this.lbAdd.Click += new System.EventHandler(this.lbAdd_Click);
            // 
            // lbCancel
            // 
            this.lbCancel.BackColor = System.Drawing.Color.Black;
            this.lbCancel.ForeColor = System.Drawing.Color.White;
            this.lbCancel.Location = new System.Drawing.Point(335, 447);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(106, 41);
            this.lbCancel.TabIndex = 8;
            this.lbCancel.Text = "取消";
            this.lbCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // id
            // 
            this.id.HeaderText = "编号";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // cnname
            // 
            this.cnname.HeaderText = "名称";
            this.cnname.Name = "cnname";
            this.cnname.ReadOnly = true;
            // 
            // enName
            // 
            this.enName.HeaderText = "简写";
            this.enName.Name = "enName";
            this.enName.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "单价";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // category
            // 
            this.category.HeaderText = "分类";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // foodunit
            // 
            this.foodunit.HeaderText = "单位";
            this.foodunit.Name = "foodunit";
            this.foodunit.ReadOnly = true;
            // 
            // FormAddPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 501);
            this.ControlBox = false;
            this.Controls.Add(this.lbCancel);
            this.Controls.Add(this.lbAdd);
            this.Controls.Add(this.nuCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCnName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSearchStr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvFood);
            this.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FormAddPlan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择餐品";
            this.Load += new System.EventHandler(this.FormAddPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchStr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCnName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nuCount;
        private System.Windows.Forms.Label lbAdd;
        private System.Windows.Forms.Label lbCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnname;
        private System.Windows.Forms.DataGridViewTextBoxColumn enName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodunit;

    }
}