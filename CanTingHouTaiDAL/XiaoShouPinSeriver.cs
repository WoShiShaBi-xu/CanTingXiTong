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
    public class XiaoShouPinSeriver//销售品数据访问层类
    {
        DBHelper db = new DBHelper();
        List<CaiPin> list = null;
        /// <summary>
        /// 销售品的查询
        /// </summary>
        /// <returns></returns>
        public List<CaiPin> SearchXiaoShouPin(int caiPinFenLeiId=-1,int count=1) {
            list = new List<CaiPin>();
            string sql = "select CaiPinId, caiPinMingZi, CaiPinJiaGe, CaiPinTeJia, CaiPinDianDanShu, f.CaiPinFenLeiMiaoShu,f.CaiPinFenLeiId, CaiPinKuCun, d.DanWeiMiaoShu,d.DanWeiId from (select ROW_NUMBER() over (order by CaiPinId)rowNum,* from CaiPin where 1=1 ";
            SqlParameter sp = new SqlParameter("@count",count);
            if (caiPinFenLeiId!=-1)
            {
                sql += " and CaiPinFenLeiId="+caiPinFenLeiId;
            }
            sql += ")s  inner join CalPinFenLei f on f.CaiPinFenLeiId=s.CaiPinFenLeiId inner join DanWei d on d.DanWeiId=s.CaiPinDanWeiId   where  rowNum Between( @count - 1 ) * 10 + 1 and @count* 10";
            DataTable dt = db.GetTable(sql,"CaiPin",sp);
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

        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="caiPinId"></param>
        /// <returns></returns>
        public int DeleteXiaoShouPin(int caiPinId) {
            string sql = "delete CaiPin where CaiPinId="+caiPinId;
            return db.ExecuteNonQuery(sql);
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="caiPin"></param>
        /// <returns></returns>
        public int ChangerXiaoShouPin(CaiPin caiPin) {
            string sql = "update CaiPin set caiPinMingZi=@caiPinMingZi, CaiPinJiaGe=@CaiPinJiaGe, CaiPinTeJia=@CaiPinTeJia, CaiPinDianDanShu=@CaiPinDianDanShu, CaiPinFenLeiId=@CaiPinFenLeiId, CaiPinKuCun=@CaiPinKuCun, CaiPinDanWeiId=@CaiPinDanWeiId where CaiPinId=@caiPinId";
            SqlParameter[] sp = { 
                new SqlParameter("@caiPinMingZi",caiPin.caiPinMingZi),
                new SqlParameter("@CaiPinJiaGe",caiPin.CaiPinJiaGe),
                new SqlParameter("@CaiPinTeJia",caiPin.CaiPinTeJia),
                new SqlParameter("@CaiPinDianDanShu",caiPin.CaiPinDianDanShu),
                new SqlParameter("@CaiPinFenLeiId",caiPin.CaiPinFenLei.CaiPinFenLeiId),
                new SqlParameter("@CaiPinKuCun",caiPin.CaiPinKuCun),
                new SqlParameter("@CaiPinDanWeiId",caiPin.DanWei.DanWeiId),
                new SqlParameter("@caiPinId",caiPin.CaiPinId)
            };
            return db.ExecuteNonQuery(sql,sp);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="caiPin"></param>
        /// <returns></returns>
        public int AddXiaoShouPin(CaiPin caiPin) {
            string sql = "insert into CaiPin(caiPinMingZi, CaiPinJiaGe, CaiPinTeJia, CaiPinDianDanShu, CaiPinFenLeiId, CaiPinKuCun, CaiPinDanWeiId)values(@caiPinMingZi, @CaiPinJiaGe, @CaiPinTeJia, @CaiPinDianDanShu, @CaiPinFenLeiId, @CaiPinKuCun, @CaiPinDanWeiId);";
            SqlParameter[] sp = {
                new SqlParameter("@caiPinMingZi",caiPin.caiPinMingZi),
                new SqlParameter("@CaiPinJiaGe",caiPin.CaiPinJiaGe),
                new SqlParameter("@CaiPinTeJia",caiPin.CaiPinTeJia),
                new SqlParameter("@CaiPinDianDanShu",caiPin.CaiPinDianDanShu),
                new SqlParameter("@CaiPinFenLeiId",caiPin.CaiPinFenLei.CaiPinFenLeiId),
                new SqlParameter("@CaiPinKuCun",caiPin.CaiPinKuCun),
                new SqlParameter("@CaiPinDanWeiId",caiPin.DanWei.DanWeiId)
            };
            return db.ExecuteNonQuery(sql, sp);
        }

    }
}
