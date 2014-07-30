using System;
using System.Collections.Generic;
using System.Text;

namespace yoogacatering.Entity
{
    class BillInfo
    {
        public int billid { set; get; }
        public String billKey { set; get; }
        public String tabName { set; get; }
        public float billMoney { set; get; }
        public string paymethod { set; get; }
        public float SHmoney { set; get; }
        public float SHcash { set; get; }
        public float SHvesa { set; get; }
        public float SHcard { set; get; }
        public string billtime { set; get; }
        public int status { set; get; } //0 为结账 1 已结账 2 挂账
        public String checktime { set; get; }
        public String checkUsername { set; get; }
        public int custCount { set; get; }
        public int printCount { set; get; }
        //public List<BillDetailInfo> detailInfos { set; get; }
        public String mark { set; get; }
        public String vipNo { set; get; }
        public string cardId { set; get; }
        public string cardSeriaId { set; get; }
        public string discount { set; get; }
        //public List<BillDetailInfo> kitchenDetailInfos { set; get; }
        //public List<BillDetailInfo> barDetailInfos { set; get; }
        public string jiaocai { set; get; }
        public float zl { set; get; }

        public float preMoney { set; get; }
        public float disMoney { set; get; }
    }
}
