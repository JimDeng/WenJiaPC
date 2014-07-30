using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using yoogacatering.Printer;
using yoogacatering.Service;
using yoogacatering.Utils;

namespace yoogacatering
{
    public partial class FormPrintSetting : Form
    {
        public FormPrintSetting()
        {
            InitializeComponent();
        }

        private void FormPrintSetting_Load(object sender, EventArgs e)
        {
            List<string> printers = PrintUtils.GetAllPrint();

            foreach (string s in printers)
            {
                cbBarPrinter.Items.Add(s);
                cbConPrinter.Items.Add(s);
                cbKitPrinter.Items.Add(s);
            }
            string barPrint = PrintUtils.GetBarPrintName();
            if (barPrint != null)
            {
                cbBarPrinter.Text = barPrint;
            }

            string kitPrint = PrintUtils.GetKitchenPrintName();
            if (kitPrint != null)
            {
                cbKitPrinter.Text = kitPrint;
            }

            string conPrint = PrintUtils.GetConsumePrintName();
            if (conPrint != null)
            {
                cbConPrinter.Text = conPrint;
            }
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void lbOK_Click(object sender, EventArgs e)
        {
            string barPrint = cbBarPrinter.Text.Trim();
            string kitPrint = cbKitPrinter.Text.Trim();
            string conPrint = cbKitPrinter.Text.Trim();

            App.SetValue("barprinter", barPrint);
            App.SetValue("kitprinter", kitPrint);
            App.SetValue("conprinter", conPrint);

            CommService.SaveCompanyName(tbComName.Text.Trim());

            MessageBox.Show("保存成功，请重启应用程序，让新的设置生效");
        }
    }
}
