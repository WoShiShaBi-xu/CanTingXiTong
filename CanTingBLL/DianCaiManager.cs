using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanTingDAL;
using CanTingModes;

namespace CanTingBLL
{
    public class DianCaiManager
    {
        DianCaiServer dianCaiServer = new DianCaiServer();

        public List<DianCaiBiao> CaiDanChaXun(int zuoWeiId)
        {
            return dianCaiServer.CaiDanChaXun(zuoWeiId);
        }
    }
}
