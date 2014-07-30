using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using yoogacatering;
using yoogacatering.Entity;
using yoogacatering.Printer;
using yoogacatering.Service;
using yoogacatering.Utils;

namespace 餐饮管理软件
{
   
    public partial class FormMain : Form
    {
        private string tabName = "";
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            JudgeRights();
            InitTabEnvs();
            InitTabs();

            lbUserTab.BackColor = Color.Gray;
            lbOrder.BackColor = Color.Gray;
            lbCheckout.BackColor = Color.Gray;
            lbChangeTab.BackColor = Color.Gray;

        }

        private void JudgeRights()
        {
            if (App.userGights.Contains("财务"))
            {
                报表ToolStripMenuItem.Visible = true;
            }
            else
            {
                报表ToolStripMenuItem.Visible = false;
                tcMain.TabPages.Remove(pageReport);
            }
            if (App.userGights.Contains("操作员管理"))
            {
                操作员ToolStripMenuItem.Visible = true;
            }
            else
            {
                操作员ToolStripMenuItem.Visible = false;
                tcMain.TabPages.Remove(pageOpers);
            }

            if (App.userGights.Contains("终端设置"))
            {
                终端设置ToolStripMenuItem.Visible = true;
            }
            else
            {
                终端设置ToolStripMenuItem.Visible = false;
            }

            if (App.userGights.Contains("菜品管理"))
            {
                菜品ToolStripMenuItem.Visible = true;
                
            }
            else
            {
                菜品ToolStripMenuItem.Visible = false;
                tcMain.TabPages.Remove(pageFood);
            }

            if (App.userGights.Contains("餐桌设置"))
            {
                餐桌设置ToolStripMenuItem.Visible = true;
            }
            else
            {
                餐桌设置ToolStripMenuItem.Visible = false;
            }

            if (App.userGights.Contains("打印设置"))
            {
                打印设置ToolStripMenuItem.Visible = true;
            }
            else
            {
                打印设置ToolStripMenuItem.Visible = false;
            }

        }
        private void InitTabEnvs()
        {
            tcTabs.TabPages.Clear();
            List<yoogacatering.Entity.TableEnv> envs = TabEnvService.GetAllEnv();
            for (int i = 0; i < envs.Count; i++)
            {
                TableEnv te = envs[i];
                TabPage page = new TabPage();
                page.Text = te.tabEnvName;
                tcTabs.TabPages.Add(page);
            }
        }
        private void InitBaseInfo(string tabName)
        {
            lbName.Text = string.Format("{0} 餐桌：{1}",tcTabs.SelectedTab.Text,tabName);
            string billkey = BillInfoService.GetNotCheckOutBillkeyByTabName(tabName);
            if (billkey != "")
            {
                BillInfoService service = new BillInfoService();
                BillInfo bill = service.GetBillInfoByBillkey(BillInfoService.GetNotCheckOutBillkeyByTabName(tabName));
                lbOpenTime.Text = string.Format("开台时间：{0}", bill.billtime.Substring(11));
                //lbOpenPretage.Text = string.Format("开台率：{0}","10%");
                lbCustCount.Text = string.Format("用餐人数：{0}", bill.custCount + "人");
                //lbMoney.Text = string.Format("总消费额：{0}", bill.billMoney + "元");
            }
            else
            {
                lbOpenTime.Text = string.Format("开台时间：{0}", "00:00:00");
                //lbOpenPretage.Text = string.Format("开台率：{0}","10%");
                lbCustCount.Text = string.Format("用餐人数：{0}", "0人");
                //lbMoney.Text = string.Format("总消费额：{0}", "0元");
            }
        }

        private void InitBillDetailInfo(string tabName)
        {
            dvFood.Rows.Clear();
            BillDetailInfoService service = new BillDetailInfoService();
            string billkey = BillInfoService.GetNotCheckOutBillkeyByTabName(tabName);
            List<BillDetailInfo> billDetailInfos = service.GetBillDetailInfoByBillkey(billkey);
            foreach (BillDetailInfo b in billDetailInfos)
            {
                dvFood.Rows.Add(0,b.FoodCnName,b.foodCount,b.FoodPrice);
            }
        }
        void lb_MouseEnter(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.BackColor = Color.LightCoral;
        }
        void lb_MouseLeave(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.BackColor = Color.LightGreen;
        }

