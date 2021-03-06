﻿using HZH_Controls.Controls;
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
            this.btnTuiDan.Enabled = true;
            this.btnQiCai.Enabled = true;
            this.btnReXiao.Enabled = true;
        }

        private void btnJiaDan_BtnClick( object sender , EventArgs e ) {
            FormJiaDan dan = new FormJiaDan();
            dan.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmKaiTai frm = new FrmKaiTai();
            frm.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmYuDing frm = new FrmYuDing();
            frm.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }
        private void btnTuiDan_BtnClick(object sender, EventArgs e)
        {
            FrmTuiDan frm = new FrmTuiDan();
            frm.Show();
        }

        private void btnReXiao_BtnClick(object sender, EventArgs e)
        {
            FrmReXiao frm = new FrmReXiao();
            frm.Show();
        }
    }
}
