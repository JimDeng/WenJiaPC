namespace yoogacatering
{
    partial class FormUpdateFood
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCnName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEnName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbNoDiscount = new System.Windows.Forms.RadioButton();
            this.rbCanDiscount = new System.Windows.Forms.RadioButton();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbUpload = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tcMoreInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbAddPlan = new System.Windows.Forms.Label();
            this.dvPlanInfo = new System.Windows.Forms.DataGridView();
            this.ops = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbIsPlan = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.nuKcCount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cbKC = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dvMaterials = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbAddMaterials = new System.Windows.Forms.Label();
            this.cbMaterials = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDes = new System.Windows.Forms.TextBox();
            this.lbUpdate = new System.Windows.Forms.Label();
            this.lbCancel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvfoodid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tcMoreInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvPlanInfo)).BeginInit();
            this.ops.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuKcCount)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMaterials)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // tbCnName
            // 
            this.tbCnName.Location = new System.Drawing.Point(117, 23);
            this.tbCnName.Margin = new System.Windows.Forms.Padding(2);
            this.tbCnName.Name = "tbCnName";
            this.tbCnName.ReadOnly = true;
            this.tbCnName.Size = new System.Drawing.Size(240, 29);
            this.tbCnName.TabIndex = 1;
            this.tbCnName.TextChanged += new System.EventHandler(this.tbCnName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "缩写";
            // 
            // tbEnName
            // 
            this.tbEnName.Location = new System.Drawing.Point(117, 68);
            this.tbEnName.Margin = new System.Windows.Forms.Padding(2);
            this.tbEnName.Name = "tbEnName";
            this.tbEnName.Size = new System.Drawing.Size(240, 29);
            this.tbEnName.TabIndex = 3;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(117, 121);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(81, 29);
            this.tbPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "价格";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cbUnit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbCategory);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbEnName);
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCnName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(384, 304);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbNoDiscount);
            this.groupBox3.Controls.Add(this.rbCanDiscount);
            this.groupBox3.Location = new System.Drawing.Point(31, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 64);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "能否打折";
            // 
            // rbNoDiscount
            // 
            this.rbNoDiscount.AutoSize = true;
            this.rbNoDiscount.Checked = true;
            this.rbNoDiscount.Location = new System.Drawing.Point(164, 28);
            this.rbNoDiscount.Name = "rbNoDiscount";
            this.rbNoDiscount.Size = new System.Drawing.Size(60, 25);
            this.rbNoDiscount.TabIndex = 1;
            this.rbNoDiscount.TabStop = true;
            this.rbNoDiscount.Text = "不能";
            this.rbNoDiscount.UseVisualStyleBackColor = true;
            // 
            // rbCanDiscount
            // 
            this.rbCanDiscount.AutoSize = true;
            this.rbCanDiscount.Location = new System.Drawing.Point(38, 28);
            this.rbCanDiscount.Name = "rbCanDiscount";
            this.rbCanDiscount.Size = new System.Drawing.Size(44, 25);
            this.rbCanDiscount.TabIndex = 0;
            this.rbCanDiscount.Text = "能";
            this.rbCanDiscount.UseVisualStyleBackColor = true;
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(276, 121);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(81, 29);
            this.cbUnit.TabIndex = 9;
            this.cbUnit.Text = "份";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "单位";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(117, 174);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(240, 29);
            this.cbCategory.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "分类";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbUpload);
            this.groupBox2.Controls.Add(this.pbImage);
            this.groupBox2.Location = new System.Drawing.Point(440, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 304);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图片资料";
            // 
            // lbUpload
            // 
            this.lbUpload.BackColor = System.Drawing.Color.Black;
            this.lbUpload.ForeColor = System.Drawing.Color.White;
            this.lbUpload.Location = new System.Drawing.Point(81, 253);
            this.lbUpload.Name = "lbUpload";
            this.lbUpload.Size = new System.Drawing.Size(78, 33);
            this.lbUpload.TabIndex = 1;
            this.lbUpload.Text = "上传";
            this.lbUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbUpload.Click += new System.EventHandler(this.lbUpload_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.Location = new System.Drawing.Point(6, 28);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(260, 206);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // tcMoreInfo
            // 
            this.tcMoreInfo.Controls.Add(this.tabPage1);
            this.tcMoreInfo.Controls.Add(this.tabPage2);
            this.tcMoreInfo.Controls.Add(this.tabPage3);
            this.tcMoreInfo.Controls.Add(this.tabPage4);
            this.tcMoreInfo.Location = new System.Drawing.Point(13, 330);
            this.tcMoreInfo.Name = "tcMoreInfo";
            this.tcMoreInfo.SelectedIndex = 0;
            this.tcMoreInfo.Size = new System.Drawing.Size(727, 197);
            this.tcMoreInfo.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbAddPlan);
            this.tabPage1.Controls.Add(this.dvPlanInfo);
            this.tabPage1.Controls.Add(this.cbIsPlan);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(719, 163);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "套餐信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbAddPlan
            // 
            this.lbAddPlan.BackColor = System.Drawing.Color.Black;
            this.lbAddPlan.ForeColor = System.Drawing.Color.White;
            this.lbAddPlan.Location = new System.Drawing.Point(19, 91);
            this.lbAddPlan.Name = "lbAddPlan";
            this.lbAddPlan.Size = new System.Drawing.Size(116, 33);
            this.lbAddPlan.TabIndex = 2;
            this.lbAddPlan.Text = "增加套餐信息";
            this.lbAddPlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAddPlan.Click += new System.EventHandler(this.lbAddPlan_Click);
            // 
            // dvPlanInfo
            // 
            this.dvPlanInfo.AllowUserToAddRows = false;
            this.dvPlanInfo.AllowUserToDeleteRows = false;
            this.dvPlanInfo.AllowUserToResizeRows = false;
            this.dvPlanInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvPlanInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvPlanInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.gvfoodid,
            this.name,
            this.foodcount,
            this.foodprice,
            this.foodunit});
            this.dvPlanInfo.ContextMenuStrip = this.ops;
            this.dvPlanInfo.Location = new System.Drawing.Point(169, 6);
            this.dvPlanInfo.Name = "dvPlanInfo";
            this.dvPlanInfo.ReadOnly = true;
            this.dvPlanInfo.RowHeadersVisible = false;
            this.dvPlanInfo.RowTemplate.Height = 23;
            this.dvPlanInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvPlanInfo.Size = new System.Drawing.Size(547, 150);
            this.dvPlanInfo.TabIndex = 1;
            // 
            // ops
            // 
            this.ops.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ops.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.ops.Name = "ops";
            this.ops.Size = new System.Drawing.Size(113, 30);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // cbIsPlan
            // 
            this.cbIsPlan.AutoSize = true;
            this.cbIsPlan.Location = new System.Drawing.Point(38, 37);
            this.cbIsPlan.Name = "cbIsPlan";
            this.cbIsPlan.Size = new System.Drawing.Size(61, 25);
            this.cbIsPlan.TabIndex = 0;
            this.cbIsPlan.Text = "套餐";
            this.cbIsPlan.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.nuKcCount);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbKC);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(719, 163);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "库存信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "个";
            // 
            // nuKcCount
            // 
            this.nuKcCount.Location = new System.Drawing.Point(221, 92);
            this.nuKcCount.Name = "nuKcCount";
            this.nuKcCount.Size = new System.Drawing.Size(72, 29);
            this.nuKcCount.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "库存消耗量";
            // 
            // cbKC
            // 
            this.cbKC.AutoSize = true;
            this.cbKC.Location = new System.Drawing.Point(61, 37);
            this.cbKC.Name = "cbKC";
            this.cbKC.Size = new System.Drawing.Size(93, 25);
            this.cbKC.TabIndex = 0;
            this.cbKC.Text = "开启库存";
            this.cbKC.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dvMaterials);
            this.tabPage3.Controls.Add(this.lbAddMaterials);
            this.tabPage3.Controls.Add(this.cbMaterials);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(719, 163);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "原材料库存";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dvMaterials
            // 
            this.dvMaterials.AllowUserToAddRows = false;
            this.dvMaterials.AllowUserToDeleteRows = false;
            this.dvMaterials.AllowUserToResizeRows = false;
            this.dvMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dvMaterials.Location = new System.Drawing.Point(204, 10);
            this.dvMaterials.Name = "dvMaterials";
            this.dvMaterials.ReadOnly = true;
            this.dvMaterials.RowHeadersVisible = false;
            this.dvMaterials.RowTemplate.Height = 23;
            this.dvMaterials.Size = new System.Drawing.Size(512, 150);
            this.dvMaterials.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "名称";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "消耗量";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lbAddMaterials
            // 
            this.lbAddMaterials.BackColor = System.Drawing.Color.Black;
            this.lbAddMaterials.ForeColor = System.Drawing.Color.White;
            this.lbAddMaterials.Location = new System.Drawing.Point(39, 95);
            this.lbAddMaterials.Name = "lbAddMaterials";
            this.lbAddMaterials.Size = new System.Drawing.Size(133, 33);
            this.lbAddMaterials.TabIndex = 3;
            this.lbAddMaterials.Text = "增加原材料信息";
            this.lbAddMaterials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMaterials
            // 
            this.cbMaterials.AutoSize = true;
            this.cbMaterials.Location = new System.Drawing.Point(43, 35);
            this.cbMaterials.Name = "cbMaterials";
            this.cbMaterials.Size = new System.Drawing.Size(109, 25);
            this.cbMaterials.TabIndex = 0;
            this.cbMaterials.Text = "开启原材料";
            this.cbMaterials.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.tbDes);
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(719, 163);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "描述";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "餐点描述";
            // 
            // tbDes
            // 
            this.tbDes.Location = new System.Drawing.Point(41, 42);
            this.tbDes.Multiline = true;
            this.tbDes.Name = "tbDes";
            this.tbDes.Size = new System.Drawing.Size(654, 97);
            this.tbDes.TabIndex = 0;
            // 
            // lbUpdate
            // 
            this.lbUpdate.BackColor = System.Drawing.Color.Black;
            this.lbUpdate.ForeColor = System.Drawing.Color.White;
            this.lbUpdate.Location = new System.Drawing.Point(199, 549);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(110, 46);
            this.lbUpdate.TabIndex = 9;
            this.lbUpdate.Text = "修改";
            this.lbUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbUpdate.Click += new System.EventHandler(this.lbUpdate_Click);
            // 
            // lbCancel
            // 
            this.lbCancel.BackColor = System.Drawing.Color.Black;
            this.lbCancel.ForeColor = System.Drawing.Color.White;
            this.lbCancel.Location = new System.Drawing.Point(393, 549);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(110, 46);
            this.lbCancel.TabIndex = 10;
            this.lbCancel.Text = "取消";
            this.lbCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // gvfoodid
            // 
            this.gvfoodid.HeaderText = "编号";
            this.gvfoodid.Name = "gvfoodid";
            this.gvfoodid.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // foodcount
            // 
            this.foodcount.HeaderText = "数量";
            this.foodcount.Name = "foodcount";
            this.foodcount.ReadOnly = true;
            // 
            // foodprice
            // 
            this.foodprice.HeaderText = "单价";
            this.foodprice.Name = "foodprice";
            this.foodprice.ReadOnly = true;
            // 
            // foodunit
            // 
            this.foodunit.HeaderText = "单位";
            this.foodunit.Name = "foodunit";
            this.foodunit.ReadOnly = true;
            // 
            // FormUpdateFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 604);
            this.ControlBox = false;
            this.Controls.Add(this.lbCancel);
            this.Controls.Add(this.lbUpdate);
            this.Controls.Add(this.tcMoreInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormUpdateFood";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改餐品";
            this.Load += new System.EventHandler(this.FormUpdateFood_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tcMoreInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvPlanInfo)).EndInit();
            this.ops.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuKcCount)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMaterials)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCnName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEnName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbUpload;
        private System.Windows.Forms.TabControl tcMoreInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbIsPlan;
        private System.Windows.Forms.DataGridView dvPlanInfo;
        private System.Windows.Forms.Label lbAddPlan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbCanDiscount;
        private System.Windows.Forms.RadioButton rbNoDiscount;
        private System.Windows.Forms.CheckBox cbKC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nuKcCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox cbMaterials;
        private System.Windows.Forms.Label lbAddMaterials;
        private System.Windows.Forms.DataGridView dvMaterials;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lbUpdate;
        private System.Windows.Forms.Label lbCancel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbDes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip ops;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvfoodid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodunit;
    }
}