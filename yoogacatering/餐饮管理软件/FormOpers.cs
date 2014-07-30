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
    public partial class FormOpers : Form
    {
        public int type { set; get; }
        public int id { set; get; }
        public FormOpers(int type, int id)
        {
            this.type = type;
            this.id
                 = id;
            InitializeComponent();
        }

        private void FormOpers_Load(object sender, EventArgs e)
        {
            if (type == 0)
            {
                this.Text = "新增操作员";
                lbOK.Text = "增加";

                List<string> systemRights = CommService.GetAllSystemRights();
                foreach (string s in systemRights)
                {
                    lxNoGrant.Items.Add(s);
                }
            }
            else
            {
                try
                {
                    this.Text = "修改操作员";
                    lbOK.Text = "修改";
                    OpersService service = new OpersService();
                    Opers op = service.GetOpersByID(id);


                    tbOpenID.Text = op.operID;
                    tbOperName.Text = op.operName;
                    tbOperPwd.Text = op.operPws;
                    cbOperPos.Text = op.operPos;
                    cbOperSex.Text = op.operSex;

                    List<string> grantRights = service.GetAllGrantRights(id);
                    List<string> noGrantRights = service.GetAllNoGrantRights(id);
                    foreach (string s in grantRights)
                    {
                        lxGrant.Items.Add(s);
                    }
                    foreach (string s in noGrantRights)
                    {
                        lxNoGrant.Items.Add(s);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            cbOperSex.SelectedIndex = 0;
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void lbOK_Click(object sender, EventArgs e)
        {
            string openID = tbOpenID.Text.Trim();
            string openName = tbOperName.Text.Trim();
            string openPos = cbOperPos.Text;
            string openSex = cbOperSex.Text;
            string openPwd = tbOperPwd.Text.Trim();
            if (openName == "" || openID == "")
            {
                MessageBox.Show("登录名和用户名不能为空");
                return;
            }
            if (lbOK.Text.Equals("增加"))
            {
                try
                {
                    Opers op = new Opers();
                    op.operID = openID;
                    op.operName = openName;
                    op.operPos = openPos;
                    op.operSex = openSex;
                    op.operPws = openPwd;
                    OpersService service = new OpersService();
                    List<string> grantRights = new List<string>();
                    for (int i = 0; i < lxGrant.Items.Count; i++)
                    {
                        grantRights.Add(lxGrant.Items[i].ToString());
                    }
                    op.openGrantRigts = grantRights;
                    service.AddOpers(op);
                    MessageBox.Show("新增操作员成功");
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                OpersService service = new OpersService();
                Opers op = service.GetOpersByID(id);
                op.operID = openID;
                op.operName = openName;
                op.operPos = openPos;
                op.operSex = openSex;
                op.operPws = openPwd;
                List<string> grantRights = new List<string>();
                for (int i = 0; i < lxGrant.Items.Count; i++)
                {
                    grantRights.Add(lxGrant.Items[i].ToString());
                }
                op.openGrantRigts = grantRights;
                service.UpdateOpers(op);
                MessageBox.Show("修改操作员成功");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void lxGrant_DoubleClick(object sender, EventArgs e)
        {
            string str = lxGrant.SelectedItem.ToString();
            if (str != "")
            {
                lxGrant.Items.Remove(str);
                lxNoGrant.Items.Add(str);
            }
        }

        private void lxNoGrant_DoubleClick(object sender, EventArgs e)
        {
            string str = lxNoGrant.SelectedItem.ToString();
            if (str != "")
            {
                lxNoGrant.Items.Remove(str);
                lxGrant.Items.Add(str);
            }

        }
    }
}
