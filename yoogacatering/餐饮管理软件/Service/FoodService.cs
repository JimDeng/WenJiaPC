using System;
using System.Collections.Generic;
using System.Text;
using yoogacatering.Entity;
using MySql.Data.MySqlClient;
using System.Data;

namespace yoogacatering.Service
{
    class FoodService
    {
        public DataTable CountFood(string dtb, string dte)
        {
            using (MySqlConnection con = DbUtil.GetCon())
            {
                con.Open();
                using (MySqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select foodcnname as 餐点名称,count(foodcnname) as 餐点数量 from billdetailinfo where btime between @begTime and @endTime group by foodcnname order by count(foodcnname)";
                    cmd.Parameters.AddWithValue("@begTime", dtb);
                    cmd.Parameters.AddWithValue("@endTime", dte);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    return ds.Tables[0];
                }
            }
        }

        private Food ToFood(DataRow row)
        {
            Food food = new Food();
            food.canDiscount = (string)row["canDiscount"];
            food.category = (string)row["category"];
            food.cnName = (string)row["cnName"];
            food.createTime = (string)row["createTime"];
            food.delTime = (string)row["delTime"];
            food.des = (string)row["des"];
            food.enName = (string)row["enName"];
            food.foodid = (int)row["foodid"];
            food.imageUpdateTime = (string)row["imageUpdateTime"];
            food.isHot = (string)row["isHot"];
            food.isPlan = (string)row["isPlan"];
            food.needKC = (string)row["needKC"];
            food.needMaterials = (string)row["needMaterials"];
            food.price = (float)row["price"];
            food.status = (string)row["status"];
            food.unit = (string)row["unit"];
            food.updateTime = (string)row["updateTime"];
            return food;
        }
        public static bool CanDiscount(string cnName)
        {
            string sql = "select count(1) from food where candiscount = '能' and cnName = @cnName";
            int count = Convert.ToInt32(DbUtil.ExecuteScalar(sql, new MySqlParameter("@cnName", cnName)));
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPlanFood(string cnName)
        {
            string sql = "select count(1) from food where isPlan = '是' and cnName = @cnName";
            int count = Convert.ToInt32(DbUtil.ExecuteScalar(sql, new MySqlParameter("@cnName", cnName)));
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsKitchenFood(string cnName)
        {
            string sql = "select count(1) from food where category in (select categoryName from foodcategory where categoryBelong = '厨房') and cnName = @cnName";
            int count = Convert.ToInt32(DbUtil.ExecuteScalar(sql, new MySqlParameter("@cnName", cnName)));
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void UpdateFood(Food food)
        {
            string sql = "update food set cnName = @cnName,enName = @enName,des = @des,price = @price,category= @category,canDiscount = @canDiscount,status = @status,isHot = @isHot,unit = @unit,createTime = @createTime,updateTime = @updateTime,imageUpdateTime = @imageUpdateTime,delTime = @delTime,needKC = @needKC,needMaterials = @needMaterials,isPlan = @isPlan where foodid = @foodid";
            DbUtil.ExecuteNonQuery(sql,
                    new MySqlParameter("@cnName", food.cnName),
                    new MySqlParameter("@enName", food.enName),
                    new MySqlParameter("@des", food.des),
                    new MySqlParameter("@price", food.price),
                    new MySqlParameter("@category", food.category),
                    new MySqlParameter("@canDiscount", food.canDiscount),
                    new MySqlParameter("@status", food.status),
                    new MySqlParameter("@isHot", food.isHot),
                    new MySqlParameter("@unit", food.unit),
                    new MySqlParameter("@createTime", food.createTime),
                    new MySqlParameter("@updateTime", food.updateTime),
                    new MySqlParameter("@imageUpdateTime", food.imageUpdateTime),
                    new MySqlParameter("@delTime", food.delTime),
                    new MySqlParameter("@needKC", food.needKC),
                    new MySqlParameter("@needMaterials", food.needMaterials),
                    new MySqlParameter("@isPlan", food.isPlan),
                    new MySqlParameter("@foodid",food.foodid));

        }
        public Food GetFoodById(int id)
        {
            string sql = "select * from food where foodid = @id";
            DataTable dt = DbUtil.ExecuteDataTable(sql,new MySqlParameter("@id",id));
            if (dt != null)
            {
                return ToFood(dt.Rows[0]);
            }
            else
            {
                return null;
            }
        }
        public List<Food> GetAllFoodByCategory(string category)
        {
            List<Food> foods = new List<Food>();
            string sql = "select * from food where category = @category";
            DataTable dt = DbUtil.ExecuteDataTable(sql, new MySqlParameter("@category", category));
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Food food = ToFood(row);
                    foods.Add(food);
                }
            }
            return foods;
        }

        public List<Food> GetAllFoodByName(string name)
        {
            List<Food> foods = new List<Food>();
            string sql = "select * from food where cnName like @cnname or enName like @enName";
            DataTable dt = DbUtil.ExecuteDataTable(sql, new MySqlParameter("@cnname",string.Format("%{0}%",name)),
                new MySqlParameter("@enName", string.Format("%{0}%", name)));
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Food food = ToFood(row);
                    foods.Add(food);
                }
            }
            return foods;
        }
        public List<Food> GetAllFood()
        {
            List<Food> foods = new List<Food>();
            string sql = "select * from food";
            DataTable dt = DbUtil.ExecuteDataTable(sql);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Food food = ToFood(row);
                    foods.Add(food);
                }
            }
            return foods;
        }
        public int AddFood(Food food)
        {
            try
            {
                string sql = "INSERT INTO `food`(`cnName`,`enName`,`des`,`price`,`category`,`canDiscount`,`status`,`isHot`,`unit`,`createTime`,`updateTime`,`imageUpdateTime`,`delTime`,`needKC`,`needMaterials`,`isPlan`)VALUES (@cnName,@enName,@des,@price,@category,@canDiscount,@status,@isHot,@unit,@createTime,@updateTime,@imageUpdateTime,@delTime,@needKC,@needMaterials,@isPlan)";
                DbUtil.ExecuteNonQuery(sql,
                    new MySqlParameter("@cnName", food.cnName),
                    new MySqlParameter("@enName", food.enName),
                    new MySqlParameter("@des", food.des),
                    new MySqlParameter("@price", food.price),
                    new MySqlParameter("@category", food.category),
                    new MySqlParameter("@canDiscount", food.canDiscount),
                    new MySqlParameter("@status", food.status),
                    new MySqlParameter("@isHot", food.isHot),
                    new MySqlParameter("@unit", food.unit),
                    new MySqlParameter("@createTime", food.createTime),
                    new MySqlParameter("@updateTime", food.updateTime),
                    new MySqlParameter("@imageUpdateTime", food.imageUpdateTime),
                    new MySqlParameter("@delTime", food.delTime),
                    new MySqlParameter("@needKC", food.needKC),
                    new MySqlParameter("@needMaterials", food.needMaterials),
                    new MySqlParameter("@isPlan", food.isPlan));

                return Convert.ToInt32(DbUtil.ExecuteScalar("SELECT MAX(FOODID) FROM FOOD").ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("添加餐品失败"+ex.Message);
            }
        }
    }
}
