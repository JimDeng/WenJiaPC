using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using yoogacatering.Entity;

namespace yoogacatering.Service
{
    class TabEnvService
    {
        public static TableEnv ToEnv(DataRow row)
        {
            TableEnv env = new TableEnv();
            env.id = (int)row["id"];
            env.tabEnvName = (string)row["tabEnvName"];
            return env;
        }
        public static List<TableEnv> GetAllEnv()
        {
            List<TableEnv> envs = new List<TableEnv>();
            string sql = "select * from TableEnv";
            DataTable dt = DbUtil.ExecuteDataTable(sql);
            foreach (DataRow row in dt.Rows)
            {
                TableEnv env = ToEnv(row);
                envs.Add(env);
            }
            return envs;
        }

        public static void AddTabEnv(string envName)
        {
            try
            {
                string sql = "insert into tableenv(tabenvname) values (@envName)";
                DbUtil.ExecuteNonQuery(sql, new MySqlParameter("@envName", envName));
            }
            catch (Exception ex)
            {
                throw new Exception("增加就餐环境失败" + ex.Message);
            }
        }

        public static void DelTabEnv(string envName)
        {
            try
            {
                string sql = "delete from tableenv where tabenvname = @tabenvname";
                DbUtil.ExecuteNonQuery(sql, new MySqlParameter("@tabenvname", envName));
            }
            catch (Exception ex)
            {
                throw new Exception("删除餐桌环境失败" + ex.Message);
            }
        }
    }
}
