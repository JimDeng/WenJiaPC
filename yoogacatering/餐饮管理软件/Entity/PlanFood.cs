using System;
using System.Collections.Generic;
using System.Text;

namespace yoogacatering.Entity
{
    /// <summary>
    /// 套餐信息
    /// </summary>
    public class PlanFood
    {
        public int id { set; get; }
        public string planName { set; get; }
        public int planFoodid { set; get; }
        public string planFoodname { set; get; }
        public int planFoodCount { set; get; }
        public float planFoodPrice { set; get; }
        public string planFoodUnit { set; get; }
    }
}
