using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanTingModes
{
    public class YuDing
    {
        //预定座位类
        public int YuDingId { get; set; }//预定号
        public string YuDingXingMing { get; set; }//预定姓名
        public string YuDingPhone { get; set; }//预定电话
        public DateTime YuDingShiJian { get; set; }//预定时间
        public ZuoWei YuDingZuoWeiId { get; set; }//预定座位编号
        public decimal YuDingJinE { get; set; }//预定金额
    }
}
