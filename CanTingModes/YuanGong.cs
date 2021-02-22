using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanTingModes
{
    public class YuanGong
    {
        //员工类
        public int YuanGongId { get; set; }//员工编号
        public string YuanGongXingMing { get; set; }//员工姓名
        public string YuanGongGender { get; set; }//员工性别
        public DateTime YuanGongShengRi { get; set; }//员工出生日
        public decimal YuanGongGongZi { get; set; }//员工工资
        public int YuanGongZhiWeiId { get; set; }//员工职位编号
        public int YuanGongShenFengZheng { get; set; }//员工身份证号
    }
}
