using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanTingHouTaiBLL;
using CanTingModes;

namespace 餐厅后台管理系统
{
    public partial class FrmZuoWei : Form
    {
        public FrmZuoWei()
        {
            InitializeComponent();
            dgvSearchZuoWei.AutoGenerateColumns = false;
        }

        private void FrmZuoWei_Load(object sender, EventArgs e)
        {
            LouCengManager cen = new LouCengManager();
            List<CengShu> list = cen.SearchLouCeng();
            list.Insert( 0 , new CengShu { CengShuId = -1 , CengShuMiaoShu = "-----全部----" } );
            CboLouCeng.DataSource = list;
            CboLouCeng.DisplayMember = "CengShuMiaoShu";
            CboLouCeng.ValueMember = "CengShuId";
            CboLouCeng.Tag = "CengShuShiFouKeYong";
            CboLouCeng.SelectedIndex = 0;
        }
        public void ShuaXin(){
            ZuoWeiManager zuoWei = new ZuoWeiManager();
            List<ZuoWei> list= zuoWei.ChaXunZuoWei( int.Parse( CboLouCeng.SelectedValue.ToString() ) );



            dgvSearchZuoWei.DataSource = list;
            for ( int i = 0 ; i < list.Count ; i++ ) {
                dgvSearchZuoWei.Rows [ i ].Cells [ "Column3" ].Value = list [ i ].ZuoWeiTingYong.ToString() == "false" ? 0 : 1;
                dgvSearchZuoWei.Rows [ i ].Cells [ "Column4" ].Value = list [ i ].CengShu.CengShuMiaoShu.ToString();
            }
        }

        private void btnSearch_Click( object sender , EventArgs e ) {
            ShuaXin();
        }

        private void dgvSearchZuoWei_CellContentClick( object sender , DataGridViewCellEventArgs e ) {
            if ( e.ColumnIndex == 3 ) {
                ZuoWeiManager zuo = new ZuoWeiManager();
                if ( dgvSearchZuoWei.SelectedCells [ 3 ].Value.ToString() == "1" ) {
                    dgvSearchZuoWei.SelectedCells [ 3 ].Value = 0;
                } else {
                    dgvSearchZuoWei.SelectedCells [ 3 ].Value = 1;
                }
                zuo.UpDateZuoWei( dgvSearchZuoWei.SelectedCells [ 3 ].Value.ToString() == "0" ? "false" : "true" , int.Parse( dgvSearchZuoWei.SelectedCells [ 0 ].Value.ToString() ) );
            }
        }
    }
}
