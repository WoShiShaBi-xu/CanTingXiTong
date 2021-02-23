using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CanTingModes;

namespace CanTingDAL
{
    public class CaiPinServer
    {
        DBHelper db = new DBHelper();
        List<CaiPin> caiPin = new List<CaiPin>();
        public List<CaiPin> QueryCaiPin()
        {
            string sql = "select CaiPinId, caiPinMingZi, CaiPinJiaGe, CaiPinTeJia, CaiPinDianDanShu, cf.CaiPinFenLeiMiaoShu, CaiPinKuCun from CaiPin cp inner join CalPinFenLei cf on cf.CaiPinFenLeiId =cp.CaiPinFenLeiId";
            DataTable dt = db.GetTable(sql, "CaiPinBiao");
            foreach (DataRow item in dt.Rows)
            {
                CaiPin cp = new CaiPin
                {
                    CaiPinId = (int)item["CaiPinId"],
                    caiPinMingZi = item["caiPinMingZi"].ToString(),
                    CaiPinJiaGe = (double)item["CaiPinJiaGe"],
                    CaiPinTeJia = (double)item["CaiPinTeJia"],
                    CaiPinDianDanShu = (int)item["CaiPinDianDanShu"],
                    CaiPinFenLei =new CalPinFenLei() {
                       CaiPinFenLeiMiaoShu= item["cf.CaiPinFenLeiMiaoShu"].ToString()
                    },
                    CaiPinKuCun = (int)item["CaiPinKuCun"]
                };
                caiPin.Add(cp);
            }
            return caiPin;
        }
    }
}
