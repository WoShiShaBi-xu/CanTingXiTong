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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private LoginManager loginManager = new LoginManager();
        Admin admin = new Admin();

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

        private void ubtnRegistration_Click(object sender, EventArgs e)
        {
            if (JudgeText())
            {
                admin.AdminPwd = txtPwd.Text;
                admin.AdminUser = txtUserName.Text;
                admin.AdminEmail = txtRegistrationEmail.Text;

                if (loginManager.LoadRegistration(admin) > 0)
                {
                    MessageBox.Show("注册成功!", "注册", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtUserName.Clear();
                    txtPwd.Clear();
                    txtConfirmPwd.Clear();
                    txtRegistrationEmail.Clear();
                }
                else
                {
                    MessageBox.Show("注册失败!", "注册", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        /// <summary>
        /// 判断是否为空
        /// </summary>
        /// <returns></returns>
        public bool JudgeText()
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("请输入帐号!", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                txtUserName.SelectAll();
                return false;
            }
            else if (txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码!", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPwd.Focus();
                txtPwd.SelectAll();
                return false;
            }
            else if (txtConfirmPwd.Text.Trim() == "")
            {
                MessageBox.Show("请再次输入密码!", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPwd.Focus();
                txtConfirmPwd.SelectAll();
                return false;

            }
            else if (txtPwd.Text.Length < 6 || txtPwd.Text.Length > 16)
            {
                MessageBox.Show("密码必须在6到18位!", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPwd.Focus();
                txtConfirmPwd.SelectAll();
                return false;
            }
            else if (txtPwd.Text.Trim() != txtConfirmPwd.Text.Trim())
            {
                MessageBox.Show("两次密码输入不一致，请重新输入!", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPwd.Focus();
                txtConfirmPwd.SelectAll();
                return false;
            } else if (txtRegistrationEmail.Text.Trim()=="") {
                MessageBox.Show("请输入您的邮箱号", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRegistrationEmail.Focus();
                txtRegistrationEmail.SelectAll();
                return false;
            }
            else if (txtRegistrationEmail.Text.Trim() != "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(this.txtRegistrationEmail.Text.ToString().Trim(), @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                {
                    MessageBox.Show("请输入正确的邮箱格式！");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("您输入的邮箱号格式不正确，请重新输入!", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return true;
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("是否确认退出系统?","注册",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) {
                Application.Exit();
            }
        }
    }
}
