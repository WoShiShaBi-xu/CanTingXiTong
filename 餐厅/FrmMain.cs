using HZH_Controls.Controls;
using HZH_Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 餐厅 {
    public partial class FrmMain : Form {
        public FrmMain( ) {
            InitializeComponent();
        }

        private void Form1_Load( object sender , EventArgs e ) {
           
         
           
           


        }

        private void ucBtnExt1_BtnClick( object sender , EventArgs e ) {
            this.btnJiaDan.Enabled = true;
        }

        private void btnJiaDan_BtnClick( object sender , EventArgs e ) {
            FormJiaDan dan = new FormJiaDan();
            dan.Show();
            this.Hide();
        }
    }
}
