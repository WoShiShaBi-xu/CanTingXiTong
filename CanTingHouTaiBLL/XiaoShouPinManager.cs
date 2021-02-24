using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanTingHouTaiDAL;
using CanTingModes;

namespace CanTingHouTaiBLL
{
    public class XiaoShouPinManager//销售品业务层
    {
        XiaoShouPinSeriver xiaoShouPinSeriver = new XiaoShouPinSeriver();
        /// <summary>
        /// 返回销售品的数据
        /// </summary>
        /// <returns></returns>
        public List<CaiPin> SearchXiaoShouPin(int caiPinFenLeiId=-1) {
            return xiaoShouPinSeriver.SearchXiaoShouPin(caiPinFenLeiId);
        }
    }
}
