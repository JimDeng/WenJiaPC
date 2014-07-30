using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yoogacatering
{
    public partial class FormMessage : Form
    {
        public FormMessage(string msg, string title)
        {
            InitializeComponent();
            lbmsg.Text = msg;
            this.Text = title;
        }
        private void FormMessage_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
