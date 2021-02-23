using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanTingModes;
using System.Data.SqlClient;
using System.Data;

namespace CanTingDAL
{
    [Serializable]
    public class LoginJieMianServer
    {
        DBHelper dbh = new DBHelper();

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userPwd"></param>
        /// <returns></returns>
        public Admin SelectWhere(string userId, string userPwd)
        {
            Admin admin = null;
            string sql = "select [AdminUser],[AdminPwd] from admin where [AdminUser]=@AdminUser and [AdminPwd]=@AdminPwd";
            SqlParameter[] sp = {
                new SqlParameter("@AdminUser",userId),
                new SqlParameter("@AdminPwd",userPwd)
            };
            SqlDataReader sdr = dbh.ExecuteReader(sql, sp);
            if (sdr.Read())
            {
                admin = new Admin
                {
                    AdminUser = sdr["AdminUser"].ToString(),
                    AdminPwd = sdr["AdminPwd"].ToString()
                };
            }
            sdr.Close();
            return admin;
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public int AddUserAccountPwd(Admin admin) {
            string sql = "Insert Admin(AdminUser,AdminPwd,AdminEmail)values(@AdminUser,@AdminPwd,@AdminEmail)";
            SqlParameter[] sp = {
                new SqlParameter("@AdminUser",admin.AdminUser),
                new SqlParameter("@AdminPwd",admin.AdminPwd),
                new SqlParameter("@AdminEmail",admin.AdminEmail)
            };
            int count = dbh.ExecuteNonQuery(sql, sp);
            return count;
        }

        /// <summary>
        /// 忘记密码
        /// </summary>
        /// <param name="admin"></param>
        /// <param name="adminId"></param>
        /// <returns></returns>
        public Admin UpdateAccountPwd(string adminUser,string adminEmail) {
            Admin admin = null;
            string sql = "select AdminPwd from Admin where AdminUser= @AdminUser and AdminEmail= @AdminEmail";
            SqlParameter[] sp = {
                new SqlParameter("@AdminUser",adminUser),
                new SqlParameter("@AdminEmail",adminEmail)
            };
            SqlDataReader sdr = dbh.ExecuteReader(sql, sp);
            if (sdr.Read())
            {
                admin = new Admin();
                admin.AdminPwd = sdr["AdminPwd"].ToString();
            }
            sdr.Close();
            return admin;
        }
    }
}
