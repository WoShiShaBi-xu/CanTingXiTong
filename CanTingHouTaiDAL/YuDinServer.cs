using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanTingModes;
using System.Data.SqlClient;
namespace CanTingHouTaiDAL {
    public class YuDinServer {
        DBHelper db = new DBHelper();
       public List<YuDing> YuDinQuery(string DateTime){
            List<YuDing> list = new List<YuDing>();
            string sql = "select YuDingId,YuDingXingMing,YuDingPhone,YuDingShiJian,YuDingZuoWeiId,YuDingJinE,zw.ZuoWeiBeiZhu from YuDing yd join ZuoWei zw on zw.ZuoWeiId=yd.YuDingZuoWeiId where YuDingShiJian=@DateTime";
            SqlParameter sp = new SqlParameter("@DateTime",DateTime);
            SqlDataReader sdr= db.ExecuteReader(sql,sp);
            while(sdr.Read()){
                list.Add(new YuDing{ YuDingId=int.Parse(sdr[ "YuDingId" ].ToString() ), YuDingJinE=decimal.Parse(sdr[ "YuDingJinE" ].ToString() ), YuDingPhone=sdr[ "YuDingPhone" ].ToString(), YuDingShiJian=( DateTime ) sdr[ "YuDingShiJian" ], YuDingXingMing=sdr[ "YuDingXingMing" ].ToString(), YuDingZuoWeiId=new ZuoWei{ ZuoWeiId=int.Parse(sdr[ "YuDingZuoWeiId" ].ToString() ), ZuoWeiBeiZhu=sdr[ "ZuoWeiBeiZhu" ].ToString() } } ); 
            }
            sdr.Close();
            return list;
            
        }
    }
}
