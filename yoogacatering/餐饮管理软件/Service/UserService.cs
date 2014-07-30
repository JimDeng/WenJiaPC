using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using yoogacatering.Entity;

namespace yoogacatering.Service
{
    class UserService
    {
        public void AddAUser(User user)
        {
            try
            {
                string sql = "INSERT INTO `yooga`.`auser`(`name`,`UserID`,`UserPwd`,`UserSex`,`UserPosition`)VALUES(@name,@UserID,@UserPwd,@UserSex,@UserPosition);";
                DbUtil.ExecuteNonQuery(sql,
                    new MySqlParameter("@name", user.UserName),
                    new MySqlParameter("@UserID", user.UserID),
                    new MySqlParameter("@UserPwd", user.UserPwd),
                    new MySqlParameter("@UserSex", user.UserSex),
                    new MySqlParameter("@UserPosition", user.UserPosition));
            }
            catch (Exception ex)
            {
                throw new Exception("新增失败" + ex.Message);
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                string sql = "UPDATE `yooga`.`auser` SET `name` = @name,`UserID` = @UserID,`UserPwd` = @UserPwd,`UserSex` = @UserSex,`UserPosition` = @UserPosition where `id` = @id";
                DbUtil.ExecuteNonQuery(sql,
                    new MySqlParameter("@name", user.UserName),
                    new MySqlParameter("@UserID", user.UserID),
                    new MySqlParameter("@UserPwd", user.UserPwd),
                    new MySqlParameter("@UserSex", user.UserSex),
                    new MySqlParameter("@UserPosition", user.UserPosition),
                    new MySqlParameter("@id", user.id));
            }
            catch (Exception ex)
            {
                throw new Exception("更新失败" + ex.Message);
            }
        }

        public void DelUser(int id)
        {
            try
            {
                string sql = "UPDATE `yooga`.`auser` SET `flag` = 1 where `id` = @id";
                DbUtil.ExecuteNonQuery(sql, new MySqlParameter("@id", id));
            }
            catch (Exception ex)
            {
                throw new Exception("删除失败" + ex.Message);
            }
        }
        public static User ToUser(DataRow row)
        {
            User user = new User();
            user.id = (int)row["id"];
            user.UserID = (string)row["UserID"];
            user.UserName = (string)row["name"];
            user.UserPosition = (string)row["UserPosition"];
            user.UserPwd = (string)row["UserPwd"];
            user.UserSex = (string)row["UserSex"];
            return user;
        }
        public List<User> GetAllNotDelUser()
        {
            try
            {
                List<User> users = new List<User>();
                string sql = "select * from auser where flag = 0";
                DataTable dt = DbUtil.ExecuteDataTable(sql);
                foreach (DataRow row in dt.Rows)
                {
                    User user = ToUser(row);
                    users.Add(user);
                }
                return users;
            }
            catch (Exception ex)
            {
                throw new Exception("查询所有用户失败" + ex.Message);
            }
        }
    }
}
