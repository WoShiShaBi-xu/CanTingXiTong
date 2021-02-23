using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CanTingModes;

namespace CanTingDAL
{
    public class DianCaiServer
    {
        DBHelper db = new DBHelper();
        public List<DianCaiBiao> CaiDanChaXun(int zuoWeiId)//查询菜单
        {
            string sql = "select ZuoWeiId, CaiPinId from DianCaiBiao where ZuoWeiId =@ZuoWeiId";
            SqlParameter[] sp =
            {
                 new SqlParameter("@ZuoWeiId",zuoWeiId),
            };
            DataTable dt = db.GetTable(sql, "CaiDan");
            List<DianCaiBiao> caiDan = new List<DianCaiBiao>();
            foreach (DataRow dr in dt.Rows)
            {
                DianCaiBiao caiDanBiao = new DianCaiBiao()
                {
                     ZuoWeiId  = (int)dr["StudentNo"],
                     CaiPinId =(int)dr["StudentName"],
                };
                caiDan.Add(caiDanBiao);
            }
            return caiDan;
        }
        public void CaiDanZenJia(int cp,int zuoWeiId)//增加菜单
        {
            string sql = " insert into DianCaiBiao(ZuoWeiId, CaiPinId) values(@ZuoWeiId, @CaiPinId)";
            SqlParameter[] sp =
            {
              new SqlParameter("@ZuoWeiId",cp),
               new SqlParameter("@CaiPinId",zuoWeiId),
            };

            if (db.ExecuteNonQuery(sql, sp) > 0)
            {
                
            }
        }
    }
    
}
