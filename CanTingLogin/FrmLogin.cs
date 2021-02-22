using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using 餐厅;
using 餐厅后台管理系统;

namespace CanTingLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comPost.SelectedIndex = 0;


            Form frm = new Form();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Width = 900;
            frm.Height = 383;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowInTaskbar = false;
            PictureBox pbx = new PictureBox();
            pbx.Image = Image.FromFile(@"D:\C\Jobs\HotelManageEx\bin\Release\杜绝浪费.jpg");
            pbx.Dock = DockStyle.Fill;
            frm.Controls.Add(pbx);
            frm.Show();
            Thread.Sleep(2000);
            frm.Close();
        }

        /// <summary>
        /// 囧i哦
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.Show();
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            RetrievePassword rp = new RetrievePassword();
            this.Hide();
            rp.Show();
        }

        private void ubtnLogin_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            frm.Show();
        }
    }
}
