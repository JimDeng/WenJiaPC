using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using yoogacatering.Entity;

namespace yoogacatering.Service
{
    class CommService
    {
        public static void SetPadorderPrinted(int id)
        {
            string sql = "update padorder set isprint = 1 where id = @id";
            DbUtil.ExecuteNonQuery(sql,new MySqlParameter("@id",id));
        }
        public static Padorder GetLastNotPrintPadorder()
        {
            string sql = "select * from padorder where isprint = 0 order by billtime limit 1";

            DataTable dt = DbUtil.ExecuteDataTable(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                Padorder order = new Padorder();
                order.billkey = dt.Rows[0]["billkey"].ToString();
                order.billtime = dt.Rows[0]["billtime"].ToString();
                order.isprint = Convert.ToInt32(dt.Rows[0]["isprint"].ToString());
                order.jiaocai = dt.Rows[0]["jiaocai"].ToString();
                order.tabname = dt.Rows[0]["tabname"].ToString();
                order.id = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                return order;
            }
        }

        public static void SaveCompanyName(string name)
        {
            string sql = "update sysconfig set companyName = @companyName";
            DbUtil.ExecuteNonQuery(sql, new MySqlParameter("@companyName",name));
        }

        public static string GetCompanyName()
        {
            //string sql = "select companyName from sysconfig where id = 1";
            string sql = "SELECT companyName FROM sysconfig limit 1";
            object result = DbUtil.ExecuteScalar(sql);
            if (result != null) return result.ToString();
            else return "找不到公司名称，请检查打印设置！";
        }

        public static List<string> GetAllSystemRights()
        {
            List<string> rights = new List<string>();
            string sql = "select * from SystemRights";
            DataTable dt = DbUtil.ExecuteDataTable(sql);
            foreach (DataRow row in dt.Rows)
            {
                rights.Add(row["rightName"].ToString());
            }
            return rights;
        }

        public static string GetBillkey()
        {
            String maxBillkey = GetMaxBillkey();
            if (maxBillkey != "0")
            {
                string headDate = maxBillkey.Substring(0, 8);
                int lastNumber = int.Parse(maxBillkey.Substring(8));
                if (headDate == DateTime.Now.ToString("yyyyMMdd"))
                {
                    lastNumber++;
                    string tableID = headDate + lastNumber.ToString("00000000");
                    SaveMaxBillkey(tableID);
                    return tableID;
                }
            }
            SaveMaxBillkey(DateTime.Now.ToString("yyyyMMdd") + "00000001");
            return DateTime.Now.ToString("yyyyMMdd") + "00000001";
        }

        public static void SaveMaxBillkey(string maxBillkey)
        {
            string sql = "truncate table maxcount";
            DbUtil.ExecuteNonQuery(sql);

            sql = "insert into maxcount(tableID) values (@tableID)";
            DbUtil.ExecuteNonQuery(sql, new MySqlParameter("tableID", maxBillkey));
        }
        public static string GetMaxBillkey()
        {
            string sql = "select ifnull(max(tableID),'0') from maxcount";
            return DbUtil.ExecuteScalar(sql).ToString();
        }
    }
}
