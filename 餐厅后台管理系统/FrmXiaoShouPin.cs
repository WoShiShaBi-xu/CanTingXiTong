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
    public partial class FrmXiaoShouPin : Form
    {
        CaiPinFenLeiManager caiPinFenLeiManager = new CaiPinFenLeiManager();
        XiaoShouPinManager xiaoShouPinManager = new XiaoShouPinManager();
        public FrmXiaoShouPin()
        {
            InitializeComponent();
        }

        private void FrmXiaoShouPin_Load(object sender, EventArgs e)
        {
            dgvXiaosShouPin.AutoGenerateColumns = false;
            LoadTreeLeiBie();
        }

        #region 输入验证
        public bool CheckXiaoShouPinAdd()
        {
            if (utxtName.Text.Trim() == "")
            {
                MessageBox.Show("描述框为空！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                utxtName.Focus();
                return false;
            }
            if (utxtKuCun.Text.Trim() == "")
            {
                MessageBox.Show("库存框为空！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                utxtKuCun.Focus();
                return false;
            }
            if (utxtDianDanShu.Text.Trim() == "")
            {
                MessageBox.Show("点单数框为空！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                utxtDianDanShu.Focus();
                return false;
            }
            if (utxtPrice.Text.Trim() == "")
            {
                MessageBox.Show("价格框为空！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                utxtPrice.Focus();
                return false;
            }
            if (utxtTeJia.Text.Trim() == "")
            {
                MessageBox.Show("特价框为空！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                utxtTeJia.Focus();
                return false;
            }
            if (!cbDaChe.Checked)
            {
                MessageBox.Show("未选中打折框！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ucmbCaiPinType.SelectedIndex == 0)
            {
                MessageBox.Show("未选择菜品类型！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ucmbDanWei.SelectedIndex == 0)
            {
                MessageBox.Show("未选择单位！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        #endregion

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (dgvXiaosShouPin.SelectedRows.Count==0)
            {
                MessageBox.Show("未选中任何销售品！","删除提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            CaiPin caiPin = (CaiPin)dgvXiaosShouPin.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show("确定要删除"+caiPin.caiPinMingZi+"？")==DialogResult.Yes)
            {
                //删除操作
            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton4_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
        }

        /// <summary>
        /// 保存修改后的销售品信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton3_Click(object sender, EventArgs e)
        {
            if (CheckXiaoShouPinAdd())
            {
                CaiPin caiPin = new CaiPin()
                {
                    caiPinMingZi = utxtName.Text,
                    CaiPinFenLei = new CalPinFenLei()
                    {
                        CaiPinFenLeiId = (int)ucmbCaiPinType.SelectedValue
                    },
                    CaiPinDianDanShu = int.Parse(utxtDianDanShu.Text),
                    CaiPinJiaGe = double.Parse(utxtPrice.Text.ToString()),
                    CaiPinKuCun = int.Parse(utxtKuCun.Text),
                    CaiPinTeJia = double.Parse(utxtTeJia.Text.ToString())
                };
            }
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// 加载销售品类别到树形菜单
        /// </summary>
        public void LoadTreeLeiBie() {
            List<CalPinFenLei> list = caiPinFenLeiManager.SearchCaiPinFenLei();
            TreeNode root = utvXiaoShouPin.Nodes[0];
            foreach (CalPinFenLei item in list)
            {
                TreeNode tn = new TreeNode() {
                    Tag = item,
                    Text = item.CaiPinFenLeiMiaoShu
                };
                root.Nodes.Add(tn);
            }
        }

        /// <summary>
        /// 更改属性时发生，加载类型销售品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void utvXiaoShouPin_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int index = -1;
            
            if (utvXiaoShouPin.SelectedNode.Level==0)
            {
                
            }
            else
            {
                CalPinFenLei cai = (CalPinFenLei)utvXiaoShouPin.SelectedNode.Tag;
                index = cai.CaiPinFenLeiId;
            }
            List<CaiPin> list = xiaoShouPinManager.SearchXiaoShouPin(index);
            dgvXiaosShouPin.DataSource = list;
        }
    }
}
