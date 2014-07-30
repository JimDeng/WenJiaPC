namespace yoogacatering
{
    partial class FormAddFood
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
            this.lbCnName = new System.Windows.Forms.Label();
            this.tbCnName = new System.Windows.Forms.TextBox();
            this.lbEnName = new System.Windows.Forms.Label();
            this.tbEnName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.gbDiscount = new System.Windows.Forms.GroupBox();
            this.rbNoDiscount = new System.Windows.Forms.RadioButton();
            this.rbCanDiscount = new System.Windows.Forms.RadioButton();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.lbUnit = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.lbUpload = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tcMoreInfo = new System.Windows.Forms.TabControl();
            this.pagePlanFood = new System.Windows.Forms.TabPage();
            this.lbAddPlan = new System.Windows.Forms.Label();
            this.dvPlanInfo = new System.Windows.Forms.DataGridView();
            this.planOps = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbIsPlan = new System.Windows.Forms.CheckBox();
            this.pageKC = new System.Windows.Forms.TabPage();
            this.lbGe = new System.Windows.Forms.Label();
            this.nuKcCount = new System.Windows.Forms.NumericUpDown();
            this.lbKcCost = new System.Windows.Forms.Label();
            this.cbKC = new System.Windows.Forms.CheckBox();
            this.pageMeterias = new System.Windows.Forms.TabPage();
            this.dvMaterials = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbAddMaterials = new System.Windows.Forms.Label();
            this.cbMaterials = new System.Windows.Forms.CheckBox();
            this.pageDes = new System.Windows.Forms.TabPage();
            this.lbDes = new System.Windows.Forms.Label();
            this.tbDes = new System.Windows.Forms.TextBox();
            this.lbAdd = new System.Windows.Forms.Label();
            this.lbCancel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInfo.SuspendLayout();
            this.gbDiscount.SuspendLayout();
            this.gbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tcMoreInfo.SuspendLayout();
            this.pagePlanFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvPlanInfo)).BeginInit();
            this.planOps.SuspendLayout();
            this.pageKC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuKcCount)).BeginInit();
            this.pageMeterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMaterials)).BeginInit();
            this.pageDes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCnName
            // 
            this.lbCnName.AutoSize = true;
            this.lbCnName.Location = new System.Drawing.Point(27, 26);
            this.lbCnName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCnName.Name = "lbCnName";
            this.lbCnName.Size = new System.Drawing.Size(42, 21);
            this.lbCnName.TabIndex = 0;
            this.lbCnName.Text = "名称";
            // 
            // tbCnName
            // 
            this.tbCnName.Location = new System.Drawing.Point(117, 23);
            this.tbCnName.Margin = new System.Windows.Forms.Padding(2);
            this.tbCnName.Name = "tbCnName";
            this.tbCnName.Size = new System.Drawing.Size(240, 29);
            this.tbCnName.TabIndex = 1;
            this.tbCnName.TextChanged += new System.EventHandler(this.tbCnName_TextChanged);
            // 
            // lbEnName
            // 
            this.lbEnName.AutoSize = true;
            this.lbEnName.Location = new System.Drawing.Point(27, 76);
            this.lbEnName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEnName.Name = "lbEnName";
            this.lbEnName.Size = new System.Drawing.Size(42, 21);
            this.lbEnName.TabIndex = 2;
            this.lbEnName.Text = "缩写";
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
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(27, 124);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(42, 21);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "价格";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.gbDiscount);
            this.gbInfo.Controls.Add(this.cbUnit);
            this.gbInfo.Controls.Add(this.lbUnit);
            this.gbInfo.Controls.Add(this.cbCategory);
            this.gbInfo.Controls.Add(this.lbCategory);
            this.gbInfo.Controls.Add(this.tbEnName);
            this.gbInfo.Controls.Add(this.tbPrice);
            this.gbInfo.Controls.Add(this.lbCnName);
            this.gbInfo.Controls.Add(this.lbPrice);
            this.gbInfo.Controls.Add(this.tbCnName);
            this.gbInfo.Controls.Add(this.lbEnName);
            this.gbInfo.Location = new System.Drawing.Point(27, 9);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbInfo.Size = new System.Drawing.Size(384, 304);
            this.gbInfo.TabIndex = 6;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "基本信息";
            // 
            // gbDiscount
            // 
            this.gbDiscount.Controls.Add(this.rbNoDiscount);
            this.gbDiscount.Controls.Add(this.rbCanDiscount);
            this.gbDiscount.Location = new System.Drawing.Point(31, 222);
            this.gbDiscount.Name = "gbDiscount";
            this.gbDiscount.Size = new System.Drawing.Size(326, 64);
            this.gbDiscount.TabIndex = 10;
            this.gbDiscount.TabStop = false;
            this.gbDiscount.Text = "能否打折";
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
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Location = new System.Drawing.Point(208, 124);
            this.lbUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(42, 21);
            this.lbUnit.TabIndex = 8;
            this.lbUnit.Text = "单位";
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
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(27, 182);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(42, 21);
            this.lbCategory.TabIndex = 6;
            this.lbCategory.Text = "分类";
            // 
            // gbImage
            // 
            this.gbImage.Controls.Add(this.lbUpload);
            this.gbImage.Controls.Add(this.pbImage);
            this.gbImage.Location = new System.Drawing.Point(440, 9);
            this.gbImage.Name = "gbImage";
            this.gbImage.Size = new System.Drawing.Size(272, 304);
            this.gbImage.TabIndex = 7;
            this.gbImage.TabStop = false;
            this.gbImage.Text = "图片资料";
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
            this.tcMoreInfo.Controls.Add(this.pagePlanFood);
            this.tcMoreInfo.Controls.Add(this.pageKC);
            this.tcMoreInfo.Controls.Add(this.pageMeterias);
            this.tcMoreInfo.Controls.Add(this.pageDes);
            this.tcMoreInfo.Location = new System.Drawing.Point(13, 330);
            this.tcMoreInfo.Name = "tcMoreInfo";
            this.tcMoreInfo.SelectedIndex = 0;
            this.tcMoreInfo.Size = new System.Drawing.Size(727, 197);
            this.tcMoreInfo.TabIndex = 8;
            // 
            // pagePlanFood
            // 
            this.pagePlanFood.Controls.Add(this.lbAddPlan);
            this.pagePlanFood.Controls.Add(this.dvPlanInfo);
            this.pagePlanFood.Controls.Add(this.cbIsPlan);
            this.pagePlanFood.Location = new System.Drawing.Point(4, 30);
            this.pagePlanFood.Name = "pagePlanFood";
            this.pagePlanFood.Padding = new System.Windows.Forms.Padding(3);
            this.pagePlanFood.Size = new System.Drawing.Size(719, 163);
            this.pagePlanFood.TabIndex = 0;
            this.pagePlanFood.Text = "套餐信息";
            this.pagePlanFood.UseVisualStyleBackColor = true;
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
            this.lbAddPlan.Visible = false;
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
            this.foodid,
            this.name,
            this.foodcount,
            this.foodprice,
            this.foodUnit});
            this.dvPlanInfo.ContextMenuStrip = this.planOps;
            this.dvPlanInfo.Location = new System.Drawing.Point(169, 6);
            this.dvPlanInfo.Name = "dvPlanInfo";
            this.dvPlanInfo.ReadOnly = true;
            this.dvPlanInfo.RowHeadersVisible = false;
            this.dvPlanInfo.RowTemplate.Height = 23;
            this.dvPlanInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvPlanInfo.Size = new System.Drawing.Size(547, 150);
            this.dvPlanInfo.TabIndex = 1;
            // 
            // planOps
            // 
            this.planOps.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.planOps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.planOps.Name = "planOps";
            this.planOps.Size = new System.Drawing.Size(113, 30);
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
            this.cbIsPlan.CheckedChanged += new System.EventHandler(this.cbIsPlan_CheckedChanged);
            // 
            // pageKC
            // 
            this.pageKC.Controls.Add(this.lbGe);
            this.pageKC.Controls.Add(this.nuKcCount);
            this.pageKC.Controls.Add(this.lbKcCost);
            this.pageKC.Controls.Add(this.cbKC);
            this.pageKC.Location = new System.Drawing.Point(4, 30);
            this.pageKC.Name = "pageKC";
            this.pageKC.Padding = new System.Windows.Forms.Padding(3);
            this.pageKC.Size = new System.Drawing.Size(719, 163);
            this.pageKC.TabIndex = 1;
            this.pageKC.Text = "库存信息";
            this.pageKC.UseVisualStyleBackColor = true;
            // 
            // lbGe
            // 
            this.lbGe.AutoSize = true;
            this.lbGe.Location = new System.Drawing.Point(313, 100);
            this.lbGe.Name = "lbGe";
            this.lbGe.Size = new System.Drawing.Size(26, 21);
            this.lbGe.TabIndex = 3;
            this.lbGe.Text = "个";
            // 
            // nuKcCount
            // 
            this.nuKcCount.Enabled = false;
            this.nuKcCount.Location = new System.Drawing.Point(221, 92);
            this.nuKcCount.Name = "nuKcCount";
            this.nuKcCount.Size = new System.Drawing.Size(72, 29);
            this.nuKcCount.TabIndex = 2;
            // 
            // lbKcCost
            // 
            this.lbKcCost.AutoSize = true;
            this.lbKcCost.Location = new System.Drawing.Point(64, 100);
            this.lbKcCost.Name = "lbKcCost";
            this.lbKcCost.Size = new System.Drawing.Size(90, 21);
            this.lbKcCost.TabIndex = 1;
            this.lbKcCost.Text = "库存消耗量";
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
            this.cbKC.CheckedChanged += new System.EventHandler(this.cbKC_CheckedChanged);
            // 
            // pageMeterias
            // 
            this.pageMeterias.Controls.Add(this.dvMaterials);
            this.pageMeterias.Controls.Add(this.lbAddMaterials);
            this.pageMeterias.Controls.Add(this.cbMaterials);
            this.pageMeterias.Location = new System.Drawing.Point(4, 30);
            this.pageMeterias.Name = "pageMeterias";
            this.pageMeterias.Size = new System.Drawing.Size(719, 163);
            this.pageMeterias.TabIndex = 2;
            this.pageMeterias.Text = "原材料库存";
            this.pageMeterias.UseVisualStyleBackColor = true;
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
            this.lbAddMaterials.Visible = false;
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
            this.cbMaterials.CheckedChanged += new System.EventHandler(this.cbMaterials_CheckedChanged);
            // 
            // pageDes
            // 
            this.pageDes.Controls.Add(this.lbDes);
            this.pageDes.Controls.Add(this.tbDes);
            this.pageDes.Location = new System.Drawing.Point(4, 30);
            this.pageDes.Name = "pageDes";
            this.pageDes.Size = new System.Drawing.Size(719, 163);
            this.pageDes.TabIndex = 3;
            this.pageDes.Text = "描述";
            this.pageDes.UseVisualStyleBackColor = true;
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.Location = new System.Drawing.Point(48, 18);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(74, 21);
            this.lbDes.TabIndex = 1;
            this.lbDes.Text = "餐点描述";
            // 
            // tbDes
            // 
            this.tbDes.Location = new System.Drawing.Point(41, 42);
            this.tbDes.Multiline = true;
            this.tbDes.Name = "tbDes";
            this.tbDes.Size = new System.Drawing.Size(654, 97);
            this.tbDes.TabIndex = 0;
            // 
            // lbAdd
            // 
            this.lbAdd.BackColor = System.Drawing.Color.Black;
            this.lbAdd.ForeColor = System.Drawing.Color.White;
            this.lbAdd.Location = new System.Drawing.Point(199, 549);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(110, 46);
            this.lbAdd.TabIndex = 9;
            this.lbAdd.Text = "增加";
            this.lbAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAdd.Click += new System.EventHandler(this.lbAdd_Click);
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
            // foodid
            // 
            this.foodid.HeaderText = "编号";
            this.foodid.Name = "foodid";
            this.foodid.ReadOnly = true;
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
            // foodUnit
            // 
            this.foodUnit.HeaderText = "单位";
            this.foodUnit.Name = "foodUnit";
            this.foodUnit.ReadOnly = true;
            // 
            // FormAddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 604);
            this.ControlBox = false;
            this.Controls.Add(this.lbCancel);
            this.Controls.Add(this.lbAdd);
            this.Controls.Add(this.tcMoreInfo);
            this.Controls.Add(this.gbImage);
            this.Controls.Add(this.gbInfo);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormAddFood";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增餐品";
            this.Load += new System.EventHandler(this.FormAddFood_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbDiscount.ResumeLayout(false);
            this.gbDiscount.PerformLayout();
            this.gbImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tcMoreInfo.ResumeLayout(false);
            this.pagePlanFood.ResumeLayout(false);
            this.pagePlanFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvPlanInfo)).EndInit();
            this.planOps.ResumeLayout(false);
            this.pageKC.ResumeLayout(false);
            this.pageKC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuKcCount)).EndInit();
            this.pageMeterias.ResumeLayout(false);
            this.pageMeterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMaterials)).EndInit();
            this.pageDes.ResumeLayout(false);
            this.pageDes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCnName;
        private System.Windows.Forms.TextBox tbCnName;
        private System.Windows.Forms.Label lbEnName;
        private System.Windows.Forms.TextBox tbEnName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label lbUnit;
        private System.Windows.Forms.GroupBox gbImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbUpload;
        private System.Windows.Forms.TabControl tcMoreInfo;
        private System.Windows.Forms.TabPage pagePlanFood;
        private System.Windows.Forms.TabPage pageKC;
        private System.Windows.Forms.CheckBox cbIsPlan;
        private System.Windows.Forms.DataGridView dvPlanInfo;
        private System.Windows.Forms.Label lbAddPlan;
        private System.Windows.Forms.GroupBox gbDiscount;
        private System.Windows.Forms.RadioButton rbCanDiscount;
        private System.Windows.Forms.RadioButton rbNoDiscount;
        private System.Windows.Forms.CheckBox cbKC;
        private System.Windows.Forms.Label lbKcCost;
        private System.Windows.Forms.NumericUpDown nuKcCount;
        private System.Windows.Forms.Label lbGe;
        private System.Windows.Forms.TabPage pageMeterias;
        private System.Windows.Forms.CheckBox cbMaterials;
        private System.Windows.Forms.Label lbAddMaterials;
        private System.Windows.Forms.DataGridView dvMaterials;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lbAdd;
        private System.Windows.Forms.Label lbCancel;
        private System.Windows.Forms.TabPage pageDes;
        private System.Windows.Forms.TextBox tbDes;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.ContextMenuStrip planOps;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodUnit;
    }
}