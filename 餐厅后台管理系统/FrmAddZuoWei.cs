using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanTingHouTaiBLL;
using CanTingModes;

namespace 餐厅后台管理系统
{
    public partial class FrmAddZuoWei : Form
    {
        LouCengManager louCengManager = new LouCengManager();
        ZuoWeiManager zuoWeiManager = new ZuoWeiManager();
        public FrmAddZuoWei()
        {
            InitializeComponent();
        }

        private void FrmAddZuoWei_Load(object sender, EventArgs e)
        {
            LoadLouCeng();
        }
        /// <summary>
        /// 加载楼层信息
        /// </summary>
        public void LoadLouCeng() {
            List<CengShu> list = louCengManager.SearchLouCeng();
            list.Insert(0, new CengShu() { CengShuId = -1, CengShuMiaoShu = "--请选择--", CengShuShiFouKeYong ="true" }) ;
            ucmbLouCeng.DataSource = list;
            ucmbLouCeng.ValueMember = "CengShuId";
            ucmbLouCeng.DisplayMember = "CengShuMiaoShu";
            ucmbLouCeng.SelectedIndex = 0;
        }

        /// <summary>
        /// 添加座位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ubtnAdd_Click(object sender, EventArgs e)
        {
            List<ZuoWei> list = new List<ZuoWei>();
            int louCengId = (int)ucmbLouCeng.SelectedValue;//楼层编号

            //获取当前座位最大编号
            List<ZuoWei> listCha = zuoWeiManager.ChaXunZuoWei(louCengId);
            ZuoWei zuoWei = listCha[listCha.Count-1];
            string[] result = zuoWei.ZuoWeiBeiZhu.Split("-".ToCharArray());
            int number = int.Parse(result[1]);

            for (int i = number + 1; i <= int.Parse(utxtShuLiang.Text.ToString())+ number; i++)
            {
                ZuoWei zw = new ZuoWei() {
                    ZuoWeiBeiZhu = louCengId + "-" + i,
                    ZuoWeiTingYong = "true",
                    ZuoWeiZhuangTaiId=1,
                    CengShu=new CengShu() {
                        CengShuId=louCengId
                    }
                };
                list.Add(zw);
            }
            
            int count = zuoWeiManager.AddZuoWei(list);
            if (count>0)
            {
                MessageBox.Show("添加成功！","添加座位提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ucmbLouCeng.SelectedIndex = 0;
                utxtShuLiang.Text = "";
            }
            else
            {
                MessageBox.Show("添加失败！", "添加座位提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ubtnBreak_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
