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
    class ZuoWeiServer
    {
        DBHelper db = new DBHelper();
        List<ZuoWei> zuoWei = new List<ZuoWei>();
        public DataTable QueryZuoWei()
        {
            string sql = "select ZuoWeiId, ZuoWeiBeiZhu, ZuoWeiLiuShuiDanId, ZuoWeiZhuangTaiId, CengShuId, ZuoWeiTingYong, ZuoWeiYuanGongId from ZuoWei";
            DataTable dt = db.GetTable(sql, "ZuoWeiBiao");
            foreach (DataRow item in dt.Rows)
            {
                ZuoWei stu = new ZuoWei
                {
                    //LoginPwd = item["ZuoWeiId"].ToString(),
                    //StudentName = item["ZuoWeiBeiZhu"].ToString(),
                    //Gender = item["ZuoWeiLiuShuiDanId"].ToString(),
                    //GradeId = item["ZuoWeiZhuangTaiId"].ToString(),
                    //Phone = item["CengShuId"].ToString(),
                    //Address = item["ZuoWeiTingYong"].ToString(),
                    //Birthday = item["ZuoWeiYuanGongId"].ToString()
                };
                zuoWei.Add(stu);
            }
            return dt;
        }
    }
}
