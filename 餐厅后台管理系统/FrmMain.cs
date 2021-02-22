using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 餐厅管理系统
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void 关于HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout frm = new FrmAbout();
            frm.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void 座位停用设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmZuoWei frm = new FrmZuoWei();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 大厅楼层设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLouCeng frm = new FrmLouCeng();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 添加新员工ToolStripMenuItem_Click( object sender , EventArgs e ) {
            FrmYuanGong frm = new FrmYuanGong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 流水单打印ToolStripMenuItem_Click( object sender , EventArgs e ) {

        }
    }
}
