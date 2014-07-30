using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using yoogacatering.Entity;

namespace yoogacatering.Service
{
    class TabInfoService
    {
        public static string GetTabStatusByTabName(string tabName)
        {
            string sql = "select status from tabinfo where tabName = @tabName";
            return DbUtil.ExecuteScalar(sql, new MySqlParameter("@tabName", tabName)).ToString();
        }

        public void UpdateTabInfoStatus(string tabName, string status)
        {
            string sql = "update tabinfo set status = @status where tabName = @tabName";
            DbUtil.ExecuteNonQuery(sql,new MySqlParameter("@status",status),new MySqlParameter("@tabName",tabName));
        }
        public static void UpdateTabInfoForOpen(string tabName)
        {
            string sql = "UPDATE TabInfo set status = '开台' where tabName = @tabName";
            DbUtil.ExecuteNonQuery(sql,new MySqlParameter("@tabName",tabName));
        }
        public static void AddTabInfo(TabInfo tab)
        {
            string sql = "INSERT INTO `yooga`.`TabInfo`(`tabName`,`envName`,`status`,`createTime`,`startTime`,`checkTime`,`billkey`,`custCount`) VALUES (@tabName,@envName,@status,@createTime,@startTime,@checkTime,@billkey,@custCount)";
            try
            {
                DbUtil.ExecuteNonQuery(sql,
                    new MySqlParameter("@tabName", tab.tabName),
                    new MySqlParameter("@envName", tab.envName),
                    new MySqlParameter("@status", tab.status),
                    new MySqlParameter("@createTime", tab.createTime),
                    new MySqlParameter("@startTime", tab.startTime),
                    new MySqlParameter("@checkTime", tab.checkTime),
                    new MySqlParameter("@billkey", tab.billkey),
                    new MySqlParameter("@custCount", tab.custCount));
            }
            catch (Exception ex)
            {
                throw new Exception("新增失败" + ex.Message);
            }
        }
        public static TabInfo ToTabInfo(DataRow row)
        {
            TabInfo tab = new TabInfo();
            tab.billkey = (string)row["billkey"];
            tab.checkTime = (string)row["checkTime"];
            tab.createTime = (string)row["createTime"];
            tab.custCount = (int)(row["custCount"]);
            tab.envName = (string)row["envName"];
            tab.startTime = (string)row["startTime"];
            tab.status = (string)row["status"];
            tab.tabName = (string)row["tabName"];
            tab.id = (int)row["id"];
            return tab;
        }
        public List<TabInfo> GetAllTabs()
        {
            try
            {
                List<TabInfo> tabs = new List<TabInfo>();
                string sql = "select * from TabInfo";
                DataTable dt = DbUtil.ExecuteDataTable(sql);
                foreach (DataRow row in dt.Rows)
                {
                    TabInfo tab = ToTabInfo(row);
                    tabs.Add(tab);
                }
                return tabs;
            }
            catch (Exception ex)
            {
                throw new Exception("查询所有餐桌失败" + ex.Message);
            }

        }

        public List<TabInfo> GetAllTabsByEnvName(string envName)
        {
            try
            {
                List<TabInfo> tabs = new List<TabInfo>();
                string sql = "select * from TabInfo where envName = @envName";
                DataTable dt = DbUtil.ExecuteDataTable(sql, new MySqlParameter("@envName", envName));
                foreach (DataRow row in dt.Rows)
                {
                    TabInfo tab = ToTabInfo(row);
                    tabs.Add(tab);
                }
                return tabs;
            }
            catch (Exception ex)
            {
                throw new Exception("查询所有餐桌失败" + ex.Message);
            }

        }

        public List<TabInfo> GetAllTabsByNameLike(string tabName)
        {
            try
            {
                List<TabInfo> tabs = new List<TabInfo>();
                string sql = "select * from TabInfo where tabName like @searchText";
                DataTable dt = DbUtil.ExecuteDataTable(sql, new MySqlParameter("@searchText", string.Format("%{0}%", tabName)));
                foreach (DataRow row in dt.Rows)
                {
                    TabInfo tab = ToTabInfo(row);
                    tabs.Add(tab);
                }
                return tabs;
            }
            catch (Exception ex)
            {
                throw new Exception("查询餐桌失败" + ex.Message);
            }

        }
        public static void DelTabInfo(int id)
        {
            try
            {
                string sql = "delete from tabinfo where id = @id";
                DbUtil.ExecuteNonQuery(sql, new MySqlParameter("@id", id));
            }
            catch (Exception ex)
            {
                throw new Exception("删除餐桌失败" + ex.Message);
            }
        }

        public TabInfo GetTabInfoByTabName(string tabName)
        {
            string sql = "select * from tabinfo where tabName = @tabName";
            DataTable dt = DbUtil.ExecuteDataTable(sql,new MySqlParameter("@tabName",tabName));
            if(dt!=null)
            {
                return ToTabInfo(dt.Rows[0]);
            }
            else
            {
                return null;
            }
        }
    }
}
