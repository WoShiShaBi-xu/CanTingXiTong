using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CanTingModes;
using System.Data.SqlClient;

namespace CanTingHouTaiDAL
{
    public class ZuoWeiServer
    {
        DBHelper db = new DBHelper();
        /// <summary>
        /// 加载座位
        /// </summary>
        /// <returns></returns>
        public List<ZuoWei> ChaXunZuoWei(int cengShuId=-1)
        {
            string sql = "select ZuoWeiId, ZuoWeiBeiZhu, cs.CengShuMiaoShu, ZuoWeiTingYong from ZuoWei zw inner join CengShu cs on zw.CengShuId =cs.CengShuId where 1=1 ";
            if (cengShuId!=-1)
            {
                sql += " and cs.CengShuId="+cengShuId;
            }
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
                         CengShuMiaoShu=dr["CengShuMiaoShu"].ToString()
                     },
                    ZuoWeiTingYong = dr["ZuoWeiTingYong"].ToString()
                };
                list.Add(zuoWei);
            }
            return list;
        }

        public int AddZuoWei(List<ZuoWei> list) {
            int count = 0;
            foreach (ZuoWei item in list)
            {
                string sql = "insert into ZuoWei(ZuoWeiBeiZhu, ZuoWeiZhuangTaiId, CengShuId, ZuoWeiTingYong)values(@ZuoWeiBeiZhu, @ZuoWeiZhuangTaiId, @CengShuId, @ZuoWeiTingYong)";
                SqlParameter[] sp = {
                    new SqlParameter("@ZuoWeiBeiZhu",item.ZuoWeiBeiZhu),
                    new SqlParameter("@ZuoWeiZhuangTaiId",item.ZuoWeiZhuangTaiId),
                    new SqlParameter("@CengShuId",item.CengShu.CengShuId),
                    new SqlParameter("@ZuoWeiTingYong",item.ZuoWeiTingYong)
                };
                count = db.ExecuteNonQuery(sql,sp);
            }
            return count;
        }
        public bool UpDateZuoWei( string bol , int id ) {
            string sql = "update ZuoWei set ZuoWeiTingYong=@bol where ZuoWeiId=@id";
            SqlParameter [ ] sp ={
                new SqlParameter("@bol",bol),
                new SqlParameter("@id",id)
            };

            int count = db.ExecuteNonQuery( sql , sp );
            if ( count > 0 ) {
                return true;
            }
            return false;
        }
    }
}
