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
    public partial class FormAddTab : Form
    {
        public string envName { set; get; }
        public FormAddTab(string envName)
        {
            InitializeComponent();
            this.envName = envName;
        }

        private void FormAddTab_Load(object sender, EventArgs e)
        {
            List<TableEnv> envs = TabEnvService.GetAllEnv();
            foreach (TableEnv env in envs)
            {
                cbEnv.Items.Add(env.tabEnvName);
            }
            cbEnv.Text = envName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string envName = cbEnv.Text.Trim();
            string tabName = tbTabName.Text.Trim();
            if (tabName == "" || envName == "")
            {
                MessageBox.Show("餐桌名称和餐桌环境不能为空");
            }
            else
            {
                TabInfo tab = new TabInfo();
                tab.billkey = "";
                tab.checkTime = "";
                tab.createTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                tab.custCount = 0;
                tab.envName = envName;
                tab.startTime = "";
                tab.status = "空闲";
                tab.tabName = tabName;
                TabInfoService.AddTabInfo(tab);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
