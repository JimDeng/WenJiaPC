using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yoogacatering
{
    public partial class FormRetreat : Form
    {
        public string reason { set; get; }
        public FormRetreat()
        {
            InitializeComponent();
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void lbRetreat_Click(object sender, EventArgs e)
        {
            string rea = tbReason.Text.Trim();
            if (rea == "")
            {
                MessageBox.Show("请输入退菜原因");
            }
            else
            {
 
            }

        }
    }
}
