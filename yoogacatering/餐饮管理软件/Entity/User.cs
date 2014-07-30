using System;
using System.Collections.Generic;
using System.Text;

namespace yoogacatering.Entity
{
    class User
    {
        public int id { set; get; }
        public string UserID { set; get; }  // 登录名
        public string UserName { set; get; }
        public string UserPwd { set; get; }
        public string UserSex { set; get; }
        public string UserPosition { set; get; } // 职位
        public int flag { set; get; }
    }
}
