using System;
using System.Collections.Generic;
using System.Text;
using yoogacatering.Entity;
using MySql.Data.MySqlClient;
using System.Data;

namespace yoogacatering.Service
{
    class PlanFoodService
    {
        public void DelPlanFoodByPlanName(string planName)
        {
            string sql = "delete from foodplan where planName = @planName";
            DbUtil.ExecuteNonQuery(sql, new MySqlParameter("@planName", planName));
        }
        public void DelPlanFoodById(int id)
        {
            string sql = "delete from foodplan where id = @id";
            DbUtil.ExecuteNonQuery(sql,new MySqlParameter("@id",id));
        }
        private PlanFood ToPlanFood(DataRow row)
        {
            PlanFood food = new PlanFood();
            food.id = (int)row["id"];
            food.planName = (string)row["planName"];
            food.planFoodid = (int)row["planFoodid"];
            food.planFoodname = (string)row["planFoodname"];
            food.planFoodCount = (int)row["planFoodCount"];
            food.planFoodPrice = (float)row["planFoodPrice"];
            food.planFoodUnit = (string)row["planFoodUnit"];
            return food;
        }
        public List<PlanFood> GetPlanFood(string planName)
        {
            List<PlanFood> planFoods = new List<PlanFood>();
            string sql = "select * from foodplan where planName = @planName";
            DataTable dt = DbUtil.ExecuteDataTable(sql, new MySqlParameter("@planName", planName));
            if (dt != null)
            {
                foreach(DataRow row in dt.Rows)
                {
                    PlanFood food = ToPlanFood(row);
                    planFoods.Add(food);
                }
            }
            return planFoods;
 
        }
        public void AddPlanFood(PlanFood planFood)
        {
            try
            {
                string sql = "INSERT INTO `foodplan`(`planName`,`planFoodid`,`planFoodname`,`planFoodCount`,`planFoodPrice`,`planFoodUnit`)VALUES (@planName,@planFoodid,@planFoodname,@planFoodCount,@planFoodPrice,@planFoodUnit)";
                DbUtil.ExecuteNonQuery(sql, new MySqlParameter("@planName", planFood.planName),
                    new MySqlParameter("@planFoodCount", planFood.planFoodCount),
                    new MySqlParameter("@planFoodname", planFood.planFoodname),
                    new MySqlParameter("@planFoodid", planFood.planFoodid),
                    new MySqlParameter("@planFoodPrice", planFood.planFoodPrice),
                    new MySqlParameter("@planFoodUnit", planFood.planFoodUnit));
            }
            catch (Exception ex)
            {
                throw new Exception("新增套餐信息失败"+ex.Message);
            }
        }
    }
}
