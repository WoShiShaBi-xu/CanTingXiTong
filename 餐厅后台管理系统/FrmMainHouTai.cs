using System;
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

        private void 座位停用设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 大厅楼层设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 添加销售品ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 多条件查询销售品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmXiaoShouPin frm = new FrmXiaoShouPin();
            frm.Show();
        }
    }
}
