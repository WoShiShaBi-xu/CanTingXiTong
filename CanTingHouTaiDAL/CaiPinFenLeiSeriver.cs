using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanTingModes;
using System.Data;

namespace CanTingHouTaiDAL
{
    public class CaiPinFenLeiSeriver
    {
        DBHelper db = new DBHelper();
        List<CalPinFenLei> list = new List<CalPinFenLei>();
        /// <summary>
        /// 查询菜品类型
        /// </summary>
        /// <returns></returns>
        public List<CalPinFenLei> SearchCaiPinFenLei() {
            string sql = "select CaiPinFenLeiId, CaiPinFenLeiMiaoShu from CalPinFenLei";
            DataTable dt = db.GetTable(sql,"CaiPinFenLei");
            foreach (DataRow item in dt.Rows)
            {
                CalPinFenLei c = new CalPinFenLei() { 
                    CaiPinFenLeiId=int.Parse(item["CaiPinFenLeiId"].ToString()),
                    CaiPinFenLeiMiaoShu= item["CaiPinFenLeiMiaoShu"].ToString()
                };
                list.Add(c);
            }
            return list;
        } 
    }
}
