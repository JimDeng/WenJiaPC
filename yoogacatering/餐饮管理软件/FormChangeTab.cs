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
    public partial class FormChangeTab : Form
    {
        public string orTabName { set; get; }
        public FormChangeTab(string orTabName)
        {
            InitializeComponent();
            this.orTabName = orTabName;
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void lbOK_Click(object sender, EventArgs e)
        {
            tbOrTabName.Text = orTabName;
            string billkey = BillInfoService.GetNotCheckOutBillkeyByTabName(orTabName);
            BillInfoService service = new BillInfoService();
            BillInfo billInfo = service.GetBillInfoByBillkey(billkey);
            string newTabName = cbNewTabName.Text;

            TabInfoService tService = new TabInfoService();
            string tabStatus = TabInfoService.GetTabStatusByTabName(orTabName);
            // 原餐桌号状态改为空闲
            tService.UpdateTabInfoStatus(orTabName, "空闲");
            // 新餐桌号状态改为原餐桌状态
            tService.UpdateTabInfoStatus(newTabName, tabStatus);
            // 账单对应的餐桌号改为新餐桌号
            billInfo.tabName = newTabName;
            service.UpdateBillInfo(billInfo);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void FormChangeTab_Load(object sender, EventArgs e)
        {
            InitTabs();
        }
        private void InitTabs()
        {
            TabInfoService service = new TabInfoService();
            List<TabInfo> tabs = service.GetAllTabs();
            foreach (TabInfo t in tabs)
            {
                if (t.status.Equals("空闲"))
                {
                    cbNewTabName.Items.Add(t.tabName);
                }
            }
        }
    }
}
