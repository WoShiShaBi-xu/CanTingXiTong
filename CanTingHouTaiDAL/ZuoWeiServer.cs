using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CanTingModes;

namespace CanTingHouTaiDAL
{
    class ZuoWeiServer
    {
        DBHelper db = new DBHelper();
        public List<ZuoWei> ChaXunZuoWei()
        {
            string sql = "select ZuoWeiId, ZuoWeiBeiZhu, cs.CengShuMiaoShu, ZuoWeiTingYong from ZuoWei zw inner join CengShu cs on zw.CengShuId =cs.CengShuId";
            DataTable dt = db.GetTable(sql, "Student");
            List<ZuoWei> list = new List<ZuoWei>();
            foreach (DataRow dr in dt.Rows)
            {
                ZuoWei zuoWei = new ZuoWei()
                {
                    ZuoWeiId = (int)dr["ZuoWeiId"],
                    ZuoWeiBeiZhu = dr["ZuoWeiBeiZhu"].ToString(),
                     CengShu = new CengShu()
                     {
                         CengShuMiaoShu=dr["cs.CengShuMiaoShu"].ToString()
                     },
                    ZuoWeiTingYong = dr["ZuoWeiTingYong"].ToString()
                };
                list.Add(zuoWei);
            }
            return list;
        }
    }
}
