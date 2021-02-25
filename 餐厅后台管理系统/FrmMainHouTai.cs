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



        private void 座位停用设置ToolStripMenuItem_Click_1( object sender , EventArgs e ) {
            FrmZuoWei wei = new FrmZuoWei();
            wei.MdiParent = this;
            wei.Show();
        }

        private void 菜品停用设置ToolStripMenuItem_Click( object sender , EventArgs e ) {
            FrmXiaoShouPin xiao = new FrmXiaoShouPin();
            xiao.MdiParent = this;
            xiao.Show();


        }

       
        private void 大厅楼层设置ToolStripMenuItem_Click( object sender , EventArgs e ) {
            FrmLouCeng frm = new FrmLouCeng();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 添加销售品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("将打开窗体，请点击添加按钮","添加提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            FrmXiaoShouPin frm = new FrmXiaoShouPin();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 多条件查询销售品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmXiaoShouPin frm = new FrmXiaoShouPin();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmMainHouTai_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void 修改销售品信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("将打开窗体，请点击修改","修改提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            FrmXiaoShouPin frm = new FrmXiaoShouPin();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 删除销售品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("将打开窗体，请选择销售品进行删除", "删除提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmXiaoShouPin frm = new FrmXiaoShouPin();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 座位维修设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmZuoWei frm = new FrmZuoWei();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmXiaoShouPin frm = new FrmXiaoShouPin();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout frm = new FrmAbout();
            frm.ShowDialog();
        }

        private void 更新座位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddZuoWei frm = new FrmAddZuoWei();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmMainHouTai_Load(object sender, EventArgs e)
        {

        }

        private void 添加新员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYuanGong frm = new FrmYuanGong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 查询员工基本信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYuanGongChaXun frm = new FrmYuanGongChaXun();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 日营业额统计ToolStripMenuItem_Click( object sender , EventArgs e ) {
            FrmRiYinYeE ri = new FrmRiYinYeE();
            ri.MdiParent = this;
            ri.Show();
        }

        private void 员工工资报表ToolStripMenuItem_Click( object sender , EventArgs e ) {
            FrmYuanGongBaoBiao frm = new FrmYuanGongBaoBiao();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 客人基本信息查询ToolStripMenuItem_Click( object sender , EventArgs e ) {
            FrmYuDinChaXun frm = new FrmYuDinChaXun();
            frm.MdiParent = this;
            frm.Show(  );
        }
    }
}
