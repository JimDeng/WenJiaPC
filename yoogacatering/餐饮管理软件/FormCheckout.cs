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
    public partial class FormCheckout : Form
    {
        public string billkey { set; get; }
        public string tabName { set; get; }
        public FormCheckout(string billkey,string tabName)
        {
            InitializeComponent();
            this.billkey = billkey;
            this.tabName = tabName;
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void InitCbDiscount()
        {
            DiscountService service = new DiscountService();
            List<DiscountInfo> discounts = service.GetAllDiscountInfo();
            cbDiscount.DisplayMember = "discountName";
            cbDiscount.ValueMember = "discountValue";
            DataTable dt = new DataTable();
            DataColumn dc0 = new DataColumn("discountName");
            DataColumn dc1 = new DataColumn("discountValue");
            dt.Columns.Add(dc0);
            dt.Columns.Add(dc1);
            foreach (DiscountInfo d in discounts)
            {
                dt.Rows.Add(d.discountName,d.discountValue);
            }

            cbDiscount.DataSource = dt;
        }
        private void FormCheckout_Load(object sender, EventArgs e)
        {
            lbBillkey.Text = billkey;
            lbTabName.Text = tabName;

            float allMoney = 0.0f;
            float canDisMoney = 0.0f;
            float preMoney = 0.0f;
            cbPaymethod.SelectedIndex = 0;
            InitCbDiscount();
            BillDetailInfoService service = new BillDetailInfoService();
            List<BillDetailInfo> billDetailInfos = service.GetBillDetailInfoByBillkey(billkey);
            foreach (BillDetailInfo d in billDetailInfos)
            {
                dvBill.Rows.Add(d.FoodCnName,d.foodCount,d.FoodPrice,d.Handsel);
                allMoney += (d.foodCount * d.FoodPrice);
                if (d.Handsel == "是")
                {
                    preMoney += (d.foodCount * d.FoodPrice);
                }
                else
                {
                    if (FoodService.CanDiscount(d.FoodCnName))
                    {
                        canDisMoney += (d.foodCount * d.FoodPrice);
                    }
                }
            }
            lbBillmoney.Text = allMoney + "";
            lbPreMoney.Text = preMoney + "";
            lbDisMoney.Text = canDisMoney + "";

            lbActMoney.Text = (allMoney - preMoney) + "";
            tbSHMoney.Text = (allMoney - preMoney) + "";

        }

        private void tbPre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float pre = float.Parse(tbPre.Text);
                float allMoney = float.Parse(lbBillmoney.Text);
                float preMoney = float.Parse(lbPreMoney.Text);
                lbActMoney.Text = (allMoney - pre - preMoney).ToString();
                tbSHMoney.Text = (allMoney - pre - preMoney).ToString();
            }
            catch
            {
                tbPre.Text = "0";
            }
        }

        private void tbSHMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float shMoney = float.Parse(tbSHMoney.Text);
                float actMoney = float.Parse(lbActMoney.Text);

                float zl = shMoney - actMoney;
                tbZL.Text = zl.ToString();

            }
            catch
            {
                tbSHMoney.Text = "0";
            }
        }

        private void lbCheckout_Click(object sender, EventArgs e)
        {
            CheckOut(1);
        }

        private void CheckOut(int type)
        {
            BillInfoService bService = new BillInfoService();
            BillInfo billInfo = bService.GetBillInfoByBillkey(billkey);
            billInfo.billMoney = float.Parse(lbBillmoney.Text);
            //billInfo.billtime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            billInfo.checktime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            billInfo.checkUsername = App.userName;
            billInfo.discount = cbDiscount.Text;
            billInfo.mark = tbMark.Text.Trim();
            billInfo.paymethod = cbPaymethod.Text;
            if (cbPaymethod.Text.Equals("现金"))
            {
                billInfo.SHcash = float.Parse(tbSHMoney.Text);
            }
            else
            {
                billInfo.SHvesa = float.Parse(tbSHMoney.Text);
            }

            billInfo.SHmoney = float.Parse(tbSHMoney.Text);
            billInfo.status = 1;
            billInfo.tabName = tabName;
            billInfo.zl = float.Parse(tbZL.Text);
            billInfo.preMoney = float.Parse(tbPre.Text);
            float canDisMoney = float.Parse(lbDisMoney.Text);
            float dicValue = float.Parse(cbDiscount.SelectedValue.ToString());
            float disMoney = canDisMoney * (1 - dicValue);
            billInfo.disMoney = disMoney;
            BillInfoService service = new BillInfoService();
            service.UpdateBillInfo(billInfo);

            

            // 打印账单
            BillDetailInfoService dService = new BillDetailInfoService();
            List<BillDetailInfo> billDetailInfos = dService.GetBillDetailInfoByBillkey(billkey);
            CheckoutPrinter printer = new CheckoutPrinter(billInfo, type, billDetailInfos);
            printer.pdDocument.Print();
            if (type == 1)
            {
                TabInfoService tService = new TabInfoService();
                tService.UpdateTabInfoStatus(tabName, "结账");

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void lbPreCheckout_Click(object sender, EventArgs e)
        {
            CheckOut(0);
        }

        private void cbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cbDiscount_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string str = cbDiscount.Text;
                float canDisMoney = float.Parse(lbDisMoney.Text);
                float dicValue = float.Parse(cbDiscount.SelectedValue.ToString());
                float disMoney = canDisMoney * (1-dicValue);
                float actMoney = float.Parse(lbActMoney.Text);
                lbActMoney.Text = (actMoney - disMoney).ToString();
                tbSHMoney.Text = (actMoney - disMoney).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbRunBill_Click(object sender, EventArgs e)
        {
            BillInfoService bService = new BillInfoService();
            BillInfo billInfo = bService.GetBillInfoByBillkey(billkey);
            billInfo.billMoney = float.Parse(lbBillmoney.Text);
            billInfo.status = 2;
            billInfo.checktime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            billInfo.checkUsername = App.userName;
            billInfo.discount = "无";
            billInfo.paymethod = "挂账";
            bService.UpdateBillInfo(billInfo);
            TabInfoService tService = new TabInfoService();
            tService.UpdateTabInfoStatus(tabName, "结账");

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
