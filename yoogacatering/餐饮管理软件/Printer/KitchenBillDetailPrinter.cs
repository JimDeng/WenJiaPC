using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using yoogacatering.Entity;
using yoogacatering.Service;

namespace yoogacatering.Printer
{

    class KitchenBillDetailPrinter
    {
        public BillDetailInfo dinfo { set; get; }
        public string tabName { set; get; }
        public string type { set; get; }
        public PrintDocument pdDocument { set; get; }

        public KitchenBillDetailPrinter(BillDetailInfo dinfo, string tabName, string type)
        {
            this.dinfo = dinfo;
            this.tabName = tabName;
            this.type = type;

            PrintUtils.SetDefaultPrint(PrintUtils.GetKitchenPrintName());

            pdDocument = new PrintDocument();
            pdDocument.PrintController = new StandardPrintController();
            pdDocument.PrintPage += new PrintPageEventHandler(pdDocument_PrintPage);
        }

        void pdDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = 10;
            int y = 80;
            //double sx = Convert.ToDouble(tb_Cash.Text) + Convert.ToDouble(tb_Vesa.Text) + Convert.ToDouble(tb_Card.Text) + Convert.ToDouble(tb_cashCoupon.Text);
            e.Graphics.DrawString(type, new Font("Arial", 15), Brushes.Black, 50, 5);
            e.Graphics.DrawString(tabName, new Font("Arial", 20), Brushes.Black, 220, 5);
            e.Graphics.DrawString(CommService.GetCompanyName(), new Font("Arial", 12), Brushes.Black, 30, 50);
            //e.Graphics.DrawString(String.Format("房间号码：{0}",bInfo.billRmNo), new Font("Arial", 10), Brushes.Black, 10, 60);
            e.Graphics.DrawString("商品名称", new Font("Arial", 15), Brushes.Black, x, y);
            e.Graphics.DrawString("数量", new Font("Arial", 15), Brushes.Black, 150, y);
            e.Graphics.DrawString("单价", new Font("Arial", 15), Brushes.Black, 220, y);
            e.Graphics.DrawString(dinfo.FoodCnName, new Font("Arial", 15), Brushes.Black, x, y + 50);
            e.Graphics.DrawString(dinfo.foodCount + "", new Font("Arial", 15), Brushes.Black, 180, y + 50);
            e.Graphics.DrawString(dinfo.FoodPrice + "", new Font("Arial", 15), Brushes.Black, 220, y + 50);


            e.Graphics.DrawString("单品叫起："+dinfo.jiaocai, new Font("Arial", 10), Brushes.Black, 20, y + 80);
            e.Graphics.DrawString("做法：" + dinfo.remark, new Font("Arial", 10), Brushes.Black, 20, y + 100);
            e.Graphics.DrawString(dinfo.Time, new Font("Arial", 10), Brushes.Black, 80, y + 120);
            BillDetailInfoService.UpdatePrintByID(dinfo.ID);

        }
    }
}
