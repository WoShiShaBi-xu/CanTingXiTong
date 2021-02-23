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
using CanTingBLL;

namespace CanTingLogin
{
    public partial class RetrievePassword : Form
    {
        public RetrievePassword()
        {
            InitializeComponent();
        }

        private LoginManager loginManager = new LoginManager();
        private Admin admin = new Admin();

        public int adminId = 0;
        public string adminEmail = "";

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            bool iRne = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form is FrmLogin)
                {
                    iRne = true;
                    break;
                }
            }
            if (iRne)
            {
                FrmLogin dian = Application.OpenForms["FrmLogin"] as FrmLogin;
                dian.Show();
                this.Close();
            }
            else
            {
                FrmLogin login = new FrmLogin();
                login.Show();
            }
        }

        private void RetrievePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("是否确认退出系统?", "找回密码", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ubtnRetrievePassword_Click(object sender, EventArgs e)
        {
            if (JudegText())
            {
                Admin admin = loginManager.LoadForgetPassword(txtUserName.Text, txtEmail.Text);
                if (admin == null)
                {
                    MessageBox.Show("账号或邮箱号输入错误,请重新输入 ! !", "找回密码", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    txtNewPwd.Text = admin.AdminPwd;
                    MessageBox.Show("密码找回成功!", "找回密码", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public bool JudegText() {
            if (txtUserName.Text.Trim() == "") {
                MessageBox.Show("请输入帐号!", "忘记密码", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                txtUserName.SelectAll();
                return false;
            } else if (txtEmail.Text.Trim() == "") {
                MessageBox.Show("请输入您的邮箱号!", "忘记密码", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                txtEmail.SelectAll();
                return false;
            }
            return true;
        }

        private void RetrievePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
