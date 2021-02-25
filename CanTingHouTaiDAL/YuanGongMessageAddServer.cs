using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CanTingModes;
using System.Data;

namespace CanTingHouTaiDAL
{
    public class YuanGongMessageAddServer
    {
        DBHelper dbh = new DBHelper();

        /// <summary>
        /// 新员工信息的添加
        /// </summary>
        /// <param name="yg"></param>
        /// <returns></returns>
        public int YuanGongMessageAdd(YuanGong yg)
        {
            string sql = "Insert YuanGong(YuanGongXingMing,YuanGongGender,YuanGongShengRi,YuanGongGongZi,YuanGongZhiWeiId,YuanGongShenFengZheng)values(@YuanGongXingMing,@YuanGongGender,@YuanGongShengRi,@YuanGongGongZi,@YuanGongZhiWeiId,@YuanGongShenFengZheng); select @@IDENTITY;";
            SqlParameter[] sp = {
                new SqlParameter("@YuanGongXingMing",yg.YuanGongXingMing),
                new SqlParameter("@YuanGongGender",yg.YuanGongGender),
                new SqlParameter("@YuanGongShengRi",yg.YuanGongShengRi),
                new SqlParameter("@YuanGongGongZi",yg.YuanGongGongZi ),
                new SqlParameter("@YuanGongZhiWeiId",yg.ZhiWei.ZhiWeiId),
                new SqlParameter("@YuanGongShenFengZheng",yg.YuanGongShenFengZheng),
            };
            string count = dbh.ExecuteScalar(sql, sp).ToString();
            return int.Parse(count);
        }

        /// <summary>
        /// 员工信息的修改
        /// </summary>
        /// <param name="yg"></param>
        /// <param name="ygId"></param>
        /// <returns></returns>
        public int UpdateYuanGongMessage(YuanGong yg = null, int ygId = 0)
        {
            string sql = "update [YuanGong] set YuanGongXingMing=@YuanGongXingMing,YuanGongGender=@YuanGongGender,YuanGongShengRi=@YuanGongShengRi,YuanGongGongZi=@YuanGongGongZi,YuanGongZhiWeiId=@YuanGongZhiWeiId,YuanGongShenFengZheng=@YuanGongShenFengZheng where YuanGongId=@YuanGongId";
            SqlParameter[] sp = {
                new SqlParameter("@YuanGongXingMing",yg.YuanGongXingMing),
                new SqlParameter("@YuanGongGender",yg.YuanGongGender),
                new SqlParameter("@YuanGongShengRi",yg.YuanGongShengRi),
                new SqlParameter("@YuanGongGongZi",yg.YuanGongGongZi),
                new SqlParameter("@YuanGongZhiWeiId",yg.ZhiWei.ZhiWeiId),
                new SqlParameter("@YuanGongShenFengZheng",yg.YuanGongShenFengZheng),
                new SqlParameter("@YuanGongId",ygId)
            };
            string count = dbh.ExecuteNonQuery(sql, sp).ToString();
            return int.Parse(count);
        }

        /// <summary>
        /// 将员工信息打印到文本框
        /// </summary>
        /// <param name="studentNo"></param>
        /// <returns></returns>
        public List<YuanGong> PrintMessageText(int ygId)
        {
            List<YuanGong> list = new List<YuanGong>();
            string sql = "select [YuanGongId],[YuanGongXingMing],[YuanGongGender],[YuanGongShengRi],[YuanGongGongZi],z.ZhiWeiMIngCheng,[YuanGongShenFengZheng] from YuanGong y inner join ZhiWei z on y.YuanGongZhiWeiId=z.ZhiWeiId where [YuanGongId]=@YuanGongId";
            SqlParameter sp = new SqlParameter("@YuanGongId", ygId);
            DataTable dt = dbh.GetTable(sql, "YuanGong", sp);
            foreach (DataRow dr in dt.Rows)
            {
                YuanGong stu = new YuanGong
                {
                    YuanGongId = (int)dr["YuanGongId"],
                    YuanGongXingMing = dr["YuanGongXingMing"].ToString(),
                    YuanGongGender = dr["YuanGongGender"].ToString() == "男" ? "男" : "女",
                    YuanGongShengRi = (DateTime)dr["YuanGongShengRi"],
                    YuanGongGongZi = (decimal)dr["YuanGongGongZi"],
                    ZhiWei = new ZhiWei()
                    {
                        ZhiWeiMIngCheng = dr["ZhiWeiMIngCheng"].ToString()
                    },
                    YuanGongShenFengZheng = dr["YuanGongShenFengZheng"].ToString()
                };
                list.Add(stu);
            }
            return list;
        }

