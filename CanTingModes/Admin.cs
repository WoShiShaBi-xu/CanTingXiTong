using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanTingModes
{
    public class Admin
    {
        //管理员类
        public int AdminId { get; set; }//管理员编号
        public string AdminUser { get; set; }//管理员账号
        public string AdminPwd { get; set; }//管理员密码
        public string AdminEmail { get; set; }//管理员邮箱

    }
}
