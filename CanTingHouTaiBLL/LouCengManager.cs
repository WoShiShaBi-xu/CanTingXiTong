using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanTingHouTaiDAL;
using CanTingModes;

namespace CanTingHouTaiBLL
{
    public class LouCengManager
    {
        LouCengSeriver louCengSeriver = new LouCengSeriver();
        public List<CengShu> SearchLouCeng() {
            return louCengSeriver.SearchLouCeng();
        }
    }
}