        private bool ValidLB(Label lb)
        {
            if (lb.BackColor == Color.LightGreen)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void lb_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            string tabName = lb.Text;
            this.tabName = tabName;
            InitBaseInfo(tabName);
            InitBillDetailInfo(tabName);

            TabInfoService service = new TabInfoService();
            string tabStatus = TabInfoService.GetTabStatusByTabName(tabName);
            switch (tabStatus)
            {
                case "空闲":
                    if (App.userGights.Contains("点餐"))
                    {
                        lbUserTab.BackColor = Color.LightGreen;
                        lbOrder.BackColor = Color.Gray;
                        lbCheckout.BackColor = Color.Gray;
                        lbChangeTab.BackColor = Color.Gray;
                        lbReset.BackColor = Color.Gray;
                    }
                    else
                    {
                        lbUserTab.BackColor = Color.Gray;
                        lbOrder.BackColor = Color.Gray;
                        lbCheckout.BackColor = Color.Gray;
                        lbChangeTab.BackColor = Color.Gray;
                        lbReset.BackColor = Color.Gray;
                    }
                    break;
                case "开台":
                case "点餐":
                case "加餐":
                    if (App.userGights.Contains("点餐"))
                    {
                        lbUserTab.BackColor = Color.Gray;
                        lbOrder.BackColor = Color.LightGreen;
                        lbCheckout.BackColor = Color.LightGreen;
                        lbChangeTab.BackColor = Color.LightGreen;
                        lbReset.BackColor = Color.Gray;
                    }
                    else
                    {
                        lbUserTab.BackColor = Color.Gray;
                        lbOrder.BackColor = Color.Gray;
                        lbCheckout.BackColor = Color.Gray;
                        lbChangeTab.BackColor = Color.Gray;
                        lbReset.BackColor = Color.Gray;
                    }
                    break;

                case "结账":
                    if (App.userGights.Contains("收银"))
                    {
                        lbUserTab.BackColor = Color.Gray;
                        lbOrder.BackColor = Color.Gray;
                        lbCheckout.BackColor = Color.Gray;
                        lbChangeTab.BackColor = Color.Gray;
                        lbReset.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        lbUserTab.BackColor = Color.Gray;
                        lbOrder.BackColor = Color.Gray;
                        lbCheckout.BackColor = Color.Gray;
                        lbChangeTab.BackColor = Color.Gray;
                        lbReset.BackColor = Color.Gray;
                    }
                    break;
                default:
                    break;
            }
        }

