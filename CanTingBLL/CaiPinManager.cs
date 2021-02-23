using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanTingDAL;
using CanTingModes;


namespace CanTingBLL
{
    public class CaiPinManager
    {
        CaiPinServer caiPinServer = new CaiPinServer();
        /// <summary>
        /// 查询菜品基本信息
        /// </summary>
        /// <returns></returns>
        public List<CaiPin> QueryCaiPin() {
            return caiPinServer.QueryCaiPin();
        }
    }
}
