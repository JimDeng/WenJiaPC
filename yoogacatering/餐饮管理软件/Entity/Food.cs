using System;
using System.Collections.Generic;
using System.Text;

namespace yoogacatering.Entity
{
    class Food
    {
        public int foodid { set; get; }
        public string cnName { set; get; }
        public string enName { set; get; }
        public string des { set; get; }
        public float price { set; get; }
        public string category { set; get; }
        public string canDiscount { set; get; }
        public string status { set; get; }
        public string isHot { set; get; }
        public string unit { set; get; }
        public string createTime { set; get; }
        public string updateTime { set; get; }
        public string imageUpdateTime { set; get; }
        public string delTime { set; get; }
        public string needKC { set; get; }
        public string needMaterials { set; get; }
        public string isPlan { set; get; } // 是否套餐
    }
}
