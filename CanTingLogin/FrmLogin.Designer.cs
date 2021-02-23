
namespace CanTingLogin
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUserPwd = new System.Windows.Forms.TextBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.ubtnLogin = new Sunny.UI.UIButton();
            this.cbkRememberPwd = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("方正舒体", 41.7479F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(393, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(452, 74);
            this.label4.TabIndex = 21;
            this.label4.Text = "登录美食餐厅";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "帐号：";
            // 
            // comPost
            // 
            this.comPost.BackColor = System.Drawing.Color.Snow;
            this.comPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPost.Font = new System.Drawing.Font("楷体", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comPost.FormattingEnabled = true;
            this.comPost.Items.AddRange(new object[] {
            "--请选择--"});
            this.comPost.Location = new System.Drawing.Point(99, 180);
            this.comPost.Name = "comPost";
            this.comPost.Size = new System.Drawing.Size(305, 25);
            this.comPost.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Font = new System.Drawing.Font("楷体", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUser.Location = new System.Drawing.Point(99, 46);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(305, 27);
            this.txtUser.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("楷体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "职位：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtUserPwd);
            this.panel1.Controls.Add(this.cmbUser);
            this.panel1.Controls.Add(this.ubtnLogin);
            this.panel1.Controls.Add(this.cbkRememberPwd);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(111, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 372);
            this.panel1.TabIndex = 22;
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Location = new System.Drawing.Point(99, 142);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.PasswordChar = '*';
            this.txtUserPwd.Size = new System.Drawing.Size(284, 25);
            this.txtUserPwd.TabIndex = 30;
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(99, 44);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(284, 23);
            this.cmbUser.TabIndex = 29;
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.cmbUser_SelectedIndexChanged);
            // 
            // ubtnLogin
            // 
            this.ubtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.ubtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ubtnLogin.FillColor = System.Drawing.Color.LavenderBlush;
            this.ubtnLogin.FillHoverColor = System.Drawing.Color.CornflowerBlue;
            this.ubtnLogin.Font = new System.Drawing.Font("楷体", 15.12605F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ubtnLogin.ForeColor = System.Drawing.Color.Black;
            this.ubtnLogin.Location = new System.Drawing.Point(28, 233);
            this.ubtnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.ubtnLogin.Name = "ubtnLogin";
            this.ubtnLogin.Radius = 30;
            this.ubtnLogin.RectColor = System.Drawing.Color.Transparent;
            this.ubtnLogin.Size = new System.Drawing.Size(376, 45);
            this.ubtnLogin.Style = Sunny.UI.UIStyle.Custom;
            this.ubtnLogin.TabIndex = 20;
            this.ubtnLogin.Text = "登录";
            this.ubtnLogin.Click += new System.EventHandler(this.ubtnLogin_Click);
            // 
            // cbkRememberPwd
            // 
            this.cbkRememberPwd.AutoSize = true;
            this.cbkRememberPwd.Font = new System.Drawing.Font("楷体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbkRememberPwd.Location = new System.Drawing.Point(28, 192);
            this.cbkRememberPwd.Name = "cbkRememberPwd";
            this.cbkRememberPwd.Size = new System.Drawing.Size(120, 25);
            this.cbkRememberPwd.TabIndex = 25;
            this.cbkRememberPwd.Text = "记住密码";
            this.cbkRememberPwd.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Location = new System.Drawing.Point(165, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 42);
            this.panel2.TabIndex = 23;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.Blue;
            this.linkLabel2.Font = new System.Drawing.Font("楷体", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabel2.Location = new System.Drawing.Point(150, 13);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(106, 24);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "忘记密码";
            this.linkLabel2.Click += new System.EventHandler(this.linkLabel2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Font = new System.Drawing.Font("楷体", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabel1.Location = new System.Drawing.Point(30, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(118, 24);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "立即注册|";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1209, 589);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbkRememberPwd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Sunny.UI.UIButton ubtnLogin;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.TextBox txtUserPwd;
    }
}

