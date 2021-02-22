using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanTingLogin
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

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
                FrmLogin dian = Application.OpenForms["Login"] as FrmLogin;
                dian.Show();
                this.Close();
            }
            else
            {
                FrmLogin login = new FrmLogin();
                login.Show();
            }
        }
    }
}
