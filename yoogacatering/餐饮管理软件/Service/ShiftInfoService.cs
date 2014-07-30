using System;
using System.Collections.Generic;
using System.Text;
using yoogacatering.Entity;
using System.Data;
using MySql.Data.MySqlClient;

namespace yoogacatering.Service
{
    class ShiftInfoService
    {
        public string GetLastShiftTime(int isDay)
        {
            string sql = "select * from shiftinfo where isDay = @isDay order by id desc limit 1";
            DataTable dt = DbUtil.ExecuteDataTable(sql, new MySqlParameter("@isDay", isDay));
            if (dt.Rows.Count == 0)
            {
                return "无";
            }
            else
            {
                ShiftInfo s = ToShiftInfo(dt.Rows[0]);
                return s.shiftTime;
            }
        }

        public void AddShiftInfo(ShiftInfo shiftInfo)
        {
            string sql = "INSERT INTO `shiftInfo`(`userName`,`shiftTime`,`turnoverMoney`,`cashMoney`,`vesaMoney`,`preMoney`,`disMoney`,`runMoney`,`billCount`,`isDay`)VALUES (@userName,@shiftTime,@turnoverMoney,@cashMoney,@vesaMoney,@preMoney,@disMoney,@runMoney,@billCount,@isDay)";
            DbUtil.ExecuteNonQuery(sql,
                new MySqlParameter("@userName",shiftInfo.userName),
                new MySqlParameter("@shiftTime",shiftInfo.shiftTime),
                new MySqlParameter("@turnoverMoney", shiftInfo.turnoverMoney),
                new MySqlParameter("@cashMoney", shiftInfo.cashMoney),
                new MySqlParameter("@vesaMoney", shiftInfo.vesaMoney),
                new MySqlParameter("@preMoney", shiftInfo.preMoney),
                new MySqlParameter("@disMoney", shiftInfo.disMoney),
                new MySqlParameter("@runMoney", shiftInfo.runMoney),
                new MySqlParameter("@billCount", shiftInfo.billCount),
                new MySqlParameter("@isDay",shiftInfo.isDay));
        }

        public ShiftInfo ToShiftInfo(DataRow row)
        {
            ShiftInfo shiftInfo = new ShiftInfo();
            shiftInfo.billCount = (int)row["billCount"];
            shiftInfo.cashMoney = (float)row["cashMoney"];
            shiftInfo.disMoney = (float)row["disMoney"];
            shiftInfo.id = (int)row["id"];
            shiftInfo.preMoney = (float)row["preMoney"];
            shiftInfo.runMoney = (float)row["runMoney"];
            shiftInfo.shiftTime = (string)row["shiftTime"];
            shiftInfo.turnoverMoney = (float)row["turnoverMoney"];
            shiftInfo.userName = (string)row["userName"];
            shiftInfo.vesaMoney = (float)row["vesaMoney"];
            shiftInfo.isDay = (int)row["isDay"];
            return shiftInfo;
        }
        public List<ShiftInfo> GetAllShiftInfos()
        {
            List<ShiftInfo> shiftInfos = new List<ShiftInfo>();
            string sql = "select * from shiftinfo order by id desc limit 100";
            DataTable dt = DbUtil.ExecuteDataTable(sql);
            foreach (DataRow row in dt.Rows)
            {
                ShiftInfo s = ToShiftInfo(row);
                shiftInfos.Add(s);
            }
            return shiftInfos;
        }
    }
}
