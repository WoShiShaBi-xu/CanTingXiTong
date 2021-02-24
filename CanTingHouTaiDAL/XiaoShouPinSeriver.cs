using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanTingModes;
using System.Data;

namespace CanTingHouTaiDAL
{
    public class XiaoShouPinSeriver//销售品数据访问层类
    {
        DBHelper db = new DBHelper();
        List<CaiPin> list = new List<CaiPin>();
        /// <summary>
        /// 销售品的查询
        /// </summary>
        /// <returns></returns>
        public List<CaiPin> SearchXiaoShouPin(int caiPinFenLeiId=-1) {
            string sql = "select CaiPinId, caiPinMingZi, CaiPinJiaGe, CaiPinTeJia, CaiPinDianDanShu, f.CaiPinFenLeiMiaoShu,f.CaiPinFenLeiId, CaiPinKuCun, d.DanWeiMiaoShu,d.DanWeiId from CaiPin c inner join CalPinFenLei f on f.CaiPinFenLeiId=c.CaiPinFenLeiId inner join DanWei d on d.DanWeiId=c.CaiPinDanWeiId where 1=1 ";
            if (caiPinFenLeiId!=-1)
            {
                sql += " and f.CaiPinFenLeiId="+caiPinFenLeiId;
            }
            DataTable dt = db.GetTable(sql,"CaiPin");
            foreach (DataRow item in dt.Rows)
            {
                CaiPin c = new CaiPin() {
                    caiPinMingZi = item["caiPinMingZi"].ToString(),
                    CaiPinId = int.Parse(item["CaiPinId"].ToString()),
                    CaiPinDianDanShu = int.Parse(item["CaiPinDianDanShu"].ToString()),
                    CaiPinFenLei = new CalPinFenLei() {
                        CaiPinFenLeiId = int.Parse(item["CaiPinFenLeiId"].ToString()),
                        CaiPinFenLeiMiaoShu = item["CaiPinFenLeiMiaoShu"].ToString()
                    },
                    CaiPinJiaGe = Double.Parse(item["CaiPinJiaGe"].ToString()),
                    CaiPinTeJia=Double.Parse(item["CaiPinTeJia"].ToString()),
                    CaiPinKuCun=int.Parse(item["CaiPinKuCun"].ToString()),
                    DanWei=new DanWei() {
                        DanWeiId=int.Parse(item["DanWeiId"].ToString()),
                        DanWeiMiaoShu=item["DanWeiMiaoShu"].ToString()
                    }
                };
                list.Add(c);
            }
            return list;
        }
    }
}
