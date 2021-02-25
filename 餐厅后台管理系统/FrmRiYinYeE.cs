using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 餐厅后台管理系统 {
    public partial class FrmRiYinYeE : Form {
        public FrmRiYinYeE( ) {
            InitializeComponent();
        }

        private void RiYinYeE_Load( object sender , EventArgs e ) {

            this.reportViewer1.RefreshReport();
        }
    }
}
