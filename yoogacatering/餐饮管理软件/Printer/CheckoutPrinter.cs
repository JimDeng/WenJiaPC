using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using yoogacatering.Entity;
using yoogacatering.Service;

namespace yoogacatering.Printer
{
    class CheckoutPrinter
    {
        public PrintDocument pdDocument { set; get; }
        //PrintDocument pdDocument = new PrintDocument();
        public BillInfo bInfo { set; get; }
        public int type { set; get; }
        public int discountmoney { set; get; }
        public List<BillDetailInfo> detailInfos { set; get; }
        public CheckoutPrinter(BillInfo billInfo, int type, List<BillDetailInfo> detailInfos)
        {
            PrintUtils.SetDefaultPrint(PrintUtils.GetConsumePrintName());

            this.bInfo = billInfo;
            this.type = type;
            this.detailInfos = detailInfos;
            pdDocument = new PrintDocument();
            pdDocument.PrintController = new StandardPrintController();
            pdDocument.PrintPage += new PrintPageEventHandler(pdDocument_PrintPage);
        }

        void pdDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = 10;
            int y = 80;
            //double sx = Convert.ToDouble(tb_Cash.Text) + Convert.ToDouble(tb_Vesa.Text) + Convert.ToDouble(tb_Card.Text) + Convert.ToDouble(tb_cashCoupon.Text);
            e.Graphics.DrawString(bInfo.tabName, new Font("Arial", 20), Brushes.Black, 200, 5);
            e.Graphics.DrawString("消费小票", new Font("Arial", 20), Brushes.Black, 60, 5);
            e.Graphics.DrawString(CommService.GetCompanyName(), new Font("Arial", 10), Brushes.Black, 50, 40);
            //e.Graphics.DrawString(String.Format("房间号码：{0}",bInfo.billRmNo), new Font("Arial", 10), Brushes.Black, 10, 60);
            e.Graphics.DrawString("商品名称", new Font("Arial", 10), Brushes.Black, x, y);
            e.Graphics.DrawString("数量", new Font("Arial", 10), Brushes.Black, 120, y);
            e.Graphics.DrawString("单价", new Font("Arial", 10), Brushes.Black, 180, y);
            e.Graphics.DrawString("赠送", new Font("Arial", 10), Brushes.Black, 240, y);
            for (int i = 0; i < detailInfos.Count; i++)
            {
                BillDetailInfo dInfo = detailInfos[i];
                e.Graphics.DrawString(dInfo.FoodCnName, new Font("Arial", 10), Brushes.Black, x, y + i * 25 + 20);
                e.Graphics.DrawString(dInfo.foodCount.ToString(), new Font("Arial", 10), Brushes.Black, 120, y + i * 25 + 20);
                e.Graphics.DrawString(dInfo.FoodPrice.ToString(), new Font("Arial", 10), Brushes.Black, 190, y + i * 25 + 20);
                e.Graphics.DrawString(dInfo.Handsel.ToString(), new Font("Arial", 10), Brushes.Black, 240, y + i * 25 + 20);
            }
            //domain.RechargeCardInfo cinfo = service.RechargeCardService.GetRechargeCardInfoByCardId(bInfo.cardId);
            e.Graphics.DrawString(string.Format("总金额：{0}元  账单号:{1}", bInfo.billMoney, bInfo.billKey), new Font("Arial", 10), Brushes.Black, 10, 50 + (detailInfos.Count + 2) * 25);
            e.Graphics.DrawString(string.Format("折扣：{0}  折扣金额:{1} 元", bInfo.discount, bInfo.billMoney - bInfo.SHmoney), new Font("Arial", 10), Brushes.Black, 10, 50 + (detailInfos.Count + 3) * 25);
            e.Graphics.DrawString(string.Format("应收金额：{0}元 结帐方式：{1} ", bInfo.SHmoney, bInfo.paymethod), new Font("Arial", 10), Brushes.Black, 10, 50 + (detailInfos.Count + 4) * 25);
            //e.Graphics.DrawString(string.Format("结帐方式：{0}元 ", bInfo.paymethod), new Font("Arial", 10), Brushes.Black, 10, 50 + (bInfo.detailInfos.Count + 5) * 25);
            if (type == 1)
            {
                //e.Graphics.DrawString(string.Format("易享卡卡号：{0}", bInfo.vipNo), new Font("Arial", 10), Brushes.Black, 10, 50 + (detailInfos.Count + 5) * 25);
                //e.Graphics.DrawString(string.Format("充值卡号：{0} 充值卡余额:{1}元", bInfo.cardId, cinfo == null ? "0.0" : (cinfo.Balance + cinfo.FHBalance).ToString()), new Font("Arial", 10), Brushes.Black, 10, 50 + (bInfo.detailInfos.Count + 6) * 25);
                e.Graphics.DrawString(string.Format("实收金额:{0}元，找零{1}元", bInfo.SHmoney, bInfo.zl), new Font("Arial", 10), Brushes.Black, 10, 50 + (detailInfos.Count + 5) * 25);
                e.Graphics.DrawString(string.Format("结账时间:{0}", bInfo.checktime), new Font("Arial", 10), Brushes.Black, 10, 50 + (detailInfos.Count + 6) * 25);
            }
        }
    }
}
