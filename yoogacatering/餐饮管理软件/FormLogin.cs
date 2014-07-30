using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using yoogacatering.Entity;
using yoogacatering.Service;
using yoogacatering.Utils;

namespace yoogacatering
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string operid = tbUserID.Text.Trim();
            string operPwd = tbPwd.Text.Trim();
            OpersService service = new OpersService();
            Opers op = service.GetOpersByOperID(operid);
            if (op != null)
            {
                App.userName = op.operName;
                App.userGights = op.openGrantRigts;


                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                FormMessage fm = new FormMessage("错误的用户名或密码", "提示");
                fm.ShowDialog();
            }
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Login();
            }
        }
    }
}
