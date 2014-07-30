using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using yoogacatering.Entity;
using System.Data;

namespace yoogacatering.Service
{
    class BillInfoService
    {
        public List<BillInfo> GetBillInfosByBillkeyAndChecktime(string billkey,string dtb,string dte)
        {
            List<BillInfo> bills = new List<BillInfo>();
            string sql = "select * from billinfo where billkey like @billkey and checktime between @dtb and @dte";

            DataTable dt = DbUtil.ExecuteDataTable(sql,
                new MySqlParameter("@billkey",string.Format("%{0}%",billkey)),
                new MySqlParameter("@dtb",dtb),
                new MySqlParameter("@dte",dte));

            foreach (DataRow row in dt.Rows)
            {
                BillInfo bill = ToBillInfo(row);
                bills.Add(bill);
            }
            return bills;
        }

        public List<BillInfo> GetBillInfosBySql(string sql,params MySqlParameter[] paras)
        {
            List<BillInfo> bills = new List<BillInfo>();
            DataTable dt = DbUtil.ExecuteDataTable(sql,paras);

            foreach (DataRow row in dt.Rows)
            {
                BillInfo bill = ToBillInfo(row);
                bills.Add(bill);
            }
            return bills;
        }
        public List<BillInfo> GetBillInfosByTime(string dtb, string dte)
        {
            List<BillInfo> bills = new List<BillInfo>();
            DataTable dt = new DataTable();
            string sql = "select * from billinfo where 1 =1 and ";
            if (dtb.Equals("无"))
            {
                sql += "checktime < @dte";
                dt = DbUtil.ExecuteDataTable(sql, new MySqlParameter("@dte", dte));
            }
            else
            {
                sql += " checktime between @dtb and @dte";
                dt = DbUtil.ExecuteDataTable(sql,
                    new MySqlParameter("@dtb", dtb),
                    new MySqlParameter("@dte", dte));
            }
            foreach (DataRow row in dt.Rows)
            {
                BillInfo bill = ToBillInfo(row);
                bills.Add(bill);
            }
            return bills;
        }
        public static void UpdateBillIsPrintByBillkey(string billkey)
        {
            string sql = "update billdetailinfo set isPrint = 1 where billkey = @billkey";
            DbUtil.ExecuteNonQuery(sql,new MySqlParameter("@billkey",billkey));
        }
        private BillInfo ToBillInfo(DataRow row)
        {
            BillInfo bill = new BillInfo();
            bill.billid = (int)row["billid"];
            bill.billKey = (string)row["billKey"];
            bill.billMoney = (float)row["billMoney"];
            bill.billtime = (string)row["billtime"];
            bill.cardId = (string)row["cardid"];
            bill.checktime = (string)row["checktime"];
            bill.checkUsername = (string)row["checkUsername"];
            bill.custCount = (int)row["custCount"];
            bill.discount = (string)row["discount"];
            bill.jiaocai = (string)row["jiaocai"];
            bill.mark = (string)row["mark"];
            bill.paymethod = (string)row["paymethod"];
            bill.printCount = (int)row["printCount"];
            bill.SHcard = (float)row["SHcard"];
            bill.SHcash = (float)row["SHcash"];
            bill.SHmoney = (float)row["SHmoney"];
            bill.disMoney = (float)row["disMoney"];
            bill.preMoney = (float)row["preMoney"];
            bill.SHvesa = (float)row["SHvesa"];
            bill.status = (int)row["status"];
            bill.tabName = (string)row["tabName"];
            bill.vipNo = (string)row["vipno"];
            
            //bill.zl = (int)row["zl"];
            return bill;
        }
        public BillInfo GetBillInfoByBillkey(string billkey)
        {
            string sql = "select * from billinfo where billkey = @billkey";
            DataTable dt = DbUtil.ExecuteDataTable(sql, new MySqlParameter("@billkey", billkey));
            if (dt.Rows.Count > 0)
            {
                BillInfo info = ToBillInfo(dt.Rows[0]);
                return info;
            }
            else 
            {
                return null;
            }
        }
        public static string GetNotCheckOutBillkeyByTabName(string tabName)
        {
            try
            {
                string sql = "select billkey from billinfo where status = 0 and tabName = @tabName";
                return DbUtil.ExecuteScalar(sql, new MySqlParameter("@tabName", tabName)).ToString();
            }
            catch 
            {
                return "";
            }
        }
        public void UpdateBillInfo(BillInfo bill)
        {
            try
            {
                string sql = "UPDATE `billinfo` SET `tabName` = @tabName,`billMoney` = @billMoney,`paymethod` = @paymethod,`SHmoney` = @SHmoney,`SHcash` = @SHcash,`SHvesa` = @SHvesa,`SHcard` = @SHcard,`status` = @status,`billtime` = @billtime,`checktime`=@checktime,`checkUsername` = @checkUsername,`custCount`=@custCount,`printCount`=@printCount,`mark`=@mark,`vipno`=@vipno,`cardid`=@cardid,`discount`=@discount,`jiaocai`=@jiaocai,`preMoney` = @preMoney,`disMoney` = @disMoney WHERE `billkey` = @billkey";
                DbUtil.ExecuteNonQuery(sql,
                    new MySqlParameter("@billKey", bill.billKey),
                    new MySqlParameter("@tabName", bill.tabName),
                    new MySqlParameter("@billMoney", bill.billMoney),
                    new MySqlParameter("@paymethod", bill.paymethod),
                    new MySqlParameter("@SHmoney", bill.SHmoney),
                    new MySqlParameter("@SHcash", bill.SHcash),
                    new MySqlParameter("@SHvesa", bill.SHvesa),
                    new MySqlParameter("@SHcard", bill.SHcard),
                    new MySqlParameter("@status", bill.status),
                    new MySqlParameter("@billtime", bill.billtime),
                    new MySqlParameter("@checktime", bill.checktime),
                    new MySqlParameter("@checkUsername", bill.checkUsername),
                    new MySqlParameter("@custCount", bill.custCount),
                    new MySqlParameter("@printCount", bill.printCount),
                    new MySqlParameter("@mark", bill.mark),
                    new MySqlParameter("@vipno", bill.vipNo),
                    new MySqlParameter("@cardid", bill.cardId),
                    new MySqlParameter("@discount", bill.discount),
                    new MySqlParameter("@jiaocai", bill.jiaocai),
                    new MySqlParameter("@preMoney", bill.preMoney),
                    new MySqlParameter("@disMoney", bill.disMoney));
            }
            catch (Exception ex)
            {
                throw new Exception("修改账单错误" + ex.Message);
            }
        }
        public void AddBillInfo(BillInfo bill)
        {
            try
            {
                string sql = "INSERT INTO `billinfo`(`billKey`,`tabName`,`billMoney`,`paymethod`,`SHmoney`,`SHcash`,`SHvesa`,`SHcard`,`status`,`billtime`,`checktime`,`checkUsername`,`custCount`,`printCount`,`mark`,`vipno`,`cardid`,`discount`,`jiaocai`,`preMoney`,`disMoney`)VALUES (@billKey,@tabName,@billMoney,@paymethod,@SHmoney,@SHcash,@SHvesa,@SHcard,@status,@billtime,@checktime,@checkUsername,@custCount,@printCount,@mark,@vipno,@cardid,@discount,@jiaocai,@preMoney,0.0)";
                DbUtil.ExecuteNonQuery(sql,
                    new MySqlParameter("@billKey", bill.billKey),
                    new MySqlParameter("@tabName", bill.tabName),
                    new MySqlParameter("@billMoney", bill.billMoney),
                    new MySqlParameter("@paymethod", bill.paymethod),
                    new MySqlParameter("@SHmoney", bill.SHmoney),
                    new MySqlParameter("@SHcash", bill.SHcash),
                    new MySqlParameter("@SHvesa", bill.SHvesa),
                    new MySqlParameter("@SHcard", bill.SHcard),
                    new MySqlParameter("@status", bill.status),
                    new MySqlParameter("@billtime", bill.billtime),
                    new MySqlParameter("@checktime", bill.checktime),
                    new MySqlParameter("@checkUsername", bill.checkUsername),
                    new MySqlParameter("@custCount", bill.custCount),
                    new MySqlParameter("@printCount", bill.printCount),
                    new MySqlParameter("@mark", bill.mark),
                    new MySqlParameter("@vipno", bill.vipNo),
                    new MySqlParameter("@cardid", bill.cardId),
                    new MySqlParameter("@discount", bill.discount),
                    new MySqlParameter("@jiaocai", bill.jiaocai),
                    new MySqlParameter("@preMoney", bill.preMoney));
            }
            catch (Exception ex)
            {
                throw new Exception("新增账单错误"+ex.Message);
            }
        }
    }
}
