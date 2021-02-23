using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanTingHouTaiDAL;
using CanTingModes;

namespace CanTingHouTaiBLL
{
    public class ZuoWeiManager
    {
        ZuoWeiServer zuoWeiServer = new ZuoWeiServer();

        public List<ZuoWei> ChaXunZuoWei()
        {
            return zuoWeiServer.ChaXunZuoWei();
        }
    }
}
