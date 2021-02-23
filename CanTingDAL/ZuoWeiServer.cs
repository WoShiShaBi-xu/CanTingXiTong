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
    public class ZuoWeiServer
    {
        DBHelper db = new DBHelper();
        List<ZuoWei> zuoWei = new List<ZuoWei>();
        public List<ZuoWei> QueryZuoWei()
        {
            string sql = "select ZuoWeiId, ZuoWeiBeiZhu, ZuoWeiLiuShuiDanId, ZuoWeiZhuangTaiId, cs.CengShuMiaoShu, ZuoWeiTingYong, ZuoWeiYuanGongId from ZuoWei zw inner join CengShu cs on zw.CengShuId =cs.CengShuId";
            DataTable dt = db.GetTable(sql, "ZuoWeiBiao");
            foreach (DataRow item in dt.Rows)
            {
                ZuoWei zw = new ZuoWei
                {
                    ZuoWeiId = (int)item["ZuoWeiId"],
                    ZuoWeiBeiZhu = item["ZuoWeiBeiZhu"].ToString(),
                    ZuoWeiLiuShuiDanId = (int)item["ZuoWeiLiuShuiDanId"],
                    ZuoWeiZhuangTaiId = (int)item["ZuoWeiZhuangTaiId"],
                    CengShu =new CengShu() { CengShuMiaoShu = item["cs.CengShuMiaoShu"].ToString ()},
                    ZuoWeiTingYong = item["ZuoWeiTingYong"].ToString(),
                    ZuoWeiYuanGongId = (int)item["ZuoWeiYuanGongId"]
                };
                zuoWei.Add(zw);
            }
            return zuoWei;
        }
    }
}
