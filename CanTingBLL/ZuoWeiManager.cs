using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanTingDAL;
using CanTingModes;

namespace CanTingBLL
{
    public class ZuoWeiManager
    {
        ZuoWeiServer zuoWeiServer = new ZuoWeiServer();
        /// <summary>
        /// 查询座位基本信息
        /// </summary>
        /// <returns></returns>

        public List<ZuoWei> QueryZuoWei()
        {
            return zuoWeiServer.QueryZuoWei();
        }
    }
}
