using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanTingModes
{
    public class ZuoWei
    {
        //座位类
        public int ZuoWeiId { get; set; }//座位编号
        public string ZuoWeiBeiZhu { get; set; }//座位备注
        public int ZuoWeiLiuShuiDanId { get; set; }//座位流水单编号
        public int ZuoWeiZhuangTai { get; set; }//座位状态
        public int CengShuId { get; set; }//楼层编号
        public string ZuoWeiTingYong { get; set; }//座位停用设置
        public int ZuoWeiYuanGongId { get; set; }//座位负责员工编号
    }
}
    