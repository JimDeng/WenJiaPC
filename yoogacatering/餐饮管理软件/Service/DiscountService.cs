using System;
using System.Collections.Generic;
using System.Text;
using yoogacatering.Entity;

namespace yoogacatering.Service
{
    class DiscountService
    {
        public List<DiscountInfo> GetAllDiscountInfo()
        {
            DiscountInfo dinfo0 = new DiscountInfo() { discountName = "无", discountValue = 1 };
            DiscountInfo dinfo1 = new DiscountInfo() { discountName = "九五折", discountValue = 0.95f };
            DiscountInfo dinfo2 = new DiscountInfo() { discountName = "九折", discountValue = 0.9f };
            DiscountInfo dinfo3 = new DiscountInfo() { discountName = "八五折", discountValue = 0.85f };
            List<DiscountInfo> discounts = new List<DiscountInfo>();
            discounts.Add(dinfo0);
            discounts.Add(dinfo1);
            discounts.Add(dinfo2);
            discounts.Add(dinfo3);
            return discounts;
        }
    }
}
