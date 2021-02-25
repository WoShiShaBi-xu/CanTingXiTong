using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanTingModes;
using System.Data;
using System.Data.SqlClient;
namespace CanTingHouTaiDAL
{
    public class LouCengSeriver
    {
        DBHelper db = new DBHelper();
        List<CengShu> list = null;
        /// <summary>
        /// 加载楼层表
        /// </summary>
        /// <returns></returns>
        public List<CengShu> SearchLouCeng() {
            string sql = "select CengShuId, CengShuMiaoShu, CengShuShiFouKeYong from CengShu";
            list = new List<CengShu>();
            DataTable dt = db.GetTable(sql,"CengShu");
            foreach (DataRow item in dt.Rows)
            {
                CengShu cs = new CengShu() { 
                    CengShuId=int.Parse(item["CengShuId"].ToString()),
                    CengShuMiaoShu=item["CengShuMiaoShu"].ToString(),
                    CengShuShiFouKeYong=item["CengShuShiFouKeYong"].ToString()
                };
                list.Add(cs);
            }
            return list;
        }
        public bool LouCenUpDate(string bol,int id){
            string sql = "update CengShu set CengShuShiFouKeYong=@bol where CengShuId=@id";
            SqlParameter [ ] sp ={
                new SqlParameter("@bol",bol),
                new SqlParameter("@id",id)
            };
           int count= db.ExecuteNonQuery(sql,sp);
            if (count>0) {
                return true;
            }
            return false;
        
        }
    }
}
