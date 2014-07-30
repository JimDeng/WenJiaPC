using System;
using System.Collections.Generic;
using System.Text;
using yoogacatering.Entity;
using MySql.Data.MySqlClient;
using System.Data;

namespace yoogacatering.Service
{
    class BillDetailInfoService
    {


        public static void UpdateForGiveByID(int id)
        {
            string sql = "update billDetailInfo set handsel = '是' where id = @id";
            DbUtil.ExecuteNonQuery(sql, new MySqlParameter("@id", id));
        }

        public static void UpdatePrintByID(int id)
        {
            string sql = "update billDetailInfo set isPrint = 1 where id = @id";
            DbUtil.ExecuteNonQuery(sql,new MySqlParameter("@id",id));
        }

        public BillDetailInfo ToBillDetailInfo(DataRow row)
        {
            BillDetailInfo dInfo = new BillDetailInfo();
            dInfo.BillKey = (string)row["billkey"];
            dInfo.FoodCnName = (string)row["foodCnName"];
            dInfo.foodCount = (int)row["foodCount"];
            dInfo.FoodID = (int)row["foodID"];
            dInfo.FoodPrice = (float)row["foodPrice"];
            dInfo.FoodUnit = (string)row["foodUnit"];
            dInfo.Handsel = (string)row["handsel"];
            dInfo.ID = (int)row["id"];
            dInfo.isPrint = (int)row["isPrint"];
            dInfo.jiaocai = (string)row["jiaocai"];
            dInfo.Mark = (string)row["mark"];
            dInfo.remark = (string)row["remark"];
            dInfo.Stauts = (string)row["status"];
            dInfo.Time = (string)row["bTime"];
            dInfo.UserName = (string)row["userName"];
            return dInfo;
        }
        public List<BillDetailInfo> GetBillDetailInfoByBillkey(string billkey)
        {
            List<BillDetailInfo> billDetailInfos = new List<BillDetailInfo>();
            string sql = "select * from billDetailInfo where billkey = @billkey";
            DataTable dt = DbUtil.ExecuteDataTable(sql, new MySqlParameter("@billkey", billkey));
            foreach (DataRow row in dt.Rows)
            {
                BillDetailInfo dInfo = ToBillDetailInfo(row);
                billDetailInfos.Add(dInfo);
            }
            return billDetailInfos;
        }
        public int AddBillDetailInfo(BillDetailInfo dInfo)
        {
            string sql = "INSERT INTO `billDetailInfo`(`billkey`,`foodID`,`foodCnName`,`foodUnit`,`foodCount`,`foodPrice`,`userName`,`status`,`mark`,`handsel`,`bTime`,`isPrint`,`remark`,`jiaocai`)VALUES (@billkey,@foodID,@foodCnName,@foodUnit,@foodCount,@foodPrice,@userName,@status,@mark,@handsel,@bTime,@isPrint,@remark,@jiaocai)";
            DbUtil.ExecuteScalar(sql,
                new MySqlParameter("@billkey", dInfo.BillKey),
                new MySqlParameter("@foodID", dInfo.FoodID),
                new MySqlParameter("@foodCnName", dInfo.FoodCnName),
                
                new MySqlParameter("@foodUnit", dInfo.FoodUnit),
                new MySqlParameter("@foodCount", dInfo.foodCount),
                new MySqlParameter("@foodPrice", dInfo.FoodPrice),
                new MySqlParameter("@userName", dInfo.UserName),
                new MySqlParameter("@status", dInfo.Stauts),
                new MySqlParameter("@mark", dInfo.Mark),
                new MySqlParameter("@handsel", dInfo.Handsel),
                new MySqlParameter("@bTime", dInfo.Time),
                new MySqlParameter("@isPrint", dInfo.isPrint),
                new MySqlParameter("@remark", dInfo.remark),
                new MySqlParameter("@jiaocai", dInfo.jiaocai));

            sql = "select max(id) from billDetailInfo";

            return Convert.ToInt32(DbUtil.ExecuteScalar(sql));
        }
    }
}
