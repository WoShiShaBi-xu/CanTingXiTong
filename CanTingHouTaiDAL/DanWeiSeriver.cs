using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanTingModes;
using System.Data;


namespace CanTingHouTaiDAL
{
    public class DanWeiSeriver
    {
        DBHelper db = new DBHelper();
        List<DanWei> list = null;
        /// <summary>
        /// 加载单位表
        /// </summary>
        /// <returns></returns>
        public List<DanWei> LoadDanWei() {
            list = new List<DanWei>();
            string sql = "select DanWeiId,DanWeiMiaoShu from DanWei";
            DataTable dt = db.GetTable(sql,"DanWei");
            foreach (DataRow item in dt.Rows)
            {
                DanWei dw = new DanWei()
                {
                    DanWeiId=int.Parse(item["DanWeiId"].ToString()),
                    DanWeiMiaoShu = item["DanWeiMiaoShu"].ToString()
                };
                list.Add(dw);
            }
            return list;
        }
    }
}
