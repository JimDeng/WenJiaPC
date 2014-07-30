using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using yoogacatering.Entity;
using yoogacatering.Printer;
using yoogacatering.Service;
using yoogacatering.Utils;

namespace yoogacatering
{
    public partial class FormOrder : Form
    {
        public string tabName { set; get; }
        public FormOrder(string tabName)
        {
            InitializeComponent();
            this.tabName = tabName;
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tabFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchFood();
        }
        private void CalcBillMoney()
        {
            float sum = 0.0f;
            foreach (DataGridViewRow row in dvBill.Rows)
            {
                float foodprice = float.Parse(row.Cells["foodprice"].Value.ToString());
                int foodcount = Convert.ToInt32((row.Cells["foodcount"].Value.ToString()));
                sum += (foodcount * foodprice);
            }

            lbBillMoney.Text = string.Format("消费：￥{0}元",sum);
        }
        private void InitBillInfo()
        {
            dvBill.Rows.Clear();
            string billkey = BillInfoService.GetNotCheckOutBillkeyByTabName(tabName);
            BillDetailInfoService service = new BillDetailInfoService();
            List<BillDetailInfo> billDetailInfos = service.GetBillDetailInfoByBillkey(billkey);
            foreach (BillDetailInfo dInfo in billDetailInfos)
            {
                //dvBill.Rows.Add("未确认", lb.Text, 1, food.price, food.unit, "", "否", "否", "否", "");
                dvBill.Rows.Add(dInfo.Stauts,dInfo.FoodCnName,dInfo.foodCount,dInfo.FoodPrice,dInfo.FoodUnit,dInfo.remark,dInfo.jiaocai,dInfo.Mark,dInfo.Handsel,dInfo.Mark,dInfo.ID);
            }
        }

        private void JudgeRights()
        {
            if (App.userGights.Contains("赠送"))
            {
                lbGive.BackColor = Color.Black;
            }
            else
            {
                lbGive.BackColor = Color.Gray;
            }

            if (App.userGights.Contains("退菜"))
            {
                lbRetreat.BackColor = Color.Black;
            }
            else
            {
                lbRetreat.BackColor = Color.Gray;
            }
        }
        private void FormOrder_Load(object sender, EventArgs e)
        {

            JudgeRights();
            lbTabInfo.Text = ("餐桌号--" + tabName);

            // 查询是否有账单信息 加载账单信息
            InitBillInfo();
            CalcBillMoney();
            FoodCategoryService service = new FoodCategoryService();
            List<FoodCategory> categorys = service.GetAllCategory();
            FoodService foodService = new FoodService();
            foreach (FoodCategory c in categorys)
            {
                TabPage page = new TabPage();
                page.Text = c.categoryName;
                List<Food> foods = foodService.GetAllFoodByCategory(c.categoryName);
                int width = tabCategory.Width;
                int height = tabCategory.Height;
                int lbWidth = width / 9;
                int lbHeight = height / 12;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        int cco = i * 8 + j;
                        if (cco < foods.Count)
                        {
                            Label lb = new Label();
                            lb.Text = foods[cco].cnName;
                            lb.Tag = foods[cco].foodid;
                            lb.ForeColor = Color.White;
                            lb.BackColor = Color.LightGreen;
                            lb.TextAlign = ContentAlignment.MiddleCenter;
                            lb.BorderStyle = BorderStyle.FixedSingle;
                            //lb.AutoSize = false;
                            lb.Size = new Size(lbWidth, lbHeight);
                            lb.Location = new Point(10 + j * (int)(width / 8.2), 15 + i * height / 9);
                            lb.Click += lb_Click;
                            page.Controls.Add(lb);
                        }
                    }
                }
                
