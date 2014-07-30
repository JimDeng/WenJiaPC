namespace yoogacatering
{
    partial class FormOrder
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
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.layoutInfo = new System.Windows.Forms.TableLayoutPanel();
            this.dvBill = new System.Windows.Forms.DataGridView();
            this.layoutOps = new System.Windows.Forms.TableLayoutPanel();
            this.lbGive = new System.Windows.Forms.Label();
            this.lbOrder = new System.Windows.Forms.Label();
            this.lbCook = new System.Windows.Forms.Label();
            this.lbBack = new System.Windows.Forms.Label();
            this.lbRetreat = new System.Windows.Forms.Label();
            this.lbAdd = new System.Windows.Forms.Label();
            this.lbJQAll = new System.Windows.Forms.Label();
            this.lbJQOnly = new System.Windows.Forms.Label();
            this.lbDel = new System.Windows.Forms.Label();
            this.lbPlus = new System.Windows.Forms.Label();
            this.lbBillMoney = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTabInfo = new System.Windows.Forms.Label();
            this.tabFoods = new System.Windows.Forms.TabControl();
            this.pageCategory = new System.Windows.Forms.TabPage();
            this.tabCategory = new System.Windows.Forms.TabControl();
            this.pageName = new System.Windows.Forms.TabPage();
            this.layoutName = new System.Windows.Forms.TableLayoutPanel();
            this.pnSear = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnFood = new System.Windows.Forms.Panel();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retreat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.give = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layoutMain.SuspendLayout();
            this.layoutInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBill)).BeginInit();
            this.layoutOps.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabFoods.SuspendLayout();
            this.pageCategory.SuspendLayout();
            this.pageName.SuspendLayout();
            this.layoutName.SuspendLayout();
            this.pnSear.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 2;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.layoutMain.Controls.Add(this.layoutInfo, 0, 0);
            this.layoutMain.Controls.Add(this.tabFoods, 1, 0);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 1;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutMain.Size = new System.Drawing.Size(1058, 560);
            this.layoutMain.TabIndex = 0;
            // 
            // layoutInfo
            // 
            this.layoutInfo.ColumnCount = 1;
            this.layoutInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutInfo.Controls.Add(this.dvBill, 0, 1);
            this.layoutInfo.Controls.Add(this.layoutOps, 0, 2);
            this.layoutInfo.Controls.Add(this.lbBillMoney, 0, 3);
            this.layoutInfo.Controls.Add(this.groupBox1, 0, 0);
            this.layoutInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutInfo.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.layoutInfo.Location = new System.Drawing.Point(3, 3);
            this.layoutInfo.Name = "layoutInfo";
            this.layoutInfo.RowCount = 4;
            this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutInfo.Size = new System.Drawing.Size(417, 554);
            this.layoutInfo.TabIndex = 0;
            // 
            // dvBill
            // 
            this.dvBill.AllowUserToAddRows = false;
            this.dvBill.AllowUserToDeleteRows = false;
            this.dvBill.AllowUserToResizeRows = false;
            this.dvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status,
            this.foodname,
            this.foodcount,
            this.foodprice,
            this.foodunit,
            this.cook,
            this.hold,
            this.retreat,
            this.give,
            this.mark,
            this.id});
            this.dvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvBill.Location = new System.Drawing.Point(3, 58);
            this.dvBill.Name = "dvBill";
            this.dvBill.ReadOnly = true;
            this.dvBill.RowHeadersVisible = false;
            this.dvBill.RowTemplate.Height = 23;
            this.dvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvBill.Size = new System.Drawing.Size(411, 271);
            this.dvBill.TabIndex = 1;
            this.dvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvBill_CellClick);
            // 
            // layoutOps
            // 
            this.layoutOps.ColumnCount = 5;
            this.layoutOps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutOps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutOps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutOps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutOps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutOps.Controls.Add(this.lbGive, 0, 1);
            this.layoutOps.Controls.Add(this.lbOrder, 0, 1);
            this.layoutOps.Controls.Add(this.lbCook, 4, 0);
            this.layoutOps.Controls.Add(this.lbBack, 2, 1);
            this.layoutOps.Controls.Add(this.lbRetreat, 1, 1);
            this.layoutOps.Controls.Add(this.lbAdd, 0, 0);
            this.layoutOps.Controls.Add(this.lbJQAll, 0, 1);
            this.layoutOps.Controls.Add(this.lbJQOnly, 3, 0);
            this.layoutOps.Controls.Add(this.lbDel, 2, 0);
            this.layoutOps.Controls.Add(this.lbPlus, 1, 0);
            this.layoutOps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutOps.Location = new System.Drawing.Point(3, 335);
            this.layoutOps.Name = "layoutOps";
            this.layoutOps.RowCount = 2;
            this.layoutOps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutOps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutOps.Size = new System.Drawing.Size(411, 160);
            this.layoutOps.TabIndex = 2;
            // 
            // lbGive
            // 
            this.lbGive.BackColor = System.Drawing.Color.Black;
            this.lbGive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGive.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbGive.ForeColor = System.Drawing.Color.White;
            this.lbGive.Location = new System.Drawing.Point(167, 85);
            this.lbGive.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lbGive.Name = "lbGive";
            this.lbGive.Size = new System.Drawing.Size(76, 70);
            this.lbGive.TabIndex = 10;
            this.lbGive.Text = "赠送";
            this.lbGive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbGive.Click += new System.EventHandler(this.lbGive_Click);
            // 
            // lbOrder
            // 
            this.lbOrder.BackColor = System.Drawing.Color.Black;
            this.lbOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOrder.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbOrder.ForeColor = System.Drawing.Color.White;
            this.lbOrder.Location = new System.Drawing.Point(85, 85);
            this.lbOrder.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(76, 70);
            this.lbOrder.TabIndex = 9;
            this.lbOrder.Text = "下单";
            this.lbOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbOrder.Click += new System.EventHandler(this.lbOrder_Click);
            // 
            // lbCook
            // 
            this.lbCook.BackColor = System.Drawing.Color.Black;
            this.lbCook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCook.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbCook.ForeColor = System.Drawing.Color.White;
            this.lbCook.Location = new System.Drawing.Point(331, 5);
            this.lbCook.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lbCook.Name = "lbCook";
            this.lbCook.Size = new System.Drawing.Size(77, 70);
            this.lbCook.TabIndex = 8;
            this.lbCook.Text = "做法";
            this.lbCook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBack
            // 
            this.lbBack.BackColor = System.Drawing.Color.Black;
            this.lbBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBack.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbBack.ForeColor = System.Drawing.Color.White;
            this.lbBack.Location = new System.Drawing.Point(331, 85);
            this.lbBack.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(77, 70);
            this.lbBack.TabIndex = 7;
            this.lbBack.Text = "返回";
            this.lbBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbBack.Click += new System.EventHandler(this.lbBack_Click);
            // 
            // lbRetreat
            // 
            this.lbRetreat.BackColor = System.Drawing.Color.Black;
            this.lbRetreat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRetreat.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbRetreat.ForeColor = System.Drawing.Color.White;
            this.lbRetreat.Location = new System.Drawing.Point(249, 85);
            this.lbRetreat.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lbRetreat.Name = "lbRetreat";
            this.lbRetreat.Size = new System.Drawing.Size(76, 70);
            this.lbRetreat.TabIndex = 6;
            this.lbRetreat.Text = "退菜";
            this.lbRetreat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbRetreat.Click += new System.EventHandler(this.lbRetreat_Click);
            // 
            // lbAdd
            // 
            this.lbAdd.BackColor = System.Drawing.Color.Black;
            this.lbAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAdd.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.lbAdd.ForeColor = System.Drawing.Color.White;
            this.lbAdd.Location = new System.Drawing.Point(3, 5);
            this.lbAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(76, 70);
            this.lbAdd.TabIndex = 5;
            this.lbAdd.Text = "+";
            this.lbAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAdd.Click += new System.EventHandler(this.lbAdd_Click);
            // 
            // lbJQAll
            // 
            this.lbJQAll.BackColor = System.Drawing.Color.Black;
            this.lbJQAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbJQAll.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbJQAll.ForeColor = System.Drawing.Color.White;
            this.lbJQAll.Location = new System.Drawing.Point(3, 85);
            this.lbJQAll.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lbJQAll.Name = "lbJQAll";
            this.lbJQAll.Size = new System.Drawing.Size(76, 70);
            this.lbJQAll.TabIndex = 4;
            this.lbJQAll.Text = "叫起";
            this.lbJQAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbJQOnly
            // 
            this.lbJQOnly.AutoSize = true;
            this.lbJQOnly.BackColor = System.Drawing.Color.Black;
            this.lbJQOnly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbJQOnly.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbJQOnly.ForeColor = System.Drawing.Color.White;
            this.lbJQOnly.Location = new System.Drawing.Point(249, 5);
            this.lbJQOnly.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lbJQOnly.Name = "lbJQOnly";
            this.lbJQOnly.Size = new System.Drawing.Size(76, 70);
            this.lbJQOnly.TabIndex = 3;
            this.lbJQOnly.Text = "单品叫起";
            this.lbJQOnly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbJQOnly.Click += new System.EventHandler(this.lbJQOnly_Click);
            // 
            // lbDel
            // 
            this.lbDel.AutoSize = true;
            this.lbDel.BackColor = System.Drawing.Color.Black;
            this.lbDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDel.ForeColor = System.Drawing.Color.White;
            this.lbDel.Location = new System.Drawing.Point(167, 5);
            this.lbDel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lbDel.Name = "lbDel";
            this.lbDel.Size = new System.Drawing.Size(76, 70);
            this.lbDel.TabIndex = 2;
            this.lbDel.Text = "删除";
            this.lbDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDel.Click += new System.EventHandler(this.lbDel_Click);
            // 
            // lbPlus
            // 
            this.lbPlus.AutoSize = true;
            this.lbPlus.BackColor = System.Drawing.Color.Black;
            this.lbPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPlus.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.lbPlus.ForeColor = System.Drawing.Color.White;
            this.lbPlus.Location = new System.Drawing.Point(85, 5);
            this.lbPlus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lbPlus.Name = "lbPlus";
            this.lbPlus.Size = new System.Drawing.Size(76, 70);
            this.lbPlus.TabIndex = 1;
            this.lbPlus.Text = "-";
            this.lbPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPlus.Click += new System.EventHandler(this.lbPlus_Click);
            // 
            // lbBillMoney
            // 
            this.lbBillMoney.AutoSize = true;
            this.lbBillMoney.BackColor = System.Drawing.Color.Black;
            this.lbBillMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBillMoney.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbBillMoney.ForeColor = System.Drawing.Color.White;
            this.lbBillMoney.Location = new System.Drawing.Point(3, 498);
            this.lbBillMoney.Name = "lbBillMoney";
            this.lbBillMoney.Size = new System.Drawing.Size(411, 56);
            this.lbBillMoney.TabIndex = 3;
            this.lbBillMoney.Text = "消费：￥115.00元";
            this.lbBillMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTabInfo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 49);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lbTabInfo
            // 
            this.lbTabInfo.AutoSize = true;
            this.lbTabInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTabInfo.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lbTabInfo.Location = new System.Drawing.Point(3, 25);
            this.lbTabInfo.Name = "lbTabInfo";
            this.lbTabInfo.Size = new System.Drawing.Size(116, 27);
            this.lbTabInfo.TabIndex = 0;
            this.lbTabInfo.Text = "餐桌号--A1";
            // 
            // tabFoods
            // 
            this.tabFoods.Controls.Add(this.pageCategory);
            this.tabFoods.Controls.Add(this.pageName);
            this.tabFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFoods.Location = new System.Drawing.Point(426, 3);
            this.tabFoods.Name = "tabFoods";
            this.tabFoods.SelectedIndex = 0;
            this.tabFoods.Size = new System.Drawing.Size(629, 554);
            this.tabFoods.TabIndex = 1;
            this.tabFoods.SelectedIndexChanged += new System.EventHandler(this.tabFoods_SelectedIndexChanged);
            // 
            // pageCategory
            // 
            this.pageCategory.Controls.Add(this.tabCategory);
            this.pageCategory.Location = new System.Drawing.Point(4, 30);
            this.pageCategory.Name = "pageCategory";
            this.pageCategory.Padding = new System.Windows.Forms.Padding(3);
            this.pageCategory.Size = new System.Drawing.Size(621, 520);
            this.pageCategory.TabIndex = 0;
            this.pageCategory.Text = "按分类点餐";
            this.pageCategory.UseVisualStyleBackColor = true;
            // 
            // tabCategory
            // 
            this.tabCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCategory.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tabCategory.Location = new System.Drawing.Point(3, 3);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.SelectedIndex = 0;
            this.tabCategory.Size = new System.Drawing.Size(615, 514);
            this.tabCategory.TabIndex = 0;
            // 
            // pageName
            // 
            this.pageName.Controls.Add(this.layoutName);
            this.pageName.Location = new System.Drawing.Point(4, 30);
            this.pageName.Name = "pageName";
            this.pageName.Padding = new System.Windows.Forms.Padding(3);
            this.pageName.Size = new System.Drawing.Size(621, 520);
            this.pageName.TabIndex = 1;
            this.pageName.Text = "按名称点餐";
            this.pageName.UseVisualStyleBackColor = true;
            // 
            // layoutName
            // 
            this.layoutName.ColumnCount = 1;
            this.layoutName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutName.Controls.Add(this.pnSear, 0, 0);
            this.layoutName.Controls.Add(this.pnFood, 0, 1);
            this.layoutName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutName.Location = new System.Drawing.Point(3, 3);
            this.layoutName.Name = "layoutName";
            this.layoutName.RowCount = 2;
            this.layoutName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.layoutName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.layoutName.Size = new System.Drawing.Size(615, 514);
            this.layoutName.TabIndex = 0;
            // 
            // pnSear
            // 
            this.pnSear.Controls.Add(this.tbSearch);
            this.pnSear.Controls.Add(this.label1);
            this.pnSear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSear.Location = new System.Drawing.Point(3, 3);
            this.pnSear.Name = "pnSear";
            this.pnSear.Size = new System.Drawing.Size(609, 35);
            this.pnSear.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tbSearch.Location = new System.Drawing.Point(374, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(232, 29);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(278, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称或缩写";
            // 
            // pnFood
            // 
            this.pnFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFood.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pnFood.Location = new System.Drawing.Point(3, 44);
            this.pnFood.Name = "pnFood";
            this.pnFood.Size = new System.Drawing.Size(609, 467);
            this.pnFood.TabIndex = 1;
            // 
            // status
            // 
            this.status.FillWeight = 3F;
            this.status.HeaderText = "状态";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 60;
            // 
            // foodname
            // 
            this.foodname.FillWeight = 4F;
            this.foodname.HeaderText = "餐点名称";
            this.foodname.Name = "foodname";
            this.foodname.ReadOnly = true;
            this.foodname.Width = 84;
            // 
            // foodcount
            // 
            this.foodcount.FillWeight = 1F;
            this.foodcount.HeaderText = "数量";
            this.foodcount.Name = "foodcount";
            this.foodcount.ReadOnly = true;
            this.foodcount.Width = 62;
            // 
            // foodprice
            // 
            this.foodprice.FillWeight = 1F;
            this.foodprice.HeaderText = "单价";
            this.foodprice.Name = "foodprice";
            this.foodprice.ReadOnly = true;
            this.foodprice.Width = 42;
            // 
            // foodunit
            // 
            this.foodunit.FillWeight = 1F;
            this.foodunit.HeaderText = "单位";
            this.foodunit.Name = "foodunit";
            this.foodunit.ReadOnly = true;
            this.foodunit.Width = 42;
            // 
            // cook
            // 
            this.cook.FillWeight = 3F;
            this.cook.HeaderText = "做法";
            this.cook.Name = "cook";
            this.cook.ReadOnly = true;
            this.cook.Width = 84;
            // 
            // hold
            // 
            this.hold.FillWeight = 1F;
            this.hold.HeaderText = "叫起";
            this.hold.Name = "hold";
            this.hold.ReadOnly = true;
            this.hold.Width = 40;
            // 
            // retreat
            // 
            this.retreat.FillWeight = 1F;
            this.retreat.HeaderText = "退菜";
            this.retreat.Name = "retreat";
            this.retreat.ReadOnly = true;
            this.retreat.Width = 40;
            // 
            // give
            // 
            this.give.FillWeight = 1F;
            this.give.HeaderText = "赠送";
            this.give.Name = "give";
            this.give.ReadOnly = true;
            this.give.Width = 42;
            // 
            // mark
            // 
            this.mark.FillWeight = 3F;
            this.mark.HeaderText = "备注";
            this.mark.Name = "mark";
            this.mark.ReadOnly = true;
            this.mark.Width = 200;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 560);
            this.ControlBox = false;
            this.Controls.Add(this.layoutMain);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FormOrder";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.layoutMain.ResumeLayout(false);
            this.layoutInfo.ResumeLayout(false);
            this.layoutInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBill)).EndInit();
            this.layoutOps.ResumeLayout(false);
            this.layoutOps.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabFoods.ResumeLayout(false);
            this.pageCategory.ResumeLayout(false);
            this.pageName.ResumeLayout(false);
            this.layoutName.ResumeLayout(false);
            this.pnSear.ResumeLayout(false);
            this.pnSear.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.TableLayoutPanel layoutInfo;
        private System.Windows.Forms.DataGridView dvBill;
        private System.Windows.Forms.TableLayoutPanel layoutOps;
        private System.Windows.Forms.Label lbPlus;
        private System.Windows.Forms.Label lbDel;
        private System.Windows.Forms.Label lbJQOnly;
        private System.Windows.Forms.Label lbJQAll;
        private System.Windows.Forms.Label lbAdd;
        private System.Windows.Forms.Label lbRetreat;
        private System.Windows.Forms.Label lbBack;
        private System.Windows.Forms.Label lbCook;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.Label lbGive;
        private System.Windows.Forms.Label lbBillMoney;
        private System.Windows.Forms.TabControl tabFoods;
        private System.Windows.Forms.TabPage pageCategory;
        private System.Windows.Forms.TabPage pageName;
        private System.Windows.Forms.TabControl tabCategory;
        private System.Windows.Forms.TableLayoutPanel layoutName;
        private System.Windows.Forms.Panel pnSear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel pnFood;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTabInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodname;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cook;
        private System.Windows.Forms.DataGridViewTextBoxColumn hold;
        private System.Windows.Forms.DataGridViewTextBoxColumn retreat;
        private System.Windows.Forms.DataGridViewTextBoxColumn give;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}