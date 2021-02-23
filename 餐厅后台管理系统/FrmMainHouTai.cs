﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 餐厅后台管理系统
{
    public partial class FrmMainHouTai : Form
    {
        public FrmMainHouTai()
        {
            InitializeComponent();
        }



        private void 座位停用设置ToolStripMenuItem_Click_1( object sender , EventArgs e ) {
            FrmZuoWei wei = new FrmZuoWei();
            wei.MdiParent = this;
            wei.Show();
        }

        private void 菜品停用设置ToolStripMenuItem_Click( object sender , EventArgs e ) {
            XiaoShouPing xiao = new XiaoShouPing();
            xiao.MdiParent = this;
            xiao.Show();


        }

        private void 沽清设置ToolStripMenuItem_Click( object sender , EventArgs e ) {
            FrmKuCun cun = new FrmKuCun();
            cun.MdiParent = this;
            cun.Show();
        }

        private void 大厅楼层设置ToolStripMenuItem_Click( object sender , EventArgs e ) {
            FrmLouCeng frm = new FrmLouCeng();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
