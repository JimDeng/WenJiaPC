using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using yoogacatering.Entity;
using yoogacatering.Service;

namespace yoogacatering.Printer
{
    class KitchenBillPrinter
    {
        public BillInfo binfo { set; get; }
        public string printType { set; get; }
        public PrintDocument pdDocument { set; get; }
        public List<BillDetailInfo> billDetailInfos = new List<BillDetailInfo>();

        public KitchenBillPrinter(BillInfo billInfo, string printType, List<BillDetailInfo> billDetailInfos)
        {
            this.binfo = billInfo;
            this.printType = printType;
            this.billDetailInfos = billDetailInfos;

            PrintUtils.SetDefaultPrint( PrintUtils.GetKitchenPrintName());

            pdDocument = new PrintDocument();
            pdDocument.PrintController = new StandardPrintController();
            pdDocument.PrintPage += new PrintPageEventHandler(pdDocument_PrintPage);
        }
        void pdDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = 10;
            int y = 80;
            e.Graphics.DrawString(binfo.tabName, new Font("Arial", 15), Brushes.Black, 150, 5);
            e.Graphics.DrawString(printType, new Font("Arial", 15), Brushes.Black, 50, 5);
            e.Graphics.DrawString(CommService.GetCompanyName(), new Font("Arial", 10), Brushes.Black, 40, 35);

            e.Graphics.DrawString("商品名称", new Font("Arial", 10), Brushes.Black, x, y);
            e.Graphics.DrawString("数量", new Font("Arial", 10), Brushes.Black, 120, y);
            e.Graphics.DrawString("单价", new Font("Arial", 10), Brushes.Black, 160, y);
            e.Graphics.DrawString("赠送", new Font("Arial", 10), Brushes.Black, 240, y);
            double sum = 0;
            for (int i = 0; i < billDetailInfos.Count; i++)
            {
                BillDetailInfo dInfo = billDetailInfos[i];
                e.Graphics.DrawString(dInfo.FoodCnName, new Font("Arial", 10), Brushes.Black, x, y + i * 25 + 20);
                e.Graphics.DrawString(dInfo.foodCount.ToString(), new Font("Arial", 10), Brushes.Black, 120, y + i * 25 + 20);
                e.Graphics.DrawString(dInfo.FoodPrice.ToString(), new Font("Arial", 10), Brushes.Black, 160, y + i * 25 + 20);
                e.Graphics.DrawString(dInfo.Handsel.ToString(), new Font("Arial", 10), Brushes.Black, 240, y + i * 25 + 20);
                sum += dInfo.FoodPrice * dInfo.foodCount;
            }

            e.Graphics.DrawString(string.Format("总额:{0}", sum + "元"), new Font("Arial", 10), Brushes.Black, 10, 50 + (billDetailInfos.Count + 2) * 25);
            e.Graphics.DrawString(string.Format("账单号:{0}", binfo.billKey), new Font("Arial", 10), Brushes.Black, 10, 50 + (billDetailInfos.Count + 3) * 25);
            e.Graphics.DrawString(string.Format("下单时间:{0}", binfo.billtime), new Font("Arial", 10), Brushes.Black, 10, 50 + (billDetailInfos.Count + 4) * 25);
        }
    }
}
