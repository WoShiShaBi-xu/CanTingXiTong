using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanTingHouTaiDAL;
using CanTingModes;

namespace CanTingHouTaiBLL
{
    public class CaiPinFenLeiManager
    {
        CaiPinFenLeiSeriver caiPinFenLeiSeriver = new CaiPinFenLeiSeriver();
        public List<CalPinFenLei> SearchCaiPinFenLei() {
            return caiPinFenLeiSeriver.SearchCaiPinFenLei();
        }
    }
}