        /// <summary>
        /// 删除员工信息
        /// </summary>
        /// <param name="ygId"></param>
        /// <returns></returns>
        public int DelYuanGongMessage(int ygId)
        {
            string sql = "delete YuanGong where YuanGongId=" + ygId;
            int count = dbh.ExecuteNonQuery(sql);
            return count;
        }

        /// <summary>
        /// 员工职位下拉框的显示
        /// </summary>
        /// <returns></returns>
        public List<ZhiWei> YuanGongZhiWeiComboBox()
        {
            List<ZhiWei> list = new List<ZhiWei>();
            string sql = "select [ZhiWeiId],[ZhiWeiMIngCheng] from [ZhiWei]";
            DataTable dt = dbh.GetTable(sql, "ZhiWei");

            foreach (DataRow dr in dt.Rows)
            {
                ZhiWei zw = new ZhiWei
                {
                    ZhiWeiId = (int)dr["ZhiWeiId"],
                    ZhiWeiMIngCheng = dr["ZhiWeiMIngCheng"].ToString()
                };
                list.Add(zw);
            }
            return list;
        }

        public List<YuanGong> SelectPrintDgv(string ygName, bool nan, bool nv)
        {
            List<YuanGong> list = new List<YuanGong>();
            string sql = "select [YuanGongId],[YuanGongXingMing],[YuanGongGender],[YuanGongShengRi],[YuanGongGongZi],z.ZhiWeiMIngCheng,[YuanGongShenFengZheng] from YuanGong y inner join ZhiWei z on y.YuanGongZhiWeiId=z.ZhiWeiId  where 1=1 ";
            SqlParameter[] sp = null;

            if (ygName != "")
            {
                sql += " and YuanGongXingMing like '%" + ygName + "%'";

            }
            if (nan != false)
            {
                sql += " and YuanGongGender=@YuanGongGender";
                sp = new SqlParameter[]
                {
                    new SqlParameter("@YuanGongGender",nan==true?"男":"女")
                };
            }
            if (nv != false)
            {
                sql += " and YuanGongGender=@YuanGongGender";
                sp = new SqlParameter[]
                {
                    new SqlParameter("@YuanGongGender",nv==true?"女":"男")
                };
            }

            DataTable dt = dbh.GetTable(sql, "YuanGong", sp);
            foreach (DataRow dr in dt.Rows)
            {
                YuanGong yg = new YuanGong
                {
                    YuanGongId = (int)dr["YuanGongId"],
                    YuanGongXingMing = dr["YuanGongXingMing"].ToString(),
                    YuanGongGender = dr["YuanGongGender"].ToString() == "男" ? "男" : "女",
                    YuanGongShengRi = (DateTime)dr["YuanGongShengRi"],
                    YuanGongGongZi = (decimal)dr["YuanGongGongZi"],
                    ZhiWei = new ZhiWei()
                    {
                        ZhiWeiMIngCheng = dr["ZhiWeiMIngCheng"].ToString()
                    },
                    YuanGongShenFengZheng = dr["YuanGongShenFengZheng"].ToString()
                };
                list.Add(yg);
            }
            return list;
        }
    }
}
