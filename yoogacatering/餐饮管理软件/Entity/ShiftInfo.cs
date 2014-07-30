using System;
using System.Collections.Generic;
using System.Text;

namespace yoogacatering.Entity
{
    /// <summary>
    /// 交班信息
    /// </summary>
    class ShiftInfo
    {

        public int id { set; get; }
        public string userName { set; get; }
        public string shiftTime { set; get; }
        public float turnoverMoney { set; get; } //营业额
        public float cashMoney { set; get; }
        public float vesaMoney { set; get; }
        public float preMoney { set; get; }
        public float disMoney { set; get; }
        public float runMoney { set; get; }

        public int billCount { set; get; }

        public int isDay { set; get; }
    }
}
