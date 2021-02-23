using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanTingModes
{
    public class CaiPin
    {
        //菜品类
        public int CaiPinId { get; set; }//菜品编号
        public string caiPinMingZi { get; set; }//菜品名字
        public double CaiPinJiaGe { get; set; }//菜品价格
        public double CaiPinTeJia { get; set; }//菜品特价
        public int CaiPinDianDanShu { get; set; }//菜品点单数
        public CalPinFenLei CaiPinFenLei { get; set; }//菜品分类编号
        public int CaiPinKuCun { get; set; }//菜品库存

    }
}
