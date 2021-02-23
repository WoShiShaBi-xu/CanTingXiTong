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
            string sql = "select ZuoWeiId, ZuoWeiBeiZhu, ZuoWeiLiuShuiDanId, ZuoWeiZhuangTaiId, CengShuId, ZuoWeiTingYong, ZuoWeiYuanGongId from ZuoWei";
            DataTable dt = db.GetTable(sql, "ZuoWeiBiao");
            foreach (DataRow item in dt.Rows)
            {
                ZuoWei zw = new ZuoWei
                {
                    ZuoWeiId = (int)item["ZuoWeiId"],
                    ZuoWeiBeiZhu = item["ZuoWeiBeiZhu"].ToString(),
                    ZuoWeiLiuShuiDanId = (int)item["ZuoWeiLiuShuiDanId"],
                    ZuoWeiZhuangTaiId = (int)item["ZuoWeiZhuangTaiId"],
                    CengShuId = (int)item["CengShuId"],
                    ZuoWeiTingYong = item["ZuoWeiTingYong"].ToString(),
                    ZuoWeiYuanGongId = (int)item["ZuoWeiYuanGongId"]
                };
                zuoWei.Add(zw);
            }
            return zuoWei;
        }
    }
}
