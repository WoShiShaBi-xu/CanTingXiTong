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
using CanTingModes;
using CanTingBLL;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using 餐厅后台管理系统;

namespace CanTingLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private LoginManager login = new LoginManager();
        private Dictionary<string, Admin> admin1 = new Dictionary<string, Admin>();

        /// <summary>
        /// 序列化操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //加载图片
            One();

            FileStream fs = new FileStream("data.bin", FileMode.OpenOrCreate);

            if (fs.Length > 0)
            {
                BinaryFormatter bf = new BinaryFormatter();
                admin1 = bf.Deserialize(fs) as Dictionary<string, Admin>;
                foreach (Admin user in admin1.Values)
                {
                    this.cmbUser.Items.Add(user.AdminUser);
                }

                for (int i = 0; i < admin1.Count; i++)
                {
                    if (this.cmbUser.Text != "")
                    {
                        if (admin1.ContainsKey(this.cmbUser.Text))
                        {
                            this.txtUserPwd.Text = admin1[this.cmbUser.Text].AdminPwd;
                            this.cbkRememberPwd.Checked = true;
                        }
                    }
                }
            }
            fs.Close();
            //  用户名默认选中第一个
            if (this.cmbUser.Items.Count > 0)
            {
                this.cmbUser.SelectedIndex = this.cmbUser.Items.Count - 1;
            }
        }

        /// <summary>
        /// 加载珍惜粮食图片
        /// </summary>
        public void One()
        {
            Form frm = new Form();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Width = 900;
            frm.Height = 383;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowInTaskbar = false;
            PictureBox pbx = new PictureBox();
            pbx.Image = Image.FromFile(@"D:\C#Demo\餐厅系统\餐厅素材\杜绝浪费.jpg");
            pbx.Dock = DockStyle.Fill;
            frm.Controls.Add(pbx);
            frm.Show();
            Thread.Sleep(2000);
            frm.Close();
        }


        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.Show();
        }


        /// <summary>
        /// 找回密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel2_Click(object sender, EventArgs e)
        {
            RetrievePassword rp = new RetrievePassword();
            this.Hide();
            rp.Show();
        }

        /// <summary>
        /// 登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ubtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUser.Text.Trim() == "")
                {
                    MessageBox.Show("请输入帐号!", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbUser.Focus();
                    cmbUser.SelectAll();
                    return;
                }
                else if (txtUserPwd.Text.Trim() == "")
                {
                    MessageBox.Show("请输入密码!", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserPwd.Focus();
                    txtUserPwd.SelectAll();
                    return;
                }
                string username = this.cmbUser.Text.Trim();
                string password = this.txtUserPwd.Text.Trim();

                Admin admin2 = new Admin();
                FileStream fs = new FileStream("data.bin", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                admin2.AdminUser = username;
                if (this.cbkRememberPwd.Checked)       //  如果单击了记住密码的功能
                {   //  在文件中保存密码
                    admin2.AdminPwd = password;
                }
                else
                {   //  不在文件中保存密码
                    admin2.AdminPwd = "";
                }

                //  选在集合中是否存在用户名 
                if (admin1.ContainsKey(admin2.AdminUser))
                {
                    admin1.Remove(admin2.AdminUser);
                }
                admin1.Add(admin2.AdminUser, admin2);
                //要先将User类先设为可以序列化(即在类的前面加[Serializable])
                bf.Serialize(fs, admin1);
                //user.Password = this.PassWord.Text;
                fs.Close();


                Admin admin = login.LoadAdmin(cmbUser.Text, txtUserPwd.Text);
                if (admin == null)
                {
                    MessageBox.Show("密码或账号输入错误,请重新输入 ! !", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                     FrmMainHouTai fm= new FrmMainHouTai();
                    fm.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("您的输入格式不正确，请重新输入!", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 帐号序列化操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  首先读取记住密码的配置文件
            FileStream fs = new FileStream("data.bin", FileMode.OpenOrCreate);

            if (fs.Length > 0)
            {
                BinaryFormatter bf = new BinaryFormatter();

                admin1 = bf.Deserialize(fs) as Dictionary<string, Admin>;

                for (int i = 0; i < admin1.Count; i++)
                {
                    if (this.cmbUser.Text != "")
                    {
                        if (admin1.ContainsKey(cmbUser.Text) && admin1[cmbUser.Text].AdminPwd != "")
                        {
                            this.txtUserPwd.Text = admin1[cmbUser.Text].AdminPwd;
                            this.cbkRememberPwd.Checked = true;
                        }
                        else
                        {
                            this.txtUserPwd.Text = "";
                            this.cbkRememberPwd.Checked = false;
                        }
                    }
                }
            }

            fs.Close();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
