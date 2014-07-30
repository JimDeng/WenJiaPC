using System;
using System.Collections.Generic;
using System.Text;
using yoogacatering.Entity;
using System.Data;
using MySql.Data.MySqlClient;

namespace yoogacatering.Service
{
    class FoodCategoryService
    {
        private FoodCategory ToCategory(DataRow row)
        {
            FoodCategory category = new FoodCategory();
            category.id = (int)row["id"];
            category.categoryName = (string)row["categoryName"];
            category.categoryBelong = (string)row["categoryBelong"];
            return category;
        }

        public List<FoodCategory> GetAllCategory()
        {
            string sql = "select * from foodcategory";
            DataTable dt = DbUtil.ExecuteDataTable(sql);
            List<FoodCategory> categorys = new List<FoodCategory>();
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    FoodCategory category = ToCategory(row);
                    categorys.Add(category);

                }
            }
            return categorys;
        }
        public List<FoodCategory> GetAllCategoryByBelong(string belong)
        {
            string sql = "select * from foodcategory where categorybelong = @belong";
            DataTable dt = DbUtil.ExecuteDataTable(sql, new MySqlParameter("@belong", belong));
            List<FoodCategory> categorys = new List<FoodCategory>();
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    FoodCategory category = ToCategory(row);
                    categorys.Add(category);

                }
            }
            return categorys;
        }

        public void AddCategory(FoodCategory category)
        {
            try
            {
                string sql = "INSERT INTO `FoodCategory`(`categoryName`,`categoryBelong`)VALUES (@categoryName,@categoryBelong)";
                DbUtil.ExecuteNonQuery(sql, new MySqlParameter("@categoryName", category.categoryName),
                    new MySqlParameter("@categoryBelong", category.categoryBelong));
            }
            catch (Exception ex)
            {
                throw new Exception("添加分类失败" + ex.Message);
            }
        }

        public void DelCategory(string categoryName)
        {
            try
            {
                string sql = "delete from foodcategory where categoryname = @categoryname";
                DbUtil.ExecuteNonQuery(sql, new MySqlParameter("@categoryname", categoryName));
            }
            catch (Exception ex)
            {
                throw new Exception("删除分类失败"+ex.Message);
            }
        }
    }
}