                tabCategory.TabPages.Add(page);
            }

        }

        void lb_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            Food food = new FoodService().GetFoodById(Convert.ToInt32(lb.Tag));
            dvBill.Rows.Add("未确认",lb.Text,1,food.price,food.unit,"","否","否","否","",0);
            CalcBillMoney();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            SearchFood();
        }

        private void SearchFood()
        {
            FoodService service = new FoodService();
            List<Food> foods = service.GetAllFoodByName(tbSearch.Text.Trim());
            {
                pnFood.Controls.Clear();
                int width = tabCategory.Width;
                int height = tabCategory.Height;
                int lbWidth = width / 9;
                int lbHeight = height / 12;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        int cco = i * 8 + j;
                        if (cco > 64)
                            return;
                        if (cco < foods.Count)
                        {
                            Label lb = new Label();
                            lb.Text = foods[cco].cnName;
                            lb.Tag = foods[cco].foodid;
                            lb.ForeColor = Color.White;
                            lb.BackColor = Color.LightGreen;
                            lb.TextAlign = ContentAlignment.MiddleCenter;
                            lb.BorderStyle = BorderStyle.FixedSingle;
                            //lb.AutoSize = false;
                            lb.Size = new Size(lbWidth, lbHeight);
                            lb.Location = new Point(10 + j * (int)(width / 8.2), 5 + i * height / 9);
                            lb.Click += lb_Click;
                            pnFood.Controls.Add(lb);
                        }
                    }
                }
            }
        }

        private void lbAdd_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            if (lb.BackColor == Color.Black)
            {
                try
                {
                    DataGridViewRow row = dvBill.SelectedRows[0];
                    row.Cells["foodcount"].Value = (Convert.ToInt32(row.Cells["foodcount"].Value) + 1);
                    CalcBillMoney();
                }
                catch { }
            }
        }

        private void lbPlus_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            if (lb.BackColor == Color.Black)
            {
                try
                {
                    DataGridViewRow row = dvBill.SelectedRows[0];
                    int foodcount = Convert.ToInt32(row.Cells["foodcount"].Value);
                    foodcount = foodcount - 1;
                    if(foodcount==0)
                    {
                        dvBill.Rows.Remove(row);
                    }
                    else
                    {
                        row.Cells["foodcount"].Value = foodcount;
                    }
                    CalcBillMoney();
                }
                catch { }
            }
        }

        private void lbDel_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            if (lb.BackColor == Color.Black)
            {
                try
                {
                    dvBill.Rows.Remove(dvBill.SelectedRows[0]);
                    CalcBillMoney();
                }
                catch { }
            }
        }

        private void dvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dvBill.SelectedRows[0];
                string status = row.Cells["status"].Value.ToString();
                if (status == "未确认")
                {
                    lbAdd.BackColor = Color.Black;
                    lbPlus.BackColor = Color.Black;
                    lbDel.BackColor = Color.Black;
                    lbJQOnly.BackColor = Color.Black;
                    lbCook.BackColor = Color.Black;
                    
                }
                else
                {
                    lbAdd.BackColor = Color.Gray;
                    lbPlus.BackColor = Color.Gray;
                    lbDel.BackColor = Color.Gray;
                    lbJQOnly.BackColor = Color.Gray;
                    lbCook.BackColor = Color.Gray;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateColor()
        {
            foreach (DataGridViewRow row in dvBill.Rows)
            {
                if (row.Cells["give"].Value.ToString().Equals("是"))
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        private void dvBill_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

        }

        private void lbJQOnly_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            if (lb.BackColor == Color.Black)
            {
                try
                {
                    DataGridViewRow row = dvBill.SelectedRows[0];
                    row.Cells["hold"].Value = "是";
                    CalcBillMoney();
                }
                catch { }
            }
        }

        private void lbGive_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbGive.BackColor == Color.Black)
                {
                    DataGridViewRow row = dvBill.SelectedRows[0];
                    string status = row.Cells["status"].Value.ToString();
                    if (status.Equals("未确认"))
                    {
                        row.Cells["give"].Value = "是";
                    }
                    else
                    {
                        int id = Convert.ToInt32(row.Cells["id"].Value);
                        BillDetailInfoService.UpdateForGiveByID(id);
                        row.Cells["give"].Value = "是";
                    }

                    CalcBillMoney();
                }
            }
            catch { }
        }

        private void lbRetreat_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbRetreat.BackColor == Color.Black)
                {
                    DataGridViewRow row = dvBill.SelectedRows[0];
                    row.Cells["retreat"].Value = "是";
                    row.Cells["mark"].Value += string.Format("{0}-{1}退菜", DateTime.Now.ToString("HH:mm"), App.userName);
                    row.Cells["foodcount"].Value = 0;
                    CalcBillMoney();
                }
            }
            catch { }
        }

        private void lbOrder_Click(object sender, EventArgs e)
        {
            
            
            
            string billkey = BillInfoService.GetNotCheckOutBillkeyByTabName(tabName);
            BillInfoService bService = new BillInfoService();
            BillInfo billInfo = bService.GetBillInfoByBillkey(billkey);
            BillDetailInfoService service = new BillDetailInfoService();

            List<BillDetailInfo> AllDetailInfos = new List<BillDetailInfo>();
            List<BillDetailInfo> KitchenDetailInfos = new List<BillDetailInfo>();
            List<BillDetailInfo> BarDetailInfos = new List<BillDetailInfo>();

            foreach (DataGridViewRow row in dvBill.Rows)
            {
                if (row.Cells["status"].Value.ToString() == "未确认")
                {
                    BillDetailInfo dinfo = new BillDetailInfo();
                    dinfo.BillKey = billkey;
                    dinfo.FoodCnName = row.Cells["foodname"].Value.ToString();
                    dinfo.foodCount = Convert.ToInt32(row.Cells["foodcount"].Value);
                    dinfo.FoodID = 0;
                    dinfo.FoodPrice = float.Parse(row.Cells["foodprice"].Value.ToString());
                    dinfo.FoodUnit = row.Cells["foodunit"].Value.ToString();
                    dinfo.Handsel = row.Cells["give"].Value.ToString();
                    dinfo.isPrint = 0;
                    dinfo.jiaocai = row.Cells["hold"].Value.ToString();
                    dinfo.remark = row.Cells["cook"].Value.ToString();
                    dinfo.Mark = "";
                    dinfo.Stauts = "已点菜";
                    dinfo.Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    dinfo.UserName = App.userName;
                    int id = service.AddBillDetailInfo(dinfo);
                    dinfo.ID = id;
                    if (FoodService.IsPlanFood(dinfo.FoodCnName))
                    {
                        PlanFoodService pService = new PlanFoodService();
                        List<PlanFood> planFoods = pService.GetPlanFood(dinfo.FoodCnName);
                        AllDetailInfos.Add(dinfo);
                        foreach (PlanFood f in planFoods)
                        {
                            BillDetailInfo pdInfo = new BillDetailInfo();
                            pdInfo.BillKey = billkey;
                            pdInfo.FoodCnName = f.planFoodname;
                            pdInfo.foodCount = f.planFoodCount;
                            pdInfo.FoodID = 0;
                            pdInfo.FoodPrice = f.planFoodPrice;
                            pdInfo.FoodUnit = f.planFoodUnit;
                            pdInfo.Handsel = row.Cells["give"].Value.ToString();
                            pdInfo.isPrint = 0;
                            pdInfo.jiaocai = row.Cells["hold"].Value.ToString();
                            pdInfo.remark = row.Cells["cook"].Value.ToString();
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
                        AllDetailInfos.Add(dinfo);
                        if (FoodService.IsKitchenFood(dinfo.FoodCnName))
                        {
                            KitchenDetailInfos.Add(dinfo);
                        }
                        else
                        {
                            BarDetailInfos.Add(dinfo);
                        }
                    }
                }
            }

            TabInfoService tabService = new TabInfoService();
            TabInfo tabInfo = tabService.GetTabInfoByTabName(tabName);
           
            // 打印账单
            if (AllDetailInfos.Count <= 0)
                return;
            string tabStatus = tabInfo.status;
            if (tabStatus.Equals("开台"))
            {
                ConsumeBillPrinter conPrinter = new ConsumeBillPrinter(billInfo, "点餐单",AllDetailInfos);
                conPrinter.pdDocument.Print();

                if (KitchenDetailInfos.Count > 0)
                {
                    KitchenBillPrinter kitPrinter = new KitchenBillPrinter(billInfo, "点餐单", KitchenDetailInfos);
                    kitPrinter.pdDocument.Print();

                    foreach (BillDetailInfo d in KitchenDetailInfos)
                    {
                        KitchenBillDetailPrinter kitDetailPrinter = new KitchenBillDetailPrinter(d, tabName, "后厨点菜单");
                        kitDetailPrinter.pdDocument.Print();
                    }
                }

                if (BarDetailInfos.Count > 0)
                {
                    BarBillPrinter barPrinter = new BarBillPrinter(billInfo, "点餐单", BarDetailInfos);
                    barPrinter.pdDocument.Print();

                    foreach (BillDetailInfo d in BarDetailInfos)
                    {
                        BarBillDetailPrinter barDetailPrinter = new BarBillDetailPrinter(d, tabName, "酒吧点菜单");
                        barDetailPrinter.pdDocument.Print();
                    }
                }

            }
            else
            {
                ConsumeBillPrinter conPrinter = new ConsumeBillPrinter(billInfo, "加菜单", AllDetailInfos);
                conPrinter.pdDocument.Print();

                if (KitchenDetailInfos.Count > 0)
                {
                    KitchenBillPrinter kitPrinter = new KitchenBillPrinter(billInfo, "加餐单", KitchenDetailInfos);
                    kitPrinter.pdDocument.Print();

                    foreach (BillDetailInfo d in KitchenDetailInfos)
                    {
                        KitchenBillDetailPrinter kitDetailPrinter = new KitchenBillDetailPrinter(d, tabName, "后厨加菜单");
                        kitDetailPrinter.pdDocument.Print();
                    }
                }

                if (BarDetailInfos.Count > 0)
                {
                    BarBillPrinter barPrinter = new BarBillPrinter(billInfo, "加餐单", BarDetailInfos);
                    barPrinter.pdDocument.Print();

                    foreach (BillDetailInfo d in BarDetailInfos)
                    {
                        BarBillDetailPrinter barDetailPrinter = new BarBillDetailPrinter(d, tabName, "酒吧加菜单");
                        barDetailPrinter.pdDocument.Print();
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

            BillInfoService.UpdateBillIsPrintByBillkey(billkey);
            //this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
