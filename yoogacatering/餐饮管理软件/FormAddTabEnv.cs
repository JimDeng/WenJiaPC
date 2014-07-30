using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using yoogacatering.Service;

namespace yoogacatering
{
    public partial class FormAddTabEnv : Form
    {
        public FormAddTabEnv()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string envName = tbEnvName.Text.Trim();
            if (envName == "")
            {
                FormMessage fm = new FormMessage("请输入就餐环境名称", "提示");
                fm.ShowDialog();
            }
            else
            {
                try
                {
                    TabEnvService.AddTabEnv(envName);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                catch (Exception ex)
                {
                    FormMessage fm = new FormMessage(ex.Message, "错误提示");
                    fm.ShowDialog();
                }
            }
        }
    }
}
