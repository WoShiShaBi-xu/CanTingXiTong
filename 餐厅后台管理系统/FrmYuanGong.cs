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
    public partial class FrmYuanGong : Form
    {
        public FrmYuanGong()
        {
            InitializeComponent();
        }

        private YuanGongMessageAddManager ygmam = new YuanGongMessageAddManager();
        private YuanGong yg = new YuanGong();
        public int ygId = 0;    


        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns></returns>
        public bool JudgeText()
        {
            DateTime dt1 = Convert.ToDateTime(dtpYuanGongSr.Value);

            DateTime dt2 = System.DateTime.Now;

            int Year = dt2.Year - dt1.Year;

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("请输入员工姓名!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                txtName.SelectAll();
                return false;
            }
            else if (Year <= 16)
            {
                MessageBox.Show("员工年龄不符合入职要求!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpYuanGongSr.Focus();
                return false;
            }
            else if (txtGongZi.Text.Trim() == "")
            {
                MessageBox.Show("请输入员工工资!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGongZi.Focus();
                txtGongZi.SelectAll();
                return false;
            }
            else if (cboZhiWei.Text == "--请选择--")
            {
                MessageBox.Show("请选择员工职位!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboZhiWei.Focus();
                return false;
            }
            else if (txtShenFenZheng.Text.Trim() == "")
            {
                MessageBox.Show("请输入员工身份证号!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShenFenZheng.Focus();
                txtShenFenZheng.SelectAll();
                return false;
            }
            else if (txtShenFenZheng.Text.Trim() != "")
            {
                if (txtShenFenZheng.Text.Length != 18)
                {
                    MessageBox.Show("员工身份证号格式不正确,请重新输入!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtShenFenZheng.Focus();
                    txtShenFenZheng.SelectAll();
                    return false;
                }
            }
            return true;
        }

        private void FrmYuanGong_Load(object sender, EventArgs e)
        {
            LoadCmbType();
            cboZhiWei.SelectedIndex = 0;
            if (ygId != 0)
            {
                Print();
            }
        }

        public void Print()
        {
            List<YuanGong> list = ygmam.PrintMessageTxt(ygId);
            foreach (YuanGong item in list)
            {
                txtId.Text = item.YuanGongId.ToString();
                txtName.Text = item.YuanGongXingMing;
                rbNan.Checked = item.YuanGongGender == "男";
                rbNv.Checked = item.YuanGongGender == "女";
                dtpYuanGongSr.Value = item.YuanGongShengRi;
                txtGongZi.Text = item.YuanGongGongZi.ToString();
                cboZhiWei.Text = item.ZhiWei.ZhiWeiMIngCheng.ToString();
                txtShenFenZheng.Text = item.YuanGongShenFengZheng;
            }
        }

        /// <summary>
        /// 员工职位下拉框的显示
        /// </summary>
        public void LoadCmbType()
        {
            List<ZhiWei> zw = ygmam.YgZhiWeiComboBox();
            zw.Insert(0, new ZhiWei { ZhiWeiId = -1, ZhiWeiMIngCheng = "--请选择--" });
            cboZhiWei.DataSource = new BindingList<ZhiWei>(zw);
            cboZhiWei.DisplayMember = "ZhiWeiMIngCheng";
            cboZhiWei.ValueMember = "ZhiWeiId";


        }

        public void ClearText()
        {
            txtId.Clear();
            txtName.Clear();
            rbNan.Checked.ToString();
            dtpYuanGongSr.Value = System.DateTime.Now;
            txtGongZi.Clear();
            cboZhiWei.SelectedIndex = 0;
            txtShenFenZheng.Clear();
        }

        private void btnQuXiao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaoCun_Click(object sender, EventArgs e)
        {
            if (JudgeText())
            {
                if (txtId.Text == "")
                {
                    yg.YuanGongXingMing = txtName.Text;
                    yg.YuanGongGender = rbNan.Checked == true ? "男" : "女";
                    yg.YuanGongShengRi = dtpYuanGongSr.Value;
                    yg.YuanGongGongZi = int.Parse(txtGongZi.Text);
                    foreach (ZhiWei item in cboZhiWei.Items)
                    {
                        if (item.ZhiWeiMIngCheng == cboZhiWei.Text)
                        {
                            yg.ZhiWei = new ZhiWei()
                            {
                                ZhiWeiId = item.ZhiWeiId
                            };
                        }
                    }
                    yg.YuanGongShenFengZheng = txtShenFenZheng.Text;
                    int ygId = ygmam.AddYuanGongMessage(yg);
                    if (ygmam.AddYuanGongMessage(yg) > 0)
                    {
                        MessageBox.Show("保存成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtId.Text = ygId + ""; //获取下拉列表中的数据(自动增长列)
                        ClearText();
                    }
                    else
                    {
                        MessageBox.Show("保存失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    yg.YuanGongId = int.Parse(txtId.Text);
                    yg.YuanGongXingMing = txtName.Text;
                    yg.YuanGongGender = rbNan.Checked == true ? "男" : "女";
                    yg.YuanGongShengRi = dtpYuanGongSr.Value;
                    yg.YuanGongGongZi = decimal.Parse(txtGongZi.Text);
                    foreach (ZhiWei item in cboZhiWei.Items)
                    {
                        if (item.ZhiWeiMIngCheng == cboZhiWei.Text)
                        {
                            yg.ZhiWei = new ZhiWei()
                            {
                                ZhiWeiId = item.ZhiWeiId
                            };
                        }
                    }
                    yg.YuanGongShenFengZheng = txtShenFenZheng.Text;
                    if (ygmam.UpdateYuanGong(yg, ygId) > 0)
                    {
                        MessageBox.Show("保存成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("保存失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
