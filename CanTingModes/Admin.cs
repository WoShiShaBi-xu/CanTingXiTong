using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanTingModes
{
    [Serializable]
    public class Admin
    {
        //管理员类
        public int AdminId { get; set; }//管理员编号
        private string adminUser;//管理员账号
        public string AdminUser
        {
            get { return adminUser; }
            set { adminUser = value; }
        }

        private string adminPwd;//管理员密码
        public string AdminPwd
        {
            get { return adminPwd; }
            set { adminPwd = value; }
        }
        public string AdminEmail { get; set; }//管理员邮箱

    }
}
