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
        DanWeiManager danWeiManager = new DanWeiManager();
        public int tianJia = -1;
        public int count = 1;
        public FrmXiaoShouPin()
        {
            InitializeComponent();
        }

        private void FrmXiaoShouPin_Load(object sender, EventArgs e)
        {
            dgvXiaosShouPin.AutoGenerateColumns = false;
            LoadTreeLeiBie();
            LoadFenLei();
            LoadDanWei();
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
            if (MessageBox.Show("确定要删除"+caiPin.caiPinMingZi+"？","删除提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
               int count= xiaoShouPinManager.DeleteXiaoShouPin(caiPin.CaiPinId);
                if (count>0)
                {
                    MessageBox.Show("删除成功！","删除提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadXiaoShouPin();
                }
                else
                {
                    MessageBox.Show("删除失败！", "删除提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            CearUtxt();
            tianJia = 1;
        }

        /// <summary>
        /// 清空输入框
        /// </summary>
        public void CearUtxt() {
            utxtDianDanShu.Text = "";
            utxtKuCun.Text = "";
            utxtName.Text = "";
            utxtPrice.Text = "";
            utxtTeJia.Text = "";
            ucmbCaiPinType.Text = "--请选择--";
            ucmbDanWei.Text = "--请选择--";
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
                    CaiPinTeJia = double.Parse(utxtTeJia.Text.ToString()),
                    DanWei = new DanWei() {
                        DanWeiId = (int)ucmbDanWei.SelectedValue,
                    }
                };
                int count = 0;
                if (tianJia==1)
                {
                    count = xiaoShouPinManager.AddXiaoShouPin(caiPin);
                    tianJia = -1;
                }
                else
                {
                    CaiPin c = (CaiPin)dgvXiaosShouPin.SelectedRows[0].DataBoundItem;
                    caiPin.CaiPinId = c.CaiPinId;
                    count = xiaoShouPinManager.ChangerXiaoShouPin(caiPin);
                }
                if (count > 0)
                {
                    MessageBox.Show("保存成功！", "保存提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadXiaoShouPin();
                    CearUtxt();
                }
                else
                {
                    MessageBox.Show("保存失败！", "保存提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            count = 1;
            LoadXiaoShouPin();
        }
        /// <summary>
        /// 加载销售品
        /// </summary>
        public void LoadXiaoShouPin() {
            int index = -1;

            if (utvXiaoShouPin.SelectedNode.Level != 0)
            {
                CalPinFenLei cai = (CalPinFenLei)utvXiaoShouPin.SelectedNode.Tag;
                index = cai.CaiPinFenLeiId;
            }
            List<CaiPin> list = xiaoShouPinManager.SearchXiaoShouPin(index,count);
            if (list.Count==0)
            {
                MessageBox.Show("已经是最后一页！","翻页提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            dgvXiaosShouPin.DataSource = list;
            for (int i = 0; i < list.Count; i++)
            {
                dgvXiaosShouPin.Rows[i].Cells["clDanWei"].Value = list[i].DanWei.DanWeiMiaoShu;
                dgvXiaosShouPin.Rows[i].Cells["clLeiXing"].Value = list[i].CaiPinFenLei.CaiPinFenLeiMiaoShu;
            }
        }

        /// <summary>
        /// 加载数据到修改框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvXiaosShouPin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox3.Enabled = true;
            CaiPin caiPin = (CaiPin)dgvXiaosShouPin.SelectedRows[0].DataBoundItem;
            utxtName.Text = caiPin.caiPinMingZi;
            utxtDianDanShu.Text = caiPin.CaiPinDianDanShu.ToString();
            utxtKuCun.Text = caiPin.CaiPinKuCun.ToString();
            utxtPrice.Text = caiPin.CaiPinJiaGe.ToString();
            utxtTeJia.Text = caiPin.CaiPinTeJia.ToString();
            foreach (CalPinFenLei item in ucmbCaiPinType.Items)
            {
                if (item.CaiPinFenLeiMiaoShu==caiPin.CaiPinFenLei.CaiPinFenLeiMiaoShu)
                {
                    ucmbCaiPinType.SelectedValue = caiPin.CaiPinFenLei.CaiPinFenLeiId;
                }
            }
            ucmbDanWei.Text = caiPin.DanWei.DanWeiMiaoShu;
        }

        /// <summary>
        /// 加载类型下拉框
        /// </summary>
        public void LoadFenLei() {
            List<CalPinFenLei> list = caiPinFenLeiManager.SearchCaiPinFenLei();
            list.Insert(0,new CalPinFenLei { CaiPinFenLeiId = -1, CaiPinFenLeiMiaoShu = "--请选择--" });
            ucmbCaiPinType.DataSource = list;
            ucmbCaiPinType.ValueMember = "CaiPinFenLeiId";
            ucmbCaiPinType.DisplayMember = "CaiPinFenLeiMiaoShu";
            ucmbCaiPinType.SelectedIndex = 0;
        }
        /// <summary>
        /// 加载单位到下拉框
        /// </summary>
        public void LoadDanWei() {
            List<DanWei> list = danWeiManager.LoadDanWei();
            list.Insert(0, new DanWei { DanWeiId = -1, DanWeiMiaoShu = "--请选择--" });
            ucmbDanWei.DataSource = list;
            ucmbDanWei.ValueMember = "DanWeiId";
            ucmbDanWei.DisplayMember = "DanWeiMiaoShu";
            ucmbDanWei.SelectedIndex = 0;
        }

        private void ubtnShangyiYe_Click(object sender, EventArgs e)
        {
            if (count==1)
            {
                MessageBox.Show("已经是第一页！","翻页提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            count--;
            LoadXiaoShouPin();
        }

        private void ubtnXiaYiYe_Click(object sender, EventArgs e)
        {
            count++;
            LoadXiaoShouPin();
        }

       
    }
}
