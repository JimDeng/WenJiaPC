using System;
using System.Collections.Generic;
using System.Text;

namespace yoogacatering.Entity
{
    class TabInfo
    {
        public int id { set; get; }
        public string tabName { set; get; }
        public string envName { set; get; }
        public string status { set; get; }
        public string createTime { set; get; }
        public string startTime { set; get; }
        public string checkTime { set; get; }
        public string billkey { set; get; }
        public int custCount { set; get; }
    }
}
