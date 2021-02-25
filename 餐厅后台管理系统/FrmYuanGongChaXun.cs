using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanTingModes;
using CanTingHouTaiBLL;

namespace 餐厅后台管理系统
{
    public partial class FrmYuanGongChaXun : Form
    {
        public FrmYuanGongChaXun()
        {
            InitializeComponent();
        }

        private YuanGongMessageAddManager yuan = new YuanGongMessageAddManager();

        public void QueryAnNiu()
        {
            List<YuanGong> yuanGongs = yuan.SelectDgvMessage(txtYuanGongName.Text, rbNan.Checked, rbNv.Checked);

            dgvYuanGongMessage.DataSource = yuanGongs;

            for (int i = 0; i < yuanGongs.Count; i++)
            {
                dgvYuanGongMessage.Rows[i].Cells["ZhiWeiName"].Value = yuanGongs[i].ZhiWei.ZhiWeiMIngCheng;
            }
        }

        private void FrmYuanGongChaXun_Load(object sender, EventArgs e)
        {
            dgvYuanGongMessage.AutoGenerateColumns = false;
        }

        private void ucBtnExt1_BtnClick_1(object sender, EventArgs e)
        {
            QueryAnNiu();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认删除该员工信息?", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                yuan.DelYuanGongMessage(int.Parse(dgvYuanGongMessage.SelectedCells[0].Value.ToString()));
                QueryAnNiu();
                MessageBox.Show("该员工信息删除成功!", "删除提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 修改信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYuanGong fyg = new FrmYuanGong();
            fyg.ygId = (int)dgvYuanGongMessage.SelectedCells[0].Value;
            fyg.Show();
        }
    }
}
