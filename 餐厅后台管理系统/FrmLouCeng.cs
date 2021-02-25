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
    public partial class FrmLouCeng : Form
    {
        LouCengManager lou = new LouCengManager();
        public FrmLouCeng()
        {
            InitializeComponent();
            dgvSearchLouCeng.AutoGenerateColumns = false;
        }

        private void FrmLouCeng_Load( object sender , EventArgs e ) {
            
        }
        public void ShuaXin( ) {
            List<CengShu> list = lou.SearchLouCeng();
            dgvSearchLouCeng.DataSource = list;
            for ( int i = 0 ; i < list.Count ; i++ ) {
                dgvSearchLouCeng.Rows [ i ].Cells [ "Column2" ].Value = list [ i ].CengShuShiFouKeYong == "true" ? 1 : 0;
            }
        }

        private void ucBtnExt1_BtnClick( object sender , EventArgs e ) {
            ShuaXin();
        }

        private void dgvSearchLouCeng_CellContentClick( object sender , DataGridViewCellEventArgs e ) {
            if ( e.ColumnIndex == 2 ) {
               
                if ( dgvSearchLouCeng.SelectedCells [ 2 ].Value.ToString() == "1" ) {
                    dgvSearchLouCeng.SelectedCells [ 2 ].Value = 0;
                } else {
                    dgvSearchLouCeng.SelectedCells [ 2 ].Value = 1;
                }
                lou.LouCengUpDate( dgvSearchLouCeng.SelectedCells [ 2 ].Value.ToString() == "1" ? "true" : "false" , int.Parse( dgvSearchLouCeng.SelectedCells [ 0 ].Value.ToString() ) );
            }
        }
    }
}
