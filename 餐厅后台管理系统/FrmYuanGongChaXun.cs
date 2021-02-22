using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 餐厅管理系统 {
    public partial class FrmYuanGongChaXun : Form {
        public FrmYuanGongChaXun( ) {
            InitializeComponent();
        }

        private void FrmYuanGongChaXun_Load( object sender , EventArgs e ) {
            ucBtnsGroup1.DataSource = new Dictionary<string , string>() { { "1" , "男" } , { "0" , "女" } };
        }
    }
}
