using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanTingHouTaiDAL;
using CanTingModes;
namespace CanTingHouTaiBLL {
    public class YuDingManager {
        YuDinServer yu = new YuDinServer();
        public List<YuDing> YuDinQuery(string DataTime){
            return yu.YuDinQuery( DataTime );
        }
    }
}
