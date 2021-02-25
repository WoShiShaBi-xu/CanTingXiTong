using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanTingModes;
using CanTingHouTaiBLL;

namespace 餐厅后台管理系统 {
    public partial class FrmYuanGongBaoBiao : Form {
        public FrmYuanGongBaoBiao( ) {
            InitializeComponent();
        }

        private void FrmYuanGongBaoBiao_Load( object sender , EventArgs e ) {

            this.rvYuanGong.RefreshReport();
            rvYuanGong.LocalReport.DataSources.Clear();
            rvYuanGong.LocalReport.DataSources.Add( new ReportDataSource( "DataSet1" , dt() ) );//对应的xsd数据集文件名
            rvYuanGong.LocalReport.Refresh();
        }
      
            private DataTable dt( ) {
            YuanGongMessageAddManager yuan = new YuanGongMessageAddManager();
            List<YuanGong> yuanGongs = yuan.SelectDgvMessage(  "" ,false  ,false );
            DataTable DataTable2 = new DataTable(  );
                DataTable2.Columns.Add( "GongHao" , typeof( string ) );
                DataTable2.Columns.Add( "XingMing" , typeof( string ) );
                DataTable2.Columns.Add( "Gender" , typeof( string ) );
                DataTable2.Columns.Add( "ChuShenRiQi" , typeof( string ) );
                DataTable2.Columns.Add( "GongZi" , typeof( string ) );
                DataTable2.Columns.Add( "ZhiWei" , typeof( string ) );
                DataTable2.Columns.Add( "ShenFenZhen" , typeof( string ) );
            foreach ( var item in yuanGongs ) {
                DataRow dr = DataTable2.NewRow();
                dr [ "GongHao" ] = item.YuanGongId;
                dr [ "XingMing" ] = item.YuanGongXingMing;
                dr [ "Gender" ] = item.YuanGongGender;
                dr [ "ChuShenRiQi" ] = item.YuanGongShengRi;
                dr [ "GongZi" ] = item.YuanGongGongZi;
                dr [ "ZhiWei" ] = item.ZhiWei.ZhiWeiMIngCheng;
                dr [ "ShenFenZhen" ] = item.YuanGongShenFengZheng;
                DataTable2.Rows.Add( dr );
            }

           
                return DataTable2;
            }


        

       
    }
}
