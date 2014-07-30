using System;
using System.Collections.Generic;
using System.Text;

namespace yoogacatering.Entity
{
    class BillDetailInfo
    {
        public int ID { set; get; }
        public String BillKey { set; get; }
        public int FoodID { set; get; }
        public String FoodCnName { set; get; }
        public String FoodUnit { set; get; }
        public float FoodPrice { set; get; }
        public String UserName { set; get; }
        public String Stauts { set; get; }
        public String Mark { set; get; }
        public String Handsel { set; get; } // 赠送
        public String Time { set; get; }
        public int foodCount { set; get; }
        public int isPrint { set; get; }
        public string remark { set; get; }
        public string jiaocai { set; get; }
    }
}
