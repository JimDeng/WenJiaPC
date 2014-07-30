namespace 餐饮管理软件
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.消费ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收银ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.消费ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.菜品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.菜品管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.财务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.交班ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日结ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.营业数据表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.营业数据明细表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.库存信息表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.餐桌设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.终端设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageFood = new System.Windows.Forms.TabPage();
            this.layoutFood = new System.Windows.Forms.TableLayoutPanel();
            this.gbFoodCate = new System.Windows.Forms.GroupBox();
            this.tvFoodCate = new System.Windows.Forms.TreeView();
            this.foodOps = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新增分类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除分类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.新增商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutFoodInfo = new System.Windows.Forms.TableLayoutPanel();
            this.dvAllFood = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.species = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageUpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.needKC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.needMaterials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnSearchFood = new System.Windows.Forms.Panel();
            this.tbFoodSearchStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pageConsume = new System.Windows.Forms.TabPage();
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.layoutInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lbCustCount = new System.Windows.Forms.Label();
            this.lbOpenPretage = new System.Windows.Forms.Label();
            this.lbOpenTime = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvFood = new System.Windows.Forms.DataGridView();
            this.foodid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layoutTabs = new System.Windows.Forms.TableLayoutPanel();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.pnOps = new System.Windows.Forms.Panel();
            this.lbReset = new System.Windows.Forms.Label();
            this.lbRefresh = new System.Windows.Forms.Label();
            this.lbChangeTab = new System.Windows.Forms.Label();
            this.lbCheckout = new System.Windows.Forms.Label();
            this.lbOrder = new System.Windows.Forms.Label();
            this.lbUserTab = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.pageOpers = new System.Windows.Forms.TabPage();
            this.layoutOpers = new System.Windows.Forms.TableLayoutPanel();
            this.layoutOpersLeft = new System.Windows.Forms.TableLayoutPanel();
            this.gbSearchOpers = new System.Windows.Forms.GroupBox();
            this.cbOperSex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbOperPos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOperOpenID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOperName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDelOpers = new System.Windows.Forms.Label();
            this.lbUpdateOpers = new System.Windows.Forms.Label();
            this.lbAddOpers = new System.Windows.Forms.Label();
            this.dvOpers = new System.Windows.Forms.DataGridView();
            this.operid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operpwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operloginid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opersex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operpos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opergrangirhts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opernotgranrights = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageReport = new System.Windows.Forms.TabPage();
            this.tabReports = new System.Windows.Forms.TabControl();
            this.pageBill = new System.Windows.Forms.TabPage();
            this.layoutBillReport = new System.Windows.Forms.TableLayoutPanel();
            this.gbBillReportQuery = new System.Windows.Forms.GroupBox();
            this.lbImport = new System.Windows.Forms.Label();
            this.lbQuery = new System.Windows.Forms.Label();
            this.dtcheckend = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtcheckbegin = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPaymethod = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBillkey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnAllBill = new System.Windows.Forms.Panel();
            this.dvAllBill = new System.Windows.Forms.DataGridView();
            this.billkey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billtabName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHmoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHcash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHvesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checktime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageFoodReprt = new System.Windows.Forms.TabPage();
            this.layouFoodCount = new System.Windows.Forms.TableLayoutPanel();
            this.gbFoodCount = new System.Windows.Forms.GroupBox();
            this.lbCount = new System.Windows.Forms.Label();
            this.dtFoodEnd = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtFoodBegin = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dvFoodcount = new System.Windows.Forms.DataGridView();
            this.ops = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.开台ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.点餐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.结账ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.换桌ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billTimer = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            this.pageFood.SuspendLayout();
            this.layoutFood.SuspendLayout();
            this.gbFoodCate.SuspendLayout();
            this.foodOps.SuspendLayout();
            this.layoutFoodInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvAllFood)).BeginInit();
            this.pnSearchFood.SuspendLayout();
            this.pageConsume.SuspendLayout();
            this.layoutMain.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.layoutInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvFood)).BeginInit();
            this.layoutTabs.SuspendLayout();
            this.pnOps.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.pageOpers.SuspendLayout();
            this.layoutOpers.SuspendLayout();
            this.layoutOpersLeft.SuspendLayout();
            this.gbSearchOpers.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvOpers)).BeginInit();
            this.pageReport.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.pageBill.SuspendLayout();
            this.layoutBillReport.SuspendLayout();
            this.gbBillReportQuery.SuspendLayout();
            this.pnAllBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvAllBill)).BeginInit();
            this.pageFoodReprt.SuspendLayout();
            this.layouFoodCount.SuspendLayout();
            this.gbFoodCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvFoodcount)).BeginInit();
            this.ops.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.消费ToolStripMenuItem,
            this.菜品ToolStripMenuItem,
            this.库存ToolStripMenuItem,
            this.财务ToolStripMenuItem,
            this.系统ToolStripMenuItem,
            this.日志ToolStripMenuItem,
            this.操作员ToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1166, 35);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // 消费ToolStripMenuItem
            // 
            this.消费ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.收银ToolStripMenuItem,
            this.消费ToolStripMenuItem1});
            this.消费ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.消费ToolStripMenuItem.Name = "消费ToolStripMenuItem";
            this.消费ToolStripMenuItem.Size = new System.Drawing.Size(64, 31);
            this.消费ToolStripMenuItem.Text = "交易";
            // 
            // 收银ToolStripMenuItem
            // 
            this.收银ToolStripMenuItem.Name = "收银ToolStripMenuItem";
            this.收银ToolStripMenuItem.Size = new System.Drawing.Size(124, 32);
            this.收银ToolStripMenuItem.Text = "收银";
            this.收银ToolStripMenuItem.Visible = false;
            // 
            // 消费ToolStripMenuItem1
            // 
            this.消费ToolStripMenuItem1.Name = "消费ToolStripMenuItem1";
            this.消费ToolStripMenuItem1.Size = new System.Drawing.Size(124, 32);
            this.消费ToolStripMenuItem1.Text = "消费";
            this.消费ToolStripMenuItem1.Click += new System.EventHandler(this.消费ToolStripMenuItem1_Click);
            // 
            // 菜品ToolStripMenuItem
            // 
            this.菜品ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜品管理ToolStripMenuItem});
            this.菜品ToolStripMenuItem.Name = "菜品ToolStripMenuItem";
            this.菜品ToolStripMenuItem.Size = new System.Drawing.Size(64, 31);
            this.菜品ToolStripMenuItem.Text = "货品";
            // 
            // 菜品管理ToolStripMenuItem
            // 
            this.菜品管理ToolStripMenuItem.Name = "菜品管理ToolStripMenuItem";
            this.菜品管理ToolStripMenuItem.Size = new System.Drawing.Size(164, 32);
            this.菜品管理ToolStripMenuItem.Text = "菜品管理";
            this.菜品管理ToolStripMenuItem.Click += new System.EventHandler(this.菜品管理ToolStripMenuItem_Click);
            // 
            // 库存ToolStripMenuItem
            // 
            this.库存ToolStripMenuItem.Name = "库存ToolStripMenuItem";
            this.库存ToolStripMenuItem.Size = new System.Drawing.Size(64, 31);
            this.库存ToolStripMenuItem.Text = "库存";
            this.库存ToolStripMenuItem.Visible = false;
            // 
            // 财务ToolStripMenuItem
            // 
            this.财务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.交班ToolStripMenuItem,
            this.日结ToolStripMenuItem,
            this.报表ToolStripMenuItem});
            this.财务ToolStripMenuItem.Name = "财务ToolStripMenuItem";
            this.财务ToolStripMenuItem.Size = new System.Drawing.Size(64, 31);
            this.财务ToolStripMenuItem.Text = "财务";
            // 
            // 交班ToolStripMenuItem
            // 
            this.交班ToolStripMenuItem.Name = "交班ToolStripMenuItem";
            this.交班ToolStripMenuItem.Size = new System.Drawing.Size(124, 32);
            this.交班ToolStripMenuItem.Text = "交班";
            this.交班ToolStripMenuItem.Click += new System.EventHandler(this.交班ToolStripMenuItem_Click);
            // 
            // 日结ToolStripMenuItem
            // 
            this.日结ToolStripMenuItem.Name = "日结ToolStripMenuItem";
            this.日结ToolStripMenuItem.Size = new System.Drawing.Size(124, 32);
            this.日结ToolStripMenuItem.Text = "日结";
            this.日结ToolStripMenuItem.Click += new System.EventHandler(this.日结ToolStripMenuItem_Click);
            // 
            // 报表ToolStripMenuItem
            // 
            this.报表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.营业数据表ToolStripMenuItem,
            this.营业数据明细表ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.库存信息表ToolStripMenuItem});
            this.报表ToolStripMenuItem.Name = "报表ToolStripMenuItem";
            this.报表ToolStripMenuItem.Size = new System.Drawing.Size(124, 32);
            this.报表ToolStripMenuItem.Text = "报表";
            // 
            // 营业数据表ToolStripMenuItem
            // 
            this.营业数据表ToolStripMenuItem.Name = "营业数据表ToolStripMenuItem";
            this.营业数据表ToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.营业数据表ToolStripMenuItem.Text = "营业数据表";
            // 
            // 营业数据明细表ToolStripMenuItem
            // 
            this.营业数据明细表ToolStripMenuItem.Name = "营业数据明细表ToolStripMenuItem";
            this.营业数据明细表ToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.营业数据明细表ToolStripMenuItem.Text = "营业数据明细表";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 32);
            this.toolStripMenuItem1.Text = "菜品出品统计";
            // 
            // 库存信息表ToolStripMenuItem
            // 
            this.库存信息表ToolStripMenuItem.Name = "库存信息表ToolStripMenuItem";
            this.库存信息表ToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.库存信息表ToolStripMenuItem.Text = "库存信息表";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.餐桌设置ToolStripMenuItem,
            this.终端设置ToolStripMenuItem,
            this.打印设置ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(64, 31);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 餐桌设置ToolStripMenuItem
            // 
            this.餐桌设置ToolStripMenuItem.Name = "餐桌设置ToolStripMenuItem";
            this.餐桌设置ToolStripMenuItem.Size = new System.Drawing.Size(164, 32);
            this.餐桌设置ToolStripMenuItem.Text = "餐桌设置";
            this.餐桌设置ToolStripMenuItem.Click += new System.EventHandler(this.餐桌设置ToolStripMenuItem_Click);
            // 
            // 终端设置ToolStripMenuItem
            // 
            this.终端设置ToolStripMenuItem.Name = "终端设置ToolStripMenuItem";
            this.终端设置ToolStripMenuItem.Size = new System.Drawing.Size(164, 32);
            this.终端设置ToolStripMenuItem.Text = "终端设置";
            // 
            // 打印设置ToolStripMenuItem
            // 
            this.打印设置ToolStripMenuItem.Name = "打印设置ToolStripMenuItem";
            this.打印设置ToolStripMenuItem.Size = new System.Drawing.Size(164, 32);
            this.打印设置ToolStripMenuItem.Text = "打印设置";
            this.打印设置ToolStripMenuItem.Click += new System.EventHandler(this.打印设置ToolStripMenuItem_Click);
            // 
            // 日志ToolStripMenuItem
            // 
            this.日志ToolStripMenuItem.Name = "日志ToolStripMenuItem";
            this.日志ToolStripMenuItem.Size = new System.Drawing.Size(64, 31);
            this.日志ToolStripMenuItem.Text = "日志";
            this.日志ToolStripMenuItem.Visible = false;
            // 
            // 操作员ToolStripMenuItem
            // 
            this.操作员ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作员管理ToolStripMenuItem});
            this.操作员ToolStripMenuItem.Name = "操作员ToolStripMenuItem";
            this.操作员ToolStripMenuItem.Size = new System.Drawing.Size(84, 31);
            this.操作员ToolStripMenuItem.Text = "操作员";
            // 
            // 操作员管理ToolStripMenuItem
            // 
            this.操作员管理ToolStripMenuItem.Name = "操作员管理ToolStripMenuItem";
            this.操作员管理ToolStripMenuItem.Size = new System.Drawing.Size(184, 32);
            this.操作员管理ToolStripMenuItem.Text = "操作员管理";
            this.操作员管理ToolStripMenuItem.Click += new System.EventHandler(this.操作员管理ToolStripMenuItem_Click);
            // 
            // pageFood
            // 
            this.pageFood.Controls.Add(this.layoutFood);
            this.pageFood.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pageFood.Location = new System.Drawing.Point(4, 37);
            this.pageFood.Name = "pageFood";
            this.pageFood.Padding = new System.Windows.Forms.Padding(3);
            this.pageFood.Size = new System.Drawing.Size(1158, 515);
            this.pageFood.TabIndex = 1;
            this.pageFood.Text = "菜品管理";
            this.pageFood.UseVisualStyleBackColor = true;
            // 
            // layoutFood
            // 
            this.layoutFood.ColumnCount = 2;
            this.layoutFood.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutFood.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.layoutFood.Controls.Add(this.gbFoodCate, 0, 0);
            this.layoutFood.Controls.Add(this.layoutFoodInfo, 1, 0);
            this.layoutFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutFood.Location = new System.Drawing.Point(3, 3);
            this.layoutFood.Name = "layoutFood";
            this.layoutFood.RowCount = 1;
            this.layoutFood.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutFood.Size = new System.Drawing.Size(1152, 509);
            this.layoutFood.TabIndex = 0;
            // 
            // gbFoodCate
            // 
            this.gbFoodCate.Controls.Add(this.tvFoodCate);
            this.gbFoodCate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFoodCate.Location = new System.Drawing.Point(3, 3);
            this.gbFoodCate.Name = "gbFoodCate";
            this.gbFoodCate.Size = new System.Drawing.Size(224, 503);
            this.gbFoodCate.TabIndex = 0;
            this.gbFoodCate.TabStop = false;
            this.gbFoodCate.Text = "菜品类别";
            // 
            // tvFoodCate
            // 
            this.tvFoodCate.ContextMenuStrip = this.foodOps;
            this.tvFoodCate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFoodCate.Location = new System.Drawing.Point(3, 25);
            this.tvFoodCate.Name = "tvFoodCate";
            this.tvFoodCate.Size = new System.Drawing.Size(218, 475);
            this.tvFoodCate.TabIndex = 0;
            this.tvFoodCate.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFoodCate_AfterSelect);
            // 
            // foodOps
            // 
            this.foodOps.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.foodOps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增分类ToolStripMenuItem,
            this.删除分类ToolStripMenuItem,
            this.toolStripSeparator2,
            this.新增商品ToolStripMenuItem});
            this.foodOps.Name = "foodOps";
            this.foodOps.Size = new System.Drawing.Size(145, 88);
            // 
            // 新增分类ToolStripMenuItem
            // 
            this.新增分类ToolStripMenuItem.Name = "新增分类ToolStripMenuItem";
            this.新增分类ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.新增分类ToolStripMenuItem.Text = "新增分类";
            this.新增分类ToolStripMenuItem.Click += new System.EventHandler(this.新增分类ToolStripMenuItem_Click);
            // 
            // 删除分类ToolStripMenuItem
            // 
            this.删除分类ToolStripMenuItem.Name = "删除分类ToolStripMenuItem";
            this.删除分类ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.删除分类ToolStripMenuItem.Text = "删除分类";
            this.删除分类ToolStripMenuItem.Click += new System.EventHandler(this.删除分类ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(141, 6);
            // 
            // 新增商品ToolStripMenuItem
            // 
            this.新增商品ToolStripMenuItem.Name = "新增商品ToolStripMenuItem";
            this.新增商品ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.新增商品ToolStripMenuItem.Text = "新增商品";
            this.新增商品ToolStripMenuItem.Click += new System.EventHandler(this.新增商品ToolStripMenuItem_Click);
            // 
            // layoutFoodInfo
            // 
            this.layoutFoodInfo.ColumnCount = 1;
            this.layoutFoodInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutFoodInfo.Controls.Add(this.dvAllFood, 0, 1);
            this.layoutFoodInfo.Controls.Add(this.pnSearchFood, 0, 0);
            this.layoutFoodInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutFoodInfo.Location = new System.Drawing.Point(233, 3);
            this.layoutFoodInfo.Name = "layoutFoodInfo";
            this.layoutFoodInfo.RowCount = 2;
            this.layoutFoodInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.layoutFoodInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.layoutFoodInfo.Size = new System.Drawing.Size(916, 503);
            this.layoutFoodInfo.TabIndex = 1;
            // 
            // dvAllFood
            // 
            this.dvAllFood.AllowUserToAddRows = false;
            this.dvAllFood.AllowUserToDeleteRows = false;
            this.dvAllFood.AllowUserToResizeRows = false;
            this.dvAllFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvAllFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cnName,
            this.enName,
            this.des,
            this.price,
            this.species,
            this.isDiscount,
            this.status,
            this.unit,
            this.isPlan,
            this.createTime,
            this.updateTime,
            this.imageUpdateTime,
            this.delTime,
            this.needKC,
            this.needMaterials});
            this.dvAllFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvAllFood.Location = new System.Drawing.Point(3, 43);
            this.dvAllFood.Name = "dvAllFood";
            this.dvAllFood.ReadOnly = true;
            this.dvAllFood.RowHeadersVisible = false;
            this.dvAllFood.RowTemplate.Height = 23;
            this.dvAllFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvAllFood.Size = new System.Drawing.Size(910, 457);
            this.dvAllFood.TabIndex = 2;
            this.dvAllFood.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvAllFood_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "编号";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // cnName
            // 
            this.cnName.HeaderText = "名称";
            this.cnName.Name = "cnName";
            this.cnName.ReadOnly = true;
            // 
            // enName
            // 
            this.enName.HeaderText = "简写";
            this.enName.Name = "enName";
            this.enName.ReadOnly = true;
            // 
            // des
            // 
            this.des.HeaderText = "描述";
            this.des.Name = "des";
            this.des.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "价格";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // species
            // 
            this.species.HeaderText = "分类";
            this.species.Name = "species";
            this.species.ReadOnly = true;
            // 
            // isDiscount
            // 
            this.isDiscount.HeaderText = "打折";
            this.isDiscount.Name = "isDiscount";
            this.isDiscount.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "状态";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.HeaderText = "单位";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // isPlan
            // 
            this.isPlan.HeaderText = "套餐";
            this.isPlan.Name = "isPlan";
            this.isPlan.ReadOnly = true;
            // 
            // createTime
            // 
            this.createTime.HeaderText = "增加时间";
            this.createTime.Name = "createTime";
            this.createTime.ReadOnly = true;
            // 
            // updateTime
            // 
            this.updateTime.HeaderText = "修改时间";
            this.updateTime.Name = "updateTime";
            this.updateTime.ReadOnly = true;
            this.updateTime.Visible = false;
            // 
            // imageUpdateTime
            // 
            this.imageUpdateTime.HeaderText = "图片修改时间";
            this.imageUpdateTime.Name = "imageUpdateTime";
            this.imageUpdateTime.ReadOnly = true;
            this.imageUpdateTime.Visible = false;
            // 
            // delTime
            // 
            this.delTime.HeaderText = "删除时间";
            this.delTime.Name = "delTime";
            this.delTime.ReadOnly = true;
            this.delTime.Visible = false;
            // 
            // needKC
            // 
            this.needKC.HeaderText = "开启库存";
            this.needKC.Name = "needKC";
            this.needKC.ReadOnly = true;
            // 
            // needMaterials
            // 
            this.needMaterials.HeaderText = "原材料库存";
            this.needMaterials.Name = "needMaterials";
            this.needMaterials.ReadOnly = true;
            // 
            // pnSearchFood
            // 
            this.pnSearchFood.Controls.Add(this.tbFoodSearchStr);
            this.pnSearchFood.Controls.Add(this.label1);
            this.pnSearchFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSearchFood.Location = new System.Drawing.Point(3, 3);
            this.pnSearchFood.Name = "pnSearchFood";
            this.pnSearchFood.Size = new System.Drawing.Size(910, 34);
            this.pnSearchFood.TabIndex = 0;
            // 
            // tbFoodSearchStr
            // 
            this.tbFoodSearchStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFoodSearchStr.Location = new System.Drawing.Point(664, 3);
            this.tbFoodSearchStr.Name = "tbFoodSearchStr";
            this.tbFoodSearchStr.Size = new System.Drawing.Size(208, 29);
            this.tbFoodSearchStr.TabIndex = 1;
            this.tbFoodSearchStr.TextChanged += new System.EventHandler(this.tbFoodSearchStr_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "搜索";
            // 
            // pageConsume
            // 
            this.pageConsume.Controls.Add(this.layoutMain);
            this.pageConsume.Location = new System.Drawing.Point(4, 37);
            this.pageConsume.Name = "pageConsume";
            this.pageConsume.Padding = new System.Windows.Forms.Padding(3);
            this.pageConsume.Size = new System.Drawing.Size(1158, 515);
            this.pageConsume.TabIndex = 0;
            this.pageConsume.Text = "消费";
            this.pageConsume.UseVisualStyleBackColor = true;
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 2;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.layoutMain.Controls.Add(this.gbInfo, 0, 0);
            this.layoutMain.Controls.Add(this.layoutTabs, 1, 0);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(3, 3);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 1;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Size = new System.Drawing.Size(1152, 509);
            this.layoutMain.TabIndex = 0;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.layoutInfo);
            this.gbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInfo.Location = new System.Drawing.Point(3, 3);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(224, 503);
            this.gbInfo.TabIndex = 1;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "餐台信息";
            // 
            // layoutInfo
            // 
            this.layoutInfo.ColumnCount = 1;
            this.layoutInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutInfo.Controls.Add(this.lbCustCount, 0, 3);
            this.layoutInfo.Controls.Add(this.lbOpenPretage, 0, 2);
            this.layoutInfo.Controls.Add(this.lbOpenTime, 0, 1);
            this.layoutInfo.Controls.Add(this.lbName, 0, 0);
            this.layoutInfo.Controls.Add(this.groupBox1, 0, 5);
            this.layoutInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutInfo.Location = new System.Drawing.Point(3, 31);
            this.layoutInfo.Name = "layoutInfo";
            this.layoutInfo.RowCount = 6;
            this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.layoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.layoutInfo.Size = new System.Drawing.Size(218, 469);
            this.layoutInfo.TabIndex = 0;
            // 
            // lbCustCount
            // 
            this.lbCustCount.AutoSize = true;
            this.lbCustCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCustCount.Location = new System.Drawing.Point(3, 111);
            this.lbCustCount.Name = "lbCustCount";
            this.lbCustCount.Size = new System.Drawing.Size(212, 37);
            this.lbCustCount.TabIndex = 3;
            this.lbCustCount.Text = "用餐人数：";
            this.lbCustCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbOpenPretage
            // 
            this.lbOpenPretage.AutoSize = true;
            this.lbOpenPretage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOpenPretage.Location = new System.Drawing.Point(3, 74);
            this.lbOpenPretage.Name = "lbOpenPretage";
            this.lbOpenPretage.Size = new System.Drawing.Size(212, 37);
            this.lbOpenPretage.TabIndex = 2;
            this.lbOpenPretage.Text = "开台率：";
            this.lbOpenPretage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbOpenTime
            // 
            this.lbOpenTime.AutoSize = true;
            this.lbOpenTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOpenTime.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.lbOpenTime.Location = new System.Drawing.Point(3, 37);
            this.lbOpenTime.Name = "lbOpenTime";
            this.lbOpenTime.Size = new System.Drawing.Size(212, 37);
            this.lbOpenTime.TabIndex = 1;
            this.lbOpenTime.Text = "开台时间：";
            this.lbOpenTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Location = new System.Drawing.Point(3, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(212, 37);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "A区 餐桌：A1";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvFood);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.groupBox1.Location = new System.Drawing.Point(3, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 278);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "点餐信息";
            // 
            // dvFood
            // 
            this.dvFood.AllowUserToAddRows = false;
            this.dvFood.AllowUserToResizeRows = false;
            this.dvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodid,
            this.foodname,
            this.foodcount,
            this.foodprice});
            this.dvFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvFood.Location = new System.Drawing.Point(3, 25);
            this.dvFood.Name = "dvFood";
            this.dvFood.ReadOnly = true;
            this.dvFood.RowHeadersVisible = false;
            this.dvFood.RowTemplate.Height = 23;
            this.dvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvFood.Size = new System.Drawing.Size(206, 250);
            this.dvFood.TabIndex = 0;
            // 
            // foodid
            // 
            this.foodid.HeaderText = "商品编号";
            this.foodid.Name = "foodid";
            this.foodid.ReadOnly = true;
            this.foodid.Visible = false;
            // 
            // foodname
            // 
            this.foodname.HeaderText = "名称";
            this.foodname.Name = "foodname";
            this.foodname.ReadOnly = true;
            // 
            // foodcount
            // 
            this.foodcount.HeaderText = "数量";
            this.foodcount.Name = "foodcount";
            this.foodcount.ReadOnly = true;
            // 
            // foodprice
            // 
            this.foodprice.HeaderText = "价格";
            this.foodprice.Name = "foodprice";
            this.foodprice.ReadOnly = true;
            // 
            // layoutTabs
            // 
            this.layoutTabs.ColumnCount = 1;
            this.layoutTabs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTabs.Controls.Add(this.tcTabs, 0, 0);
            this.layoutTabs.Controls.Add(this.pnOps, 0, 1);
            this.layoutTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTabs.Location = new System.Drawing.Point(233, 3);
            this.layoutTabs.Name = "layoutTabs";
            this.layoutTabs.RowCount = 2;
            this.layoutTabs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.layoutTabs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutTabs.Size = new System.Drawing.Size(916, 503);
            this.layoutTabs.TabIndex = 2;
            // 
            // tcTabs
            // 
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.Location = new System.Drawing.Point(3, 3);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(910, 421);
            this.tcTabs.TabIndex = 0;
            this.tcTabs.SelectedIndexChanged += new System.EventHandler(this.tcTabs_SelectedIndexChanged);
            // 
            // pnOps
            // 
            this.pnOps.Controls.Add(this.lbReset);
            this.pnOps.Controls.Add(this.lbRefresh);
            this.pnOps.Controls.Add(this.lbChangeTab);
            this.pnOps.Controls.Add(this.lbCheckout);
            this.pnOps.Controls.Add(this.lbOrder);
            this.pnOps.Controls.Add(this.lbUserTab);
            this.pnOps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnOps.Location = new System.Drawing.Point(3, 430);
            this.pnOps.Name = "pnOps";
            this.pnOps.Size = new System.Drawing.Size(910, 70);
            this.pnOps.TabIndex = 1;
            // 
            // lbReset
            // 
            this.lbReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbReset.BackColor = System.Drawing.Color.LightGreen;
            this.lbReset.ForeColor = System.Drawing.Color.White;
            this.lbReset.Location = new System.Drawing.Point(585, 11);
            this.lbReset.Name = "lbReset";
            this.lbReset.Size = new System.Drawing.Size(90, 50);
            this.lbReset.TabIndex = 5;
            this.lbReset.Text = "重置";
            this.lbReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbReset.Click += new System.EventHandler(this.lbReset_Click);
            // 
            // lbRefresh
            // 
            this.lbRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRefresh.BackColor = System.Drawing.Color.LightGreen;
            this.lbRefresh.ForeColor = System.Drawing.Color.White;
            this.lbRefresh.Location = new System.Drawing.Point(476, 11);
            this.lbRefresh.Name = "lbRefresh";
            this.lbRefresh.Size = new System.Drawing.Size(90, 50);
            this.lbRefresh.TabIndex = 4;
            this.lbRefresh.Text = "刷新";
            this.lbRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbRefresh.Click += new System.EventHandler(this.lbRefresh_Click);
            // 
            // lbChangeTab
            // 
            this.lbChangeTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbChangeTab.BackColor = System.Drawing.Color.LightGreen;
            this.lbChangeTab.ForeColor = System.Drawing.Color.White;
            this.lbChangeTab.Location = new System.Drawing.Point(367, 11);
            this.lbChangeTab.Name = "lbChangeTab";
            this.lbChangeTab.Size = new System.Drawing.Size(90, 50);
            this.lbChangeTab.TabIndex = 3;
            this.lbChangeTab.Text = "换桌";
            this.lbChangeTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbChangeTab.Click += new System.EventHandler(this.lbChangeTab_Click);
            // 
            // lbCheckout
            // 
            this.lbCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCheckout.BackColor = System.Drawing.Color.LightGreen;
            this.lbCheckout.ForeColor = System.Drawing.Color.White;
            this.lbCheckout.Location = new System.Drawing.Point(258, 11);
            this.lbCheckout.Name = "lbCheckout";
            this.lbCheckout.Size = new System.Drawing.Size(90, 50);
            this.lbCheckout.TabIndex = 2;
            this.lbCheckout.Text = "结账";
            this.lbCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCheckout.Click += new System.EventHandler(this.lbCheckout_Click);
            // 
            // lbOrder
            // 
            this.lbOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbOrder.BackColor = System.Drawing.Color.LightGreen;
            this.lbOrder.ForeColor = System.Drawing.Color.White;
            this.lbOrder.Location = new System.Drawing.Point(149, 11);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(90, 50);
            this.lbOrder.TabIndex = 1;
            this.lbOrder.Text = "点餐";
            this.lbOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbOrder.Click += new System.EventHandler(this.lbOrder_Click);
            // 
            // lbUserTab
            // 
            this.lbUserTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUserTab.BackColor = System.Drawing.Color.LightGreen;
            this.lbUserTab.ForeColor = System.Drawing.Color.White;
            this.lbUserTab.Location = new System.Drawing.Point(40, 11);
            this.lbUserTab.Name = "lbUserTab";
            this.lbUserTab.Size = new System.Drawing.Size(90, 50);
            this.lbUserTab.TabIndex = 0;
            this.lbUserTab.Text = "开台";
            this.lbUserTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbUserTab.Click += new System.EventHandler(this.lbUserTab_Click);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.pageConsume);
            this.tcMain.Controls.Add(this.pageFood);
            this.tcMain.Controls.Add(this.pageOpers);
            this.tcMain.Controls.Add(this.pageReport);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 35);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1166, 556);
            this.tcMain.TabIndex = 0;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // pageOpers
            // 
            this.pageOpers.Controls.Add(this.layoutOpers);
            this.pageOpers.Location = new System.Drawing.Point(4, 37);
            this.pageOpers.Name = "pageOpers";
            this.pageOpers.Size = new System.Drawing.Size(1158, 515);
            this.pageOpers.TabIndex = 2;
            this.pageOpers.Text = "操作员管理";
            this.pageOpers.UseVisualStyleBackColor = true;
            // 
            // layoutOpers
            // 
            this.layoutOpers.ColumnCount = 2;
            this.layoutOpers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layoutOpers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.layoutOpers.Controls.Add(this.layoutOpersLeft, 0, 0);
            this.layoutOpers.Controls.Add(this.dvOpers, 1, 0);
            this.layoutOpers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutOpers.Location = new System.Drawing.Point(0, 0);
            this.layoutOpers.Name = "layoutOpers";
            this.layoutOpers.RowCount = 1;
            this.layoutOpers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutOpers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 515F));
            this.layoutOpers.Size = new System.Drawing.Size(1158, 515);
            this.layoutOpers.TabIndex = 0;
            // 
            // layoutOpersLeft
            // 
            this.layoutOpersLeft.ColumnCount = 1;
            this.layoutOpersLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutOpersLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutOpersLeft.Controls.Add(this.gbSearchOpers, 0, 0);
            this.layoutOpersLeft.Controls.Add(this.groupBox2, 0, 1);
            this.layoutOpersLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutOpersLeft.Location = new System.Drawing.Point(3, 3);
            this.layoutOpersLeft.Name = "layoutOpersLeft";
            this.layoutOpersLeft.RowCount = 2;
            this.layoutOpersLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.layoutOpersLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layoutOpersLeft.Size = new System.Drawing.Size(341, 509);
            this.layoutOpersLeft.TabIndex = 0;
            // 
            // gbSearchOpers
            // 
            this.gbSearchOpers.Controls.Add(this.cbOperSex);
            this.gbSearchOpers.Controls.Add(this.label5);
            this.gbSearchOpers.Controls.Add(this.cbOperPos);
            this.gbSearchOpers.Controls.Add(this.label4);
            this.gbSearchOpers.Controls.Add(this.tbOperOpenID);
            this.gbSearchOpers.Controls.Add(this.label3);
            this.gbSearchOpers.Controls.Add(this.tbOperName);
            this.gbSearchOpers.Controls.Add(this.label2);
            this.gbSearchOpers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSearchOpers.Location = new System.Drawing.Point(3, 3);
            this.gbSearchOpers.Name = "gbSearchOpers";
            this.gbSearchOpers.Size = new System.Drawing.Size(335, 299);
            this.gbSearchOpers.TabIndex = 0;
            this.gbSearchOpers.TabStop = false;
            this.gbSearchOpers.Text = "操作员查询";
            // 
            // cbOperSex
            // 
            this.cbOperSex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOperSex.FormattingEnabled = true;
            this.cbOperSex.Items.AddRange(new object[] {
            "全部",
            "男",
            "女"});
            this.cbOperSex.Location = new System.Drawing.Point(111, 223);
            this.cbOperSex.Name = "cbOperSex";
            this.cbOperSex.Size = new System.Drawing.Size(205, 36);
            this.cbOperSex.TabIndex = 7;
            this.cbOperSex.SelectedIndexChanged += new System.EventHandler(this.cbOperSex_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "性别：";
            // 
            // cbOperPos
            // 
            this.cbOperPos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOperPos.FormattingEnabled = true;
            this.cbOperPos.Location = new System.Drawing.Point(111, 164);
            this.cbOperPos.Name = "cbOperPos";
            this.cbOperPos.Size = new System.Drawing.Size(205, 36);
            this.cbOperPos.TabIndex = 5;
            this.cbOperPos.Text = "全部";
            this.cbOperPos.SelectedIndexChanged += new System.EventHandler(this.cbOperPos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "职务：";
            // 
            // tbOperOpenID
            // 
            this.tbOperOpenID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOperOpenID.Location = new System.Drawing.Point(111, 103);
            this.tbOperOpenID.Name = "tbOperOpenID";
            this.tbOperOpenID.Size = new System.Drawing.Size(205, 35);
            this.tbOperOpenID.TabIndex = 3;
            this.tbOperOpenID.TextChanged += new System.EventHandler(this.tbOperOpenID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名:";
            // 
            // tbOperName
            // 
            this.tbOperName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOperName.Location = new System.Drawing.Point(111, 44);
            this.tbOperName.Name = "tbOperName";
            this.tbOperName.Size = new System.Drawing.Size(205, 35);
            this.tbOperName.TabIndex = 1;
            this.tbOperName.TextChanged += new System.EventHandler(this.tbOperName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "编码:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDelOpers);
            this.groupBox2.Controls.Add(this.lbUpdateOpers);
            this.groupBox2.Controls.Add(this.lbAddOpers);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // lbDelOpers
            // 
            this.lbDelOpers.BackColor = System.Drawing.Color.Black;
            this.lbDelOpers.ForeColor = System.Drawing.Color.White;
            this.lbDelOpers.Location = new System.Drawing.Point(241, 71);
            this.lbDelOpers.Name = "lbDelOpers";
            this.lbDelOpers.Size = new System.Drawing.Size(88, 51);
            this.lbDelOpers.TabIndex = 2;
            this.lbDelOpers.Text = "删除";
            this.lbDelOpers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDelOpers.Click += new System.EventHandler(this.lbDelOpers_Click);
            // 
            // lbUpdateOpers
            // 
            this.lbUpdateOpers.BackColor = System.Drawing.Color.Black;
            this.lbUpdateOpers.ForeColor = System.Drawing.Color.White;
            this.lbUpdateOpers.Location = new System.Drawing.Point(132, 71);
            this.lbUpdateOpers.Name = "lbUpdateOpers";
            this.lbUpdateOpers.Size = new System.Drawing.Size(88, 51);
            this.lbUpdateOpers.TabIndex = 1;
            this.lbUpdateOpers.Text = "修改";
            this.lbUpdateOpers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAddOpers
            // 
            this.lbAddOpers.BackColor = System.Drawing.Color.Black;
            this.lbAddOpers.ForeColor = System.Drawing.Color.White;
            this.lbAddOpers.Location = new System.Drawing.Point(24, 71);
            this.lbAddOpers.Name = "lbAddOpers";
            this.lbAddOpers.Size = new System.Drawing.Size(88, 51);
            this.lbAddOpers.TabIndex = 0;
            this.lbAddOpers.Text = "新增";
            this.lbAddOpers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAddOpers.Click += new System.EventHandler(this.lbAddOpers_Click);
            // 
            // dvOpers
            // 
            this.dvOpers.AllowUserToAddRows = false;
            this.dvOpers.AllowUserToDeleteRows = false;
            this.dvOpers.AllowUserToResizeRows = false;
            this.dvOpers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvOpers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operid,
            this.operpwd,
            this.opername,
            this.operloginid,
            this.opersex,
            this.operpos,
            this.opergrangirhts,
            this.opernotgranrights});
            this.dvOpers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvOpers.Location = new System.Drawing.Point(350, 3);
            this.dvOpers.Name = "dvOpers";
            this.dvOpers.ReadOnly = true;
            this.dvOpers.RowHeadersVisible = false;
            this.dvOpers.RowTemplate.Height = 23;
            this.dvOpers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvOpers.Size = new System.Drawing.Size(805, 509);
            this.dvOpers.TabIndex = 1;
            this.dvOpers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvOpers_CellDoubleClick);
            // 
            // operid
            // 
            this.operid.HeaderText = "operid";
            this.operid.Name = "operid";
            this.operid.ReadOnly = true;
            this.operid.Visible = false;
            // 
            // operpwd
            // 
            this.operpwd.HeaderText = "操作员密码";
            this.operpwd.Name = "operpwd";
            this.operpwd.ReadOnly = true;
            this.operpwd.Visible = false;
            // 
            // opername
            // 
            this.opername.HeaderText = "操作员姓名";
            this.opername.Name = "opername";
            this.opername.ReadOnly = true;
            this.opername.Width = 150;
            // 
            // operloginid
            // 
            this.operloginid.HeaderText = "操作员编码";
            this.operloginid.Name = "operloginid";
            this.operloginid.ReadOnly = true;
            this.operloginid.Width = 150;
            // 
            // opersex
            // 
            this.opersex.HeaderText = "性别";
            this.opersex.Name = "opersex";
            this.opersex.ReadOnly = true;
            this.opersex.Width = 80;
            // 
            // operpos
            // 
            this.operpos.HeaderText = "职务";
            this.operpos.Name = "operpos";
            this.operpos.ReadOnly = true;
            this.operpos.Width = 80;
            // 
            // opergrangirhts
            // 
            this.opergrangirhts.FillWeight = 400F;
            this.opergrangirhts.HeaderText = "已授予权限";
            this.opergrangirhts.Name = "opergrangirhts";
            this.opergrangirhts.ReadOnly = true;
            this.opergrangirhts.Width = 300;
            // 
            // opernotgranrights
            // 
            this.opernotgranrights.HeaderText = "未授予权限";
            this.opernotgranrights.Name = "opernotgranrights";
            this.opernotgranrights.ReadOnly = true;
            this.opernotgranrights.Width = 300;
            // 
            // pageReport
            // 
            this.pageReport.Controls.Add(this.tabReports);
            this.pageReport.Location = new System.Drawing.Point(4, 37);
            this.pageReport.Name = "pageReport";
            this.pageReport.Size = new System.Drawing.Size(1158, 515);
            this.pageReport.TabIndex = 3;
            this.pageReport.Text = "报表";
            this.pageReport.UseVisualStyleBackColor = true;
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.pageBill);
            this.tabReports.Controls.Add(this.pageFoodReprt);
            this.tabReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReports.Location = new System.Drawing.Point(0, 0);
            this.tabReports.Name = "tabReports";
            this.tabReports.SelectedIndex = 0;
            this.tabReports.Size = new System.Drawing.Size(1158, 515);
            this.tabReports.TabIndex = 0;
            // 
            // pageBill
            // 
            this.pageBill.Controls.Add(this.layoutBillReport);
            this.pageBill.Location = new System.Drawing.Point(4, 37);
            this.pageBill.Name = "pageBill";
            this.pageBill.Padding = new System.Windows.Forms.Padding(3);
            this.pageBill.Size = new System.Drawing.Size(1150, 474);
            this.pageBill.TabIndex = 0;
            this.pageBill.Text = "账单信息";
            this.pageBill.UseVisualStyleBackColor = true;
            // 
            // layoutBillReport
            // 
            this.layoutBillReport.ColumnCount = 2;
            this.layoutBillReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layoutBillReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.layoutBillReport.Controls.Add(this.gbBillReportQuery, 0, 0);
            this.layoutBillReport.Controls.Add(this.pnAllBill, 1, 0);
            this.layoutBillReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutBillReport.Location = new System.Drawing.Point(3, 3);
            this.layoutBillReport.Name = "layoutBillReport";
            this.layoutBillReport.RowCount = 1;
            this.layoutBillReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutBillReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 483F));
            this.layoutBillReport.Size = new System.Drawing.Size(1144, 468);
            this.layoutBillReport.TabIndex = 0;
            // 
            // gbBillReportQuery
            // 
            this.gbBillReportQuery.Controls.Add(this.lbImport);
            this.gbBillReportQuery.Controls.Add(this.lbQuery);
            this.gbBillReportQuery.Controls.Add(this.dtcheckend);
            this.gbBillReportQuery.Controls.Add(this.label9);
            this.gbBillReportQuery.Controls.Add(this.dtcheckbegin);
            this.gbBillReportQuery.Controls.Add(this.label8);
            this.gbBillReportQuery.Controls.Add(this.cbPaymethod);
            this.gbBillReportQuery.Controls.Add(this.label7);
            this.gbBillReportQuery.Controls.Add(this.tbBillkey);
            this.gbBillReportQuery.Controls.Add(this.label6);
            this.gbBillReportQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBillReportQuery.Location = new System.Drawing.Point(3, 3);
            this.gbBillReportQuery.Name = "gbBillReportQuery";
            this.gbBillReportQuery.Size = new System.Drawing.Size(337, 462);
            this.gbBillReportQuery.TabIndex = 0;
            this.gbBillReportQuery.TabStop = false;
            this.gbBillReportQuery.Text = "帅选";
            // 
            // lbImport
            // 
            this.lbImport.BackColor = System.Drawing.Color.Black;
            this.lbImport.ForeColor = System.Drawing.Color.White;
            this.lbImport.Location = new System.Drawing.Point(117, 314);
            this.lbImport.Name = "lbImport";
            this.lbImport.Size = new System.Drawing.Size(87, 45);
            this.lbImport.TabIndex = 9;
            this.lbImport.Text = "导出";
            this.lbImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbImport.Click += new System.EventHandler(this.lbImport_Click);
            // 
            // lbQuery
            // 
            this.lbQuery.BackColor = System.Drawing.Color.Black;
            this.lbQuery.ForeColor = System.Drawing.Color.White;
            this.lbQuery.Location = new System.Drawing.Point(15, 314);
            this.lbQuery.Name = "lbQuery";
            this.lbQuery.Size = new System.Drawing.Size(87, 45);
            this.lbQuery.TabIndex = 8;
            this.lbQuery.Text = "查询";
            this.lbQuery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbQuery.Click += new System.EventHandler(this.lbQuery_Click);
            // 
            // dtcheckend
            // 
            this.dtcheckend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtcheckend.Location = new System.Drawing.Point(108, 231);
            this.dtcheckend.Name = "dtcheckend";
            this.dtcheckend.Size = new System.Drawing.Size(223, 35);
            this.dtcheckend.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 28);
            this.label9.TabIndex = 6;
            this.label9.Text = "-";
            // 
            // dtcheckbegin
            // 
            this.dtcheckbegin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtcheckbegin.Location = new System.Drawing.Point(109, 170);
            this.dtcheckbegin.Name = "dtcheckbegin";
            this.dtcheckbegin.Size = new System.Drawing.Size(223, 35);
            this.dtcheckbegin.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "交易时间";
            // 
            // cbPaymethod
            // 
            this.cbPaymethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPaymethod.FormattingEnabled = true;
            this.cbPaymethod.Location = new System.Drawing.Point(109, 99);
            this.cbPaymethod.Name = "cbPaymethod";
            this.cbPaymethod.Size = new System.Drawing.Size(223, 36);
            this.cbPaymethod.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "交易类型";
            // 
            // tbBillkey
            // 
            this.tbBillkey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBillkey.Location = new System.Drawing.Point(108, 40);
            this.tbBillkey.Name = "tbBillkey";
            this.tbBillkey.Size = new System.Drawing.Size(223, 35);
            this.tbBillkey.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "账单号";
            // 
            // pnAllBill
            // 
            this.pnAllBill.Controls.Add(this.dvAllBill);
            this.pnAllBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAllBill.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.pnAllBill.Location = new System.Drawing.Point(346, 3);
            this.pnAllBill.Name = "pnAllBill";
            this.pnAllBill.Size = new System.Drawing.Size(795, 462);
            this.pnAllBill.TabIndex = 1;
            // 
            // dvAllBill
            // 
            this.dvAllBill.AllowUserToAddRows = false;
            this.dvAllBill.AllowUserToDeleteRows = false;
            this.dvAllBill.AllowUserToResizeRows = false;
            this.dvAllBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvAllBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billkey,
            this.billtabName,
            this.billMoney,
            this.paymethod,
            this.SHmoney,
            this.SHcash,
            this.SHvesa,
            this.billtime,
            this.checktime,
            this.checkUsername,
            this.custCount,
            this.discount});
            this.dvAllBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvAllBill.Location = new System.Drawing.Point(0, 0);
            this.dvAllBill.Name = "dvAllBill";
            this.dvAllBill.ReadOnly = true;
            this.dvAllBill.RowHeadersVisible = false;
            this.dvAllBill.RowTemplate.Height = 23;
            this.dvAllBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvAllBill.Size = new System.Drawing.Size(795, 462);
            this.dvAllBill.TabIndex = 2;
            // 
            // billkey
            // 
            this.billkey.HeaderText = "账单号";
            this.billkey.Name = "billkey";
            this.billkey.ReadOnly = true;
            this.billkey.Width = 150;
            // 
            // billtabName
            // 
            this.billtabName.HeaderText = "餐桌名";
            this.billtabName.Name = "billtabName";
            this.billtabName.ReadOnly = true;
            // 
            // billMoney
            // 
            this.billMoney.HeaderText = "账单金额";
            this.billMoney.Name = "billMoney";
            this.billMoney.ReadOnly = true;
            // 
            // paymethod
            // 
            this.paymethod.HeaderText = "支付方式";
            this.paymethod.Name = "paymethod";
            this.paymethod.ReadOnly = true;
            // 
            // SHmoney
            // 
            this.SHmoney.HeaderText = "实收金额";
            this.SHmoney.Name = "SHmoney";
            this.SHmoney.ReadOnly = true;
            // 
            // SHcash
            // 
            this.SHcash.HeaderText = "实收现金";
            this.SHcash.Name = "SHcash";
            this.SHcash.ReadOnly = true;
            // 
            // SHvesa
            // 
            this.SHvesa.HeaderText = "实收刷卡";
            this.SHvesa.Name = "SHvesa";
            this.SHvesa.ReadOnly = true;
            // 
            // billtime
            // 
            this.billtime.HeaderText = "开台时间";
            this.billtime.Name = "billtime";
            this.billtime.ReadOnly = true;
            // 
            // checktime
            // 
            this.checktime.HeaderText = "结账时间";
            this.checktime.Name = "checktime";
            this.checktime.ReadOnly = true;
            // 
            // checkUsername
            // 
            this.checkUsername.HeaderText = "收银员";
            this.checkUsername.Name = "checkUsername";
            this.checkUsername.ReadOnly = true;
            // 
            // custCount
            // 
            this.custCount.HeaderText = "顾客人数";
            this.custCount.Name = "custCount";
            this.custCount.ReadOnly = true;
            // 
            // discount
            // 
            this.discount.HeaderText = "折扣";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // pageFoodReprt
            // 
            this.pageFoodReprt.Controls.Add(this.layouFoodCount);
            this.pageFoodReprt.Location = new System.Drawing.Point(4, 37);
            this.pageFoodReprt.Name = "pageFoodReprt";
            this.pageFoodReprt.Padding = new System.Windows.Forms.Padding(3);
            this.pageFoodReprt.Size = new System.Drawing.Size(1150, 474);
            this.pageFoodReprt.TabIndex = 1;
            this.pageFoodReprt.Text = "菜品出品统计";
            this.pageFoodReprt.UseVisualStyleBackColor = true;
            // 
            // layouFoodCount
            // 
            this.layouFoodCount.ColumnCount = 2;
            this.layouFoodCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layouFoodCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.layouFoodCount.Controls.Add(this.gbFoodCount, 0, 0);
            this.layouFoodCount.Controls.Add(this.dvFoodcount, 1, 0);
            this.layouFoodCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layouFoodCount.Location = new System.Drawing.Point(3, 3);
            this.layouFoodCount.Name = "layouFoodCount";
            this.layouFoodCount.RowCount = 1;
            this.layouFoodCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layouFoodCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 483F));
            this.layouFoodCount.Size = new System.Drawing.Size(1144, 468);
            this.layouFoodCount.TabIndex = 0;
            // 
            // gbFoodCount
            // 
            this.gbFoodCount.Controls.Add(this.lbCount);
            this.gbFoodCount.Controls.Add(this.dtFoodEnd);
            this.gbFoodCount.Controls.Add(this.label11);
            this.gbFoodCount.Controls.Add(this.dtFoodBegin);
            this.gbFoodCount.Controls.Add(this.label10);
            this.gbFoodCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFoodCount.Location = new System.Drawing.Point(3, 3);
            this.gbFoodCount.Name = "gbFoodCount";
            this.gbFoodCount.Size = new System.Drawing.Size(337, 462);
            this.gbFoodCount.TabIndex = 0;
            this.gbFoodCount.TabStop = false;
            this.gbFoodCount.Text = "帅选";
            // 
            // lbCount
            // 
            this.lbCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCount.BackColor = System.Drawing.Color.Black;
            this.lbCount.ForeColor = System.Drawing.Color.White;
            this.lbCount.Location = new System.Drawing.Point(230, 195);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(87, 45);
            this.lbCount.TabIndex = 9;
            this.lbCount.Text = "统计";
            this.lbCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCount.Click += new System.EventHandler(this.lbCount_Click);
            // 
            // dtFoodEnd
            // 
            this.dtFoodEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFoodEnd.Location = new System.Drawing.Point(120, 116);
            this.dtFoodEnd.Name = "dtFoodEnd";
            this.dtFoodEnd.Size = new System.Drawing.Size(211, 35);
            this.dtFoodEnd.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 28);
            this.label11.TabIndex = 2;
            this.label11.Text = "终止日期";
            // 
            // dtFoodBegin
            // 
            this.dtFoodBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFoodBegin.Location = new System.Drawing.Point(120, 40);
            this.dtFoodBegin.Name = "dtFoodBegin";
            this.dtFoodBegin.Size = new System.Drawing.Size(211, 35);
            this.dtFoodBegin.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "起始日期";
            // 
            // dvFoodcount
            // 
            this.dvFoodcount.AllowUserToAddRows = false;
            this.dvFoodcount.AllowUserToDeleteRows = false;
            this.dvFoodcount.AllowUserToResizeRows = false;
            this.dvFoodcount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvFoodcount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvFoodcount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvFoodcount.Location = new System.Drawing.Point(346, 3);
            this.dvFoodcount.Name = "dvFoodcount";
            this.dvFoodcount.ReadOnly = true;
            this.dvFoodcount.RowHeadersVisible = false;
            this.dvFoodcount.RowTemplate.Height = 23;
            this.dvFoodcount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvFoodcount.Size = new System.Drawing.Size(795, 462);
            this.dvFoodcount.TabIndex = 1;
            // 
            // ops
            // 
            this.ops.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ops.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开台ToolStripMenuItem,
            this.点餐ToolStripMenuItem,
            this.toolStripSeparator1,
            this.结账ToolStripMenuItem,
            this.换桌ToolStripMenuItem,
            this.重置ToolStripMenuItem});
            this.ops.Name = "ops";
            this.ops.Size = new System.Drawing.Size(113, 140);
            // 
            // 开台ToolStripMenuItem
            // 
            this.开台ToolStripMenuItem.Name = "开台ToolStripMenuItem";
            this.开台ToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.开台ToolStripMenuItem.Text = "开台";
            this.开台ToolStripMenuItem.Click += new System.EventHandler(this.开台ToolStripMenuItem_Click);
            // 
            // 点餐ToolStripMenuItem
            // 
            this.点餐ToolStripMenuItem.Name = "点餐ToolStripMenuItem";
            this.点餐ToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.点餐ToolStripMenuItem.Text = "点餐";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // 结账ToolStripMenuItem
            // 
            this.结账ToolStripMenuItem.Name = "结账ToolStripMenuItem";
            this.结账ToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.结账ToolStripMenuItem.Text = "结账";
            // 
            // 换桌ToolStripMenuItem
            // 
            this.换桌ToolStripMenuItem.Name = "换桌ToolStripMenuItem";
            this.换桌ToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.换桌ToolStripMenuItem.Text = "换桌";
            // 
            // 重置ToolStripMenuItem
            // 
            this.重置ToolStripMenuItem.Name = "重置ToolStripMenuItem";
            this.重置ToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.重置ToolStripMenuItem.Text = "重置";
            // 
            // billTimer
            // 
            this.billTimer.Enabled = true;
            this.billTimer.Interval = 5000;
            this.billTimer.Tick += new System.EventHandler(this.billTimer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 591);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.pageFood.ResumeLayout(false);
            this.layoutFood.ResumeLayout(false);
            this.gbFoodCate.ResumeLayout(false);
            this.foodOps.ResumeLayout(false);
            this.layoutFoodInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvAllFood)).EndInit();
            this.pnSearchFood.ResumeLayout(false);
            this.pnSearchFood.PerformLayout();
            this.pageConsume.ResumeLayout(false);
            this.layoutMain.ResumeLayout(false);
            this.gbInfo.ResumeLayout(false);
            this.layoutInfo.ResumeLayout(false);
            this.layoutInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvFood)).EndInit();
            this.layoutTabs.ResumeLayout(false);
            this.pnOps.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.pageOpers.ResumeLayout(false);
            this.layoutOpers.ResumeLayout(false);
            this.layoutOpersLeft.ResumeLayout(false);
            this.gbSearchOpers.ResumeLayout(false);
            this.gbSearchOpers.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvOpers)).EndInit();
            this.pageReport.ResumeLayout(false);
            this.tabReports.ResumeLayout(false);
            this.pageBill.ResumeLayout(false);
            this.layoutBillReport.ResumeLayout(false);
            this.gbBillReportQuery.ResumeLayout(false);
            this.gbBillReportQuery.PerformLayout();
            this.pnAllBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvAllBill)).EndInit();
            this.pageFoodReprt.ResumeLayout(false);
            this.layouFoodCount.ResumeLayout(false);
            this.gbFoodCount.ResumeLayout(false);
            this.gbFoodCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvFoodcount)).EndInit();
            this.ops.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem 消费ToolStripMenuItem;
        private System.Windows.Forms.TabPage pageFood;
        private System.Windows.Forms.TabPage pageConsume;
        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TableLayoutPanel layoutTabs;
        private System.Windows.Forms.TabControl tcTabs;
        private System.Windows.Forms.Panel pnOps;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.Label lbUserTab;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TableLayoutPanel layoutInfo;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCustCount;
        private System.Windows.Forms.Label lbOpenPretage;
        private System.Windows.Forms.Label lbOpenTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvFood;
        private System.Windows.Forms.Label lbCheckout;
        private System.Windows.Forms.Label lbChangeTab;
        private System.Windows.Forms.Label lbRefresh;
        private System.Windows.Forms.Label lbReset;
        private System.Windows.Forms.ContextMenuStrip ops;
        private System.Windows.Forms.ToolStripMenuItem 开台ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodid;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodname;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodprice;
        private System.Windows.Forms.ToolStripMenuItem 收银ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 消费ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 菜品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 财务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 餐桌设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 点餐ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结账ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 换桌ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重置ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel layoutFood;
        private System.Windows.Forms.GroupBox gbFoodCate;
        private System.Windows.Forms.TreeView tvFoodCate;
        private System.Windows.Forms.TableLayoutPanel layoutFoodInfo;
        private System.Windows.Forms.DataGridView dvAllFood;
        private System.Windows.Forms.Panel pnSearchFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFoodSearchStr;
        private System.Windows.Forms.ContextMenuStrip foodOps;
        private System.Windows.Forms.ToolStripMenuItem 新增分类ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除分类ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增商品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn enName;
        private System.Windows.Forms.DataGridViewTextBoxColumn des;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn species;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageUpdateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn delTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn needKC;
        private System.Windows.Forms.DataGridViewTextBoxColumn needMaterials;
        private System.Windows.Forms.ToolStripMenuItem 操作员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 交班ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日结ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 菜品管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作员管理ToolStripMenuItem;
        private System.Windows.Forms.TabPage pageOpers;
        private System.Windows.Forms.TableLayoutPanel layoutOpers;
        private System.Windows.Forms.TableLayoutPanel layoutOpersLeft;
        private System.Windows.Forms.GroupBox gbSearchOpers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOperName;
        private System.Windows.Forms.TextBox tbOperOpenID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbOperPos;
        private System.Windows.Forms.ComboBox cbOperSex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbAddOpers;
        private System.Windows.Forms.Label lbUpdateOpers;
        private System.Windows.Forms.Label lbDelOpers;
        private System.Windows.Forms.DataGridView dvOpers;
        private System.Windows.Forms.DataGridViewTextBoxColumn operid;
        private System.Windows.Forms.DataGridViewTextBoxColumn operpwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn opername;
        private System.Windows.Forms.DataGridViewTextBoxColumn operloginid;
        private System.Windows.Forms.DataGridViewTextBoxColumn opersex;
        private System.Windows.Forms.DataGridViewTextBoxColumn operpos;
        private System.Windows.Forms.DataGridViewTextBoxColumn opergrangirhts;
        private System.Windows.Forms.DataGridViewTextBoxColumn opernotgranrights;
        private System.Windows.Forms.ToolStripMenuItem 终端设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 营业数据表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 营业数据明细表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 库存信息表ToolStripMenuItem;
        private System.Windows.Forms.TabPage pageReport;
        private System.Windows.Forms.TabControl tabReports;
        private System.Windows.Forms.TabPage pageBill;
        private System.Windows.Forms.TabPage pageFoodReprt;
        private System.Windows.Forms.TableLayoutPanel layoutBillReport;
        private System.Windows.Forms.GroupBox gbBillReportQuery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBillkey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPaymethod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtcheckbegin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtcheckend;
        private System.Windows.Forms.Label lbQuery;
        private System.Windows.Forms.Label lbImport;
        private System.Windows.Forms.Panel pnAllBill;
        private System.Windows.Forms.DataGridView dvAllBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn billkey;
        private System.Windows.Forms.DataGridViewTextBoxColumn billtabName;
        private System.Windows.Forms.DataGridViewTextBoxColumn billMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHmoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHcash;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHvesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn billtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn checktime;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn custCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.TableLayoutPanel layouFoodCount;
        private System.Windows.Forms.GroupBox gbFoodCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtFoodBegin;
        private System.Windows.Forms.DateTimePicker dtFoodEnd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.DataGridView dvFoodcount;
        private System.Windows.Forms.Timer billTimer;
    }
}

