using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using yoogacatering.Entity;
using MySql.Data.MySqlClient;

namespace yoogacatering.Service
{
    class OpersService
    {
        public string GetOperNameByOperid(string operid)
        {
            string sql = "select operName from opers where operID = @operID";
            return DbUtil.ExecuteScalar(sql, new MySqlParameter("@operID",operid)).ToString();
        }
        public bool Login(string operid, string operPwd)
        {
            string sql = "select * from Opers where operID = @operID and operPws = @operPws";
            int count = Convert.ToInt32(DbUtil.ExecuteScalar(sql, new MySqlParameter("@operID", operid), new MySqlParameter("@operPws",operPwd)));
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public List<string> GetAllNoGrantRights(int id)
        {
            List<string> rights = new List<string>();
            string sql = "select * from SystemRights where rightName not in (select rightsName from OpersRights where operid = @id)";
            DataTable dt = DbUtil.ExecuteDataTable(sql, new MySqlParameter("@id", id));
            foreach (DataRow row in dt.Rows)
            {
                rights.Add(row["rightName"].ToString());
            }
            return rights;
        }
        public List<string> GetAllGrantRights(int id)
        {
            List<string> rights = new List<string>();
            string sql = "select * from OpersRights where operid = @id";
            DataTable dt = DbUtil.ExecuteDataTable(sql,new MySqlParameter("@id",id));
            foreach (DataRow row in dt.Rows)
            {
                rights.Add(row["rightsName"].ToString());
            }
            return rights;
        }
        public void DelOpers(int id)
        {
            string sql = "delete from Opers where id = @id";
            DbUtil.ExecuteNonQuery(sql,new MySqlParameter("@id",id));
        }
        public void UpdateOpers(Opers op)
        {
            string sql = "UPDATE `Opers` SET `operID` = @operID,`operName` = @operName,`operSex` = @operSex,`operPws` = @operPws,`operPos` = @operPos WHERE `id` = @id";
            DbUtil.ExecuteNonQuery(sql,
                new MySqlParameter("@operID", op.operID),
                new MySqlParameter("@operName", op.operName),
                new MySqlParameter("@operSex", op.operSex),
                new MySqlParameter("@operPws", op.operPws),
                new MySqlParameter("@operPos", op.operPos),
                new MySqlParameter("@id", op.id));

            sql = "delete from OpersRights where operid = @operid";
            DbUtil.ExecuteNonQuery(sql,new MySqlParameter("@operid",op.id));

            foreach (string s in op.openGrantRigts)
            {
                sql = "insert into OpersRights(operid,rightsName) values (@operid,@rightsName)";
                DbUtil.ExecuteNonQuery(sql, new MySqlParameter("@operid", op.id), new MySqlParameter("@rightsName", s));
            }

        }
        public void AddOpers(Opers op)
        {
            string sql = "INSERT INTO `Opers`(`operID`,`operName`,`operSex`,`operPws`,`operPos`)VALUES (@operID,@operName,@operSex,@operPws,@operPos)";
            DbUtil.ExecuteNonQuery(sql,
                new MySqlParameter("@operID", op.operID),
                new MySqlParameter("@operName", op.operName),
                new MySqlParameter("@operSex", op.operSex),
                new MySqlParameter("@operPws", op.operPws),
                new MySqlParameter("@operPos", op.operPos));

            foreach (string s in op.openGrantRigts)
            {
                sql = "insert into OpersRights(operid,rightsName) values (@operid,@rightsName)";
                DbUtil.ExecuteNonQuery(sql, new MySqlParameter("@operid", op.id), new MySqlParameter("@rightsName",s));
            }
        }

        public Opers GetOpersByOperID(string operID)
        {
            string sql = "select * from Opers where operID = @operID";
            DataTable dt = DbUtil.ExecuteDataTable(sql, new MySqlParameter("@operID", operID));
            if (dt.Rows.Count > 0)
            {
                Opers op = ToOpers(dt.Rows[0]);
                op.openGrantRigts = GetAllGrantRights(op.id);
                op.openNotGrantGights = GetAllNoGrantRights(op.id);
                return op;
            }
            else
            {
                return null;
            }
        }
        public Opers GetOpersByID(int id)
        {
            string sql = "select * from Opers where id = @id";
            DataTable dt = DbUtil.ExecuteDataTable(sql,new MySqlParameter("@id",id));
            Opers op = ToOpers(dt.Rows[0]);
            op.openGrantRigts = GetAllGrantRights(op.id);
            op.openNotGrantGights = GetAllNoGrantRights(op.id);
            return op;
        }
        public Opers ToOpers(DataRow row)
        {
            Opers op = new Opers();
            op.id = (int)row["id"];
            op.operID = (string)row["operID"];
            op.operName = (string)row["operName"];
            op.operPos = (string)row["operPos"];
            op.operPws = (string)row["operPws"];
            op.operSex = (string)row["operSex"];
            return op;
        }

        public List<Opers> SearchOpers(string operid, string opername, string operPos, string operSex)
        {
            List<Opers> opers = new List<Opers>();
            //string sql = "select * from opers where operid like @operid and opername like @opername and operPos like @operPos and operSex like @operSex";
            string sql = "select * from opers where operid like @operid and opername like @opername and operPos like @operPos and operSex like @operSex";
            //DataTable dt = DbUtil.ExecuteDataTable(sql,
            //    new MySqlParameter("@operid", string.Format("%{0}%", operid)),
            //    new MySqlParameter("@opername", string.Format("%{0}%", opername)),
            //    new MySqlParameter("@operPos", string.Format("%{0}%", operPos)),
            //    new MySqlParameter("@operSex", string.Format("%{0}%", operSex)));

            DataTable dt = DbUtil.ExecuteDataTable(sql,
                new MySqlParameter("@operid", string.Format("%{0}%", operid)),
                new MySqlParameter("@opername", string.Format("%{0}%",opername)),
                new MySqlParameter("@operPos", string.Format("%{0}%", operPos)),
                new MySqlParameter("@operSex", string.Format("%{0}%", operSex)));
            if (dt == null)
            {
                return null;
            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {
                    Opers op = ToOpers(row);
                    op.openGrantRigts = GetAllGrantRights(op.id);
                    op.openNotGrantGights = GetAllNoGrantRights(op.id);
                    opers.Add(op);
                }
                return opers;
            }
        }

        public List<Opers> GetAllOpers()
        {
            List<Opers> opers = new List<Opers>();
            string sql = "select * from Opers";
            DataTable dt = DbUtil.ExecuteDataTable(sql);
            if (dt == null)
            {
                return null;
            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {
                    Opers op = ToOpers(row);
                    op.openGrantRigts = GetAllGrantRights(op.id);
                    op.openNotGrantGights = GetAllNoGrantRights(op.id);
                    opers.Add(op);
                }
                return opers;
            }
        }
    }
}
