using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using yoogacatering.Entity;
using yoogacatering.Service;

namespace yoogacatering
{
    public partial class FormOpen : Form
    {
        private string tabName;
        private string envName;
        public FormOpen(string tabName, string envName)
        {
            InitializeComponent();
            this.tabName = tabName;
            this.envName = envName;
        }

        private void FormOpen_Load(object sender, EventArgs e)
        {
            lbTabName.Text = tabName;
            lbEnvName.Text = envName;
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void lbOpen_Click(object sender, EventArgs e)
        {
            OpenTab();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }


        private void OpenTab()
        {
            string billkey = CommService.GetBillkey();
            BillInfo bill = new BillInfo();
            bill.billKey = billkey;
            bill.billMoney = 0.0f;
            bill.billtime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            bill.cardId = "";
            bill.cardSeriaId = "";
            bill.checktime = "";
            bill.checkUsername = "";
            bill.custCount = (int)nuCustCount.Value;
            bill.discount = "无";
            bill.jiaocai = "";
            bill.mark = "";
            bill.paymethod = "";
            bill.printCount = 0;
            bill.SHcard = 0.0f;
            bill.SHcash = 0.0f;
            bill.SHmoney = 0.0f;
            bill.SHvesa = 0.0f;
            bill.status = 0;
            bill.tabName = lbTabName.Text.Trim();
            bill.vipNo = "";
            bill.zl = 0;
            bill.preMoney = 0.0f;
            BillInfoService service = new BillInfoService();
            try
            {
                service.AddBillInfo(bill);
                TabInfoService.UpdateTabInfoForOpen(tabName);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void lbOpenOrder_Click(object sender, EventArgs e)
        {
            OpenTab();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            FormOrder fr = new FormOrder(tabName);
            fr.ShowDialog();
        }

        private void lbCount_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            string custCount = nuCustCount.Value.ToString();
            string str = lb.Text;
            if (custCount == "0")
            {
                nuCustCount.Value = Convert.ToInt32(str);
            }
            else
            {

                string cc = custCount + str;
                try
                {
                    nuCustCount.Value = Convert.ToInt32(cc);
                }
                catch
                {
                    FormMessage fm = new FormMessage("开台人数超出范围，请重新输入", "开台错误");
                    fm.ShowDialog();
                }
            }
        }

        private void lbDel_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            string custCount = nuCustCount.Value.ToString();
            if (custCount.Length == 1)
            {
                nuCustCount.Value = 0;
            }
            else
            {
                string str = custCount.Substring(0, 1);
                nuCustCount.Value = Convert.ToInt32(str);
            }
        }

        private void lbAdd_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            int count = (int)nuCustCount.Value;
            //if (count > 0)
            {
                nuCustCount.Value = count + 1;
            }

        }

        private void lbPlus_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            int count = (int)nuCustCount.Value;
            if (count > 0)
            {
                nuCustCount.Value = count - 1;
            }
        }
    }
}