        private void UpdateTabs()
        {
            TabPage page = tcTabs.SelectedTab;
            foreach (Control ctl in page.Controls)
            {
                if (ctl is Label)
                {
                    string tabName = ctl.Text;
                    string status = TabInfoService.GetTabStatusByTabName(tabName);
                    switch (status)
                    {
                        case "空闲":
                            ctl.BackColor = Color.LightGreen;
                            break;
                        case "开台":
                        case "点餐":
                        case "加餐":
                            ctl.BackColor = Color.Red;
                            break;
                        case "结账":
                            ctl.BackColor = Color.Blue;
                            break;
                        default:
                            ctl.BackColor = Color.LightGreen;
                            break;
                    }
                }
            }
        }
        private void InitTabs()
        {
            foreach (TabPage page in tcTabs.TabPages)
            {
                int width = page.Width;
                int height = page.Height;
                int lbWidth = width / 12;
                int lbHeight = height / 8;
                String envName = page.Text.Trim();
                TabInfoService service = new TabInfoService();
                List<TabInfo> tabs = service.GetAllTabsByEnvName(envName);
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        int cco = i * 6 + j;
                        
                        if (cco < tabs.Count)
                        {
                            TabInfo tab = tabs[cco];
                            if (tab == null)
                                return;
                            Label lb = new Label();
                            lb.Text = tab.tabName;
                            lb.ForeColor = Color.White;
                            
                            lb.TextAlign = ContentAlignment.MiddleCenter;
                            lb.BorderStyle = BorderStyle.FixedSingle;
                            //lb.AutoSize = false;
                            lb.Size = new Size(lbWidth, lbHeight);
                            lb.ContextMenuStrip = ops;
                            lb.Click += new EventHandler(lb_Click);
                            //lb.MouseEnter += new EventHandler(lb_MouseEnter);
                            //lb.MouseLeave += new EventHandler(lb_MouseLeave);
                            lb.Location = new Point(10 + j * width / 10, 15 + i * height / 6);
                            page.Controls.Add(lb);
                            switch (tab.status)
                            {
                                case "空闲":
                                    lb.BackColor = Color.LightGreen;
                                    break;
                                case "开台":
                                case "点餐":
                                case "加餐":
                                    lb.BackColor = Color.Red;
                                    break;
                                case "结账":
                                    lb.BackColor = Color.Blue;
                                    break;
                                default:
                                    lb.BackColor = Color.LightGreen;
                                    break;
                            }
                        }
                    }
                }
            }
        }


        private void lbRefresh_Click(object sender, EventArgs e)
        {
            InitTabEnvs();
            InitTabs();
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tcMain.TabPages.Remove(tcMain.SelectedTab);
        }

        private void 餐桌设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTabs ft = new FormTabs();
            ft.ShowDialog();
        }

        private void 开台ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Label lb = (Label)ops.SourceControl;
                string envName = tcTabs.SelectedTab.Text.Trim();
                string tabName = lb.Text;
                FormOpen fo = new FormOpen(tabName, envName);
                DialogResult res = fo.ShowDialog();
                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    lb.BackColor = Color.Red;
                }
            }
            catch { }
        }

        private void tcTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 计算开台率
            try
            {
                TabInfoService service = new TabInfoService();
                List<TabInfo> tabs = service.GetAllTabsByEnvName(tcTabs.SelectedTab.Text.Trim());
                if (tabs.Count == 0)
                {
                    lbOpenPretage.Text = string.Format("开台率：{0}", "0.00%");
                }
                else
                {
                    int count = 0;
                    foreach (TabInfo tab in tabs)
                    {
                        if (tab.status != "空闲")
                        {
                            count++;
                        }
                    }
                    lbOpenPretage.Text = string.Format("开台率：{0}", ((double)count/(double)tabs.Count).ToString("P"));
                }
            }
            catch { }
        }

        private void lbUserTab_Click(object sender, EventArgs e)
        {
            if (tabName == "")
            {
                MessageBox.Show("请先选择要开台的餐桌");
            }
            else
            {
                if (ValidLB((Label)sender))
                {
                    string envName = tcTabs.SelectedTab.Text.Trim();
                    FormOpen fo = new FormOpen(tabName, envName);
                    DialogResult res = fo.ShowDialog();
                    if (res == System.Windows.Forms.DialogResult.OK)
                    {
                        UpdateTabs();
                    }
                }
            }
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage page = tcMain.SelectedTab;
            switch (page.Text)
            {
                case "菜品管理":
                    InitTvFoodCate();
                    InitFood();

                    break;
                case "操作员管理":
                    InitOpers();
                    cbOperSex.SelectedIndex = 0;
                    break;
                default:
                    break;
            }
        }
        
        private void InitFood()
        {
            dvAllFood.Rows.Clear();
            FoodService service = new FoodService();
            List<Food> foods = service.GetAllFood();
            foreach (Food food in foods)
            {
                dvAllFood.Rows.Add(food.foodid,food.cnName,food.enName,food.des,food.price,food.category,food.canDiscount,food.status,food.unit,food.isPlan,food.createTime,food.updateTime,food.imageUpdateTime,food.delTime,food.needKC,food.needMaterials);
            }
            SearchFoodByName();
        }
        private void SearchFoodByName()
        {
            dvAllFood.Rows.Clear();
            string searchStr = tbFoodSearchStr.Text.Trim();
            FoodService service = new FoodService();
            List<Food> foods = service.GetAllFoodByName(searchStr);
            foreach (Food food in foods)
            {
                dvAllFood.Rows.Add(food.foodid, food.cnName, food.enName, food.des, food.price, food.category, food.canDiscount, food.status, food.unit, food.isPlan, food.createTime, food.updateTime, food.imageUpdateTime, food.delTime, food.needKC, food.needMaterials);
            }
        }
        private void SearchFood(string category)
        {
            dvAllFood.Rows.Clear();
            FoodService service = new FoodService();
            List<Food> foods = service.GetAllFoodByCategory(category);
            foreach (Food food in foods)
            {
                dvAllFood.Rows.Add(food.foodid, food.cnName, food.enName, food.des, food.price, food.category, food.canDiscount, food.status, food.unit, food.isPlan, food.createTime, food.updateTime, food.imageUpdateTime, food.delTime, food.needKC, food.needMaterials);
            }
        }
        private void InitTvFoodCate()
        {
            tvFoodCate.Nodes.Clear();
            TreeNode node0 = new TreeNode("厨房");
            tvFoodCate.Nodes.Add(node0);
            FoodCategoryService service = new FoodCategoryService();
            List<FoodCategory> categorys = service.GetAllCategoryByBelong("厨房");
            foreach (FoodCategory cate in categorys)
            {

                node0.Nodes.Add(new TreeNode(cate.categoryName));
            }
            node0.Expand();
            categorys = service.GetAllCategoryByBelong("酒吧");
            TreeNode node1 = new TreeNode("酒吧");
            tvFoodCate.Nodes.Add(node1);
            foreach (FoodCategory cate in categorys)
            {

                node1.Nodes.Add(new TreeNode(cate.categoryName));
            }
            node1.Expand();
        }
        private void tvFoodCate_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            string category = e.Node.Text;
            if (category.Equals("厨房") || category.Equals("酒吧"))
            {
                FoodCategoryService service = new FoodCategoryService();
                List<FoodCategory> categorys = service.GetAllCategoryByBelong(category);
                TreeNode node = tvFoodCate.SelectedNode;
                node.Nodes.Clear();
                foreach (FoodCategory cate in categorys)
                {

                    node.Nodes.Add(new TreeNode(cate.categoryName));
                }
                node.Expand();
            }
            else 
            {
                SearchFood(category);
            }
        }

        private void 新增分类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddCategory fc = new FormAddCategory();
            if (fc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                InitTvFoodCate();
            }
        }

        private void 删除分类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = tvFoodCate.SelectedNode;
            string category = node.Text;
            if (category.Equals("厨房") || category.Equals("酒吧"))
            {
                MessageBox.Show("非法操作！");
            }
            else 
            {
                FoodCategoryService service = new FoodCategoryService();
                service.DelCategory(category);
                InitTvFoodCate();
            }
        }

        private void 新增商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddFood ff = new FormAddFood();
            if (ff.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                InitFood();
            }
        }

        private void tbFoodSearchStr_TextChanged(object sender, EventArgs e)
        {
            SearchFoodByName();
        }

        private void dvAllFood_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int id = Convert.ToInt32(dvAllFood.Rows[index].Cells["id"].Value);
            FormUpdateFood fu = new FormUpdateFood(id);
            DialogResult res = fu.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                InitFood();
            }
        }

        private void lbOrder_Click(object sender, EventArgs e)
        {
            if (tabName != "")
            {
                if (ValidLB((Label)sender))
                {

                    FormOrder fo = new FormOrder(tabName);
                    fo.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("请选择需要点菜的餐桌");
            }
        }

        private void lbCheckout_Click(object sender, EventArgs e)
        {
            if (tabName != "")
            {
                if (ValidLB((Label)sender))
                {
                    FormCheckout fc = new FormCheckout(BillInfoService.GetNotCheckOutBillkeyByTabName(tabName), tabName);
                    if (fc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        UpdateTabs();
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择需要结账的餐桌");
            }
        }

        private void lbChangeTab_Click(object sender, EventArgs e)
        {
            if (tabName != "")
            {
                if (ValidLB((Label)sender))
                {
                    FormChangeTab fc = new FormChangeTab(tabName);
                    if (fc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        UpdateTabs();
                    }

                    // 打印换桌小票 TODO
                }
            }
            else
            {
                MessageBox.Show("请选择需要换桌的餐桌");
            }
        }

        private void lbReset_Click(object sender, EventArgs e)
        {
            if (tabName != "")
            {
                if (ValidLB((Label)sender))
                {
                    TabInfoService service = new TabInfoService();
                    service.UpdateTabInfoStatus(tabName, "空闲");
                    UpdateTabs();
                }
            }
            else
            {
                MessageBox.Show("请选择需要换桌的餐桌");
            }
        }


        #region 操作员管理
        private void InitOpers()
        {
            dvOpers.Rows.Clear();
            OpersService service = new OpersService();
            List<Opers> opers = service.GetAllOpers();
            foreach (Opers o in opers)
            {
                string grantRight = "";
                foreach (string str in o.openGrantRigts)
                {
                    grantRight += (str + ",");
                }
                string noGrantRight = "";
                foreach (string str in o.openNotGrantGights)
                {
                    noGrantRight += (str + ",");
                }
                dvOpers.Rows.Add(o.id, o.operPws, o.operName, o.operID, o.operSex, o.operPos, grantRight, noGrantRight);
            }
        }
        
        private void searOpers()
        {
            dvOpers.Rows.Clear();
            string operid = tbOperOpenID.Text.Trim();
            string operName = tbOperName.Text.Trim();
            string operPos = cbOperPos.Text.Trim() == "全部" ? "" : cbOperSex.Text.Trim();
            string operSex = cbOperSex.Text.Trim() == "全部" ? "" : cbOperSex.Text.Trim();
            OpersService service = new OpersService();
            List<Opers> opers = service.SearchOpers(operid, operName, operPos, operSex);
            foreach (Opers o in opers)
            {
                string grantRight = "";
                foreach (string str in o.openGrantRigts)
                {
                    grantRight += (str + ",");
                }
                string noGrantRight = "";
                foreach (string str in o.openNotGrantGights)
                {
                    noGrantRight += (str + ",");
                }
                dvOpers.Rows.Add(o.id, o.operPws, o.operName, o.operID, o.operSex, o.operPos, grantRight, noGrantRight);
            }
        }
        private void tbOperName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                searOpers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbAddOpers_Click(object sender, EventArgs e)
        {
            FormOpers fo = new FormOpers(0,0);
            if (fo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                InitOpers();
            }
        }

        private void dvOpers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dvOpers.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["operid"].Value);
                FormOpers fo = new FormOpers(1, id);
                if (fo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    InitOpers();
                }
            }
            catch { }
        }

        private void lbDelOpers_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dvOpers.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["operid"].Value);
                string name = row.Cells["opername"].Value.ToString();
                DialogResult res = MessageBox.Show("确定删除["+name+"]吗?","删除确认",MessageBoxButtons.OKCancel);
                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    OpersService service = new OpersService();
                    service.DelOpers(id);
                    InitOpers();
                }
            }
            catch 
            {
                MessageBox.Show("请先选中要删除的操作员信息");
            }

        }

        private void cbOperSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            searOpers();
        }

        private void tbOperOpenID_TextChanged(object sender, EventArgs e)
        {
            searOpers();
        }

        private void cbOperPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            searOpers();
        }
        #endregion

        private void 消费ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tcMain.SelectedIndex = 0;
        }

        private void 菜品管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tcMain.SelectedIndex = 1;
        }

        private void 操作员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tcMain.SelectedIndex = 2;
        }

        private void 交班ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShift fs = new FormShift();
            fs.ShowDialog();
        }

        private void 日结ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDay fd = new FormDay();
            fd.ShowDialog();
        }

        private void lbQuery_Click(object sender, EventArgs e)
        {
            string billkey = tbBillkey.Text.Trim();
            string dtb = dtcheckbegin.Value.ToString("yyyy-MM-dd 00:00:00");
            string dte = dtcheckend.Value.ToString("yyyy-MM-dd 00:00:00");

            BillInfoService service = new BillInfoService();

            dvAllBill.Rows.Clear();
            List<BillInfo> bills = service.GetBillInfosByBillkeyAndChecktime(billkey,dtb,dte);
            foreach (BillInfo b in bills)
            {
                dvAllBill.Rows.Add(b.billKey,b.tabName,b.billMoney,b.paymethod,b.SHmoney,b.SHcash,b.SHvesa,b.billtime,b.checktime,b.checkUsername,b.custCount,b.discount);
            }

        }

        private void lbImport_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("账单号");
            DataColumn dc2 = new DataColumn("餐桌号");
            DataColumn dc3 = new DataColumn("账单金额");
            DataColumn dc4 = new DataColumn("结账方式");
            DataColumn dc5 = new DataColumn("实收金额");
            DataColumn dc6 = new DataColumn("实收现金");
            DataColumn dc7 = new DataColumn("实收刷卡");
            DataColumn dc8 = new DataColumn("开台时间");
            DataColumn dc9 = new DataColumn("结账时间");
            DataColumn dc10 = new DataColumn("收银员");
            DataColumn dc11 = new DataColumn("顾客人数");
            DataColumn dc12 = new DataColumn("折扣");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);
            dt.Columns.Add(dc6);
            dt.Columns.Add(dc7);
            dt.Columns.Add(dc8);
            dt.Columns.Add(dc9);
            dt.Columns.Add(dc10);
            dt.Columns.Add(dc11);
            dt.Columns.Add(dc12);
            foreach (DataGridViewRow row in dvAllBill.Rows)
            {
                dt.Rows.Add(row.Cells["billKey"].Value.ToString(),
                    row.Cells["billtabName"].Value.ToString(),
                    row.Cells["billMoney"].Value.ToString(),
                    row.Cells["paymethod"].Value.ToString(),
                    row.Cells["SHmoney"].Value.ToString(),
                    row.Cells["SHcash"].Value.ToString(),
                    row.Cells["SHvesa"].Value.ToString(),
                    row.Cells["billtime"].Value.ToString(),
                    row.Cells["checktime"].Value.ToString(),
                    row.Cells["checkUsername"].Value.ToString(),
                    row.Cells["custCount"].Value.ToString(),
                    row.Cells["discount"].Value.ToString());
            }

            Utils.WriteToExcel(dt,"");
        }

        private void lbCount_Click(object sender, EventArgs e)
        {
            string dtb = dtFoodBegin.Value.ToString("yyyy-MM-dd 00:00:00");
            string dte = dtFoodEnd.Value.ToString("yyyy-MM-dd 00:00:00");
            FoodService service = new FoodService();
            DataTable dt = service.CountFood(dtb,dte);
            dvFoodcount.DataSource = dt;

        }

        private void 打印设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrintSetting fp = new FormPrintSetting();
            fp.ShowDialog();
        }

        private void billTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                billTimer.Stop();

                Padorder order = CommService.GetLastNotPrintPadorder();
                if (order != null)
                {
                    BillInfoService bService = new BillInfoService();
                    BillInfo billinfo = bService.GetBillInfoByBillkey(order.billkey);

                    BillDetailInfoService dService = new BillDetailInfoService();
                    List<BillDetailInfo> bills = dService.GetBillDetailInfoByBillkey(order.billkey);

                    //List<BillDetailInfo> AllDetailInfos = new List<BillDetailInfo>();
                    List<BillDetailInfo> KitchenDetailInfos = new List<BillDetailInfo>();
                    List<BillDetailInfo> BarDetailInfos = new List<BillDetailInfo>();

                    foreach (BillDetailInfo bd in bills)
                    {
                        if (bd.isPrint == 1)
                            break;
                        if (FoodService.IsPlanFood(bd.FoodCnName))
                        {
                            PlanFoodService pService = new PlanFoodService();
                            List<PlanFood> planFoods = pService.GetPlanFood(bd.FoodCnName);
                            foreach (PlanFood f in planFoods)
                            {
                                BillDetailInfo pdInfo = new BillDetailInfo();
                                pdInfo.BillKey = order.billkey;
                                pdInfo.FoodCnName = f.planFoodname;
                                pdInfo.foodCount = f.planFoodCount;
                                pdInfo.FoodID = 0;
                                pdInfo.FoodPrice = f.planFoodPrice;
                                pdInfo.FoodUnit = f.planFoodUnit;
                                pdInfo.Handsel = "否";
                                pdInfo.isPrint = 0;
                                pdInfo.jiaocai = order.jiaocai;
                                pdInfo.remark = "";
                                pdInfo.Mark = "";
                                pdInfo.Stauts = "已点菜";
                                pdInfo.Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                pdInfo.UserName = App.userName;

                                if (FoodService.IsKitchenFood(f.planFoodname))
                                {
                                    KitchenDetailInfos.Add(pdInfo);
                                }
                                else
                                {
                                    BarDetailInfos.Add(pdInfo);
                                }
                            }

                        }

                        else
                        {
                            if (FoodService.IsKitchenFood(bd.FoodCnName))
                            {
                                KitchenDetailInfos.Add(bd);
                            }
                            else
                            {
                                BarDetailInfos.Add(bd);
                            }
                        }
                    }


                    // 打印

                    TabInfoService tabService = new TabInfoService();
                    TabInfo tabInfo = tabService.GetTabInfoByTabName(order.tabname);

                    // 打印账单
                    if (bills.Count <= 0)
                        return;
                    string tabStatus = tabInfo.status;
                    if (tabStatus.Equals("开台"))
                    {
                        ConsumeBillPrinter conPrinter = new ConsumeBillPrinter(billinfo, "点餐单", bills);
                        conPrinter.pdDocument.Print();

                        if (KitchenDetailInfos.Count > 0)
                        {
                            KitchenBillPrinter kitPrinter = new KitchenBillPrinter(billinfo, "点餐单", KitchenDetailInfos);
                            kitPrinter.pdDocument.Print();

                            foreach (BillDetailInfo d in KitchenDetailInfos)
                            {
                                KitchenBillDetailPrinter kitDetailPrinter = new KitchenBillDetailPrinter(d, tabName, "后厨点菜单");
                                kitDetailPrinter.pdDocument.Print();
                                BillDetailInfoService.UpdatePrintByID(d.ID);
                            }
                        }

                        if (BarDetailInfos.Count > 0)
                        {
                            BarBillPrinter barPrinter = new BarBillPrinter(billinfo, "点餐单", BarDetailInfos);
                            barPrinter.pdDocument.Print();

                            foreach (BillDetailInfo d in BarDetailInfos)
                            {
                                BarBillDetailPrinter barDetailPrinter = new BarBillDetailPrinter(d, tabName, "酒吧点菜单");
                                barDetailPrinter.pdDocument.Print();

                                BillDetailInfoService.UpdatePrintByID(d.ID);
                            }
                        }

                    }
                    else
                    {
                        ConsumeBillPrinter conPrinter = new ConsumeBillPrinter(billinfo, "加菜单", bills);
                        conPrinter.pdDocument.Print();

                        if (KitchenDetailInfos.Count > 0)
                        {
                            KitchenBillPrinter kitPrinter = new KitchenBillPrinter(billinfo, "加餐单", KitchenDetailInfos);
                            kitPrinter.pdDocument.Print();

                            foreach (BillDetailInfo d in KitchenDetailInfos)
                            {
                                KitchenBillDetailPrinter kitDetailPrinter = new KitchenBillDetailPrinter(d, tabName, "后厨加菜单");
                                kitDetailPrinter.pdDocument.Print();
                                BillDetailInfoService.UpdatePrintByID(d.ID);
                            }
                        }

                        if (BarDetailInfos.Count > 0)
                        {
                            BarBillPrinter barPrinter = new BarBillPrinter(billinfo, "加餐单", BarDetailInfos);
                            barPrinter.pdDocument.Print();

                            foreach (BillDetailInfo d in BarDetailInfos)
                            {
                                BarBillDetailPrinter barDetailPrinter = new BarBillDetailPrinter(d, tabName, "酒吧加菜单");
                                barDetailPrinter.pdDocument.Print();

                                BillDetailInfoService.UpdatePrintByID(d.ID);
                            }
                        }
                    }

                    // 1 收银打印 总单 （点餐单或者加餐单）

                    // 2 后厨打印总单+分单 （点餐单或者加餐单）

                    // 3 酒吧打印总单+分单 （点餐单或者加餐单）
                    if (tabInfo.status.Equals("开台"))
                    {
                        tabService.UpdateTabInfoStatus(tabName, "点餐");
                    }
                    else
                    {
                        tabService.UpdateTabInfoStatus(tabName, "加餐");
                    }

                    BillInfoService.UpdateBillIsPrintByBillkey(order.billkey);
                    CommService.SetPadorderPrinted(order.id);
                }


                // 设置次order 已经打印
                
                billTimer.Start();
            }
            catch (Exception ex)
            {
                billTimer.Start();
                MessageBox.Show(ex.Message);
            }
        }

    }
}
