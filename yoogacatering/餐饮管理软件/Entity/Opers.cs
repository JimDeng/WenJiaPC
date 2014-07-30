using System;
using System.Collections.Generic;
using System.Text;

namespace yoogacatering.Entity
{
    /// <summary>
    /// 操作员
    /// </summary>
    class Opers
    {
        public int id { set; get; }
        public string operID { set; get; }
        public string operName { set; get; }
        public string operSex { set; get; }
        public string operPos { set; get; }
        public string operPws { set; get; }
        public List<string> openGrantRigts { set; get; }
        public List<string> openNotGrantGights { set; get; }
    }
}
