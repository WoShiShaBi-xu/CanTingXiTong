using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanTingModes;
using CanTingDAL;

namespace CanTingBLL
{
    [Serializable]
    
    public class LoginManager
    {
        LoginJieMianServer ljms = new LoginJieMianServer();

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userPwd"></param>
        /// <returns></returns>
        public Admin LoadAdmin(string userId, string userPwd)
        {
            return ljms.SelectWhere(userId, userPwd);
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public int LoadRegistration(Admin admin) {
            return ljms.AddUserAccountPwd(admin);
        }

        /// <summary>
        /// 忘记密码
        /// </summary>
        /// <param name="admin"></param>
        /// <param name="adminId"></param>
        /// <returns></returns>
        public Admin LoadForgetPassword(string adminUser,string adminEmail) {
            return ljms.UpdateAccountPwd(adminUser,adminEmail);
        }
    }
}
