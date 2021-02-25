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

        public List<ZuoWei> ChaXunZuoWei(int cengShuId=-1)
        {
            return zuoWeiServer.ChaXunZuoWei(cengShuId);
        }

        public int AddZuoWei(List<ZuoWei> list) {
            return zuoWeiServer.AddZuoWei(list);
        }
        public bool UpDateZuoWei(string bol,int id){
            return zuoWeiServer.UpDateZuoWei(bol,id);
        }
    }
}
