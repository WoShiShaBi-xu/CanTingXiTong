using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanTingModes
{
    public class LiuShuiDan
    {
        //流水单类
        public int LiuShuiDanId { get; set; }//流水单编号
        public string LiuShuiDanTxtWenJianMing { get; set; }//流水单文件名
        public DateTime LiuShuiDanShiJian { get; set; }//流水单文件
        public decimal LiuShuiDanJinEHuiZong { get; set; }//流水单金额汇总
        public string LiuShuiDanBeiZhu { get; set; }//流水单备注
        public int LiuShuiDanZhiFuLeiBieId { get; set; }//流水单支付类别编号
    }
}
