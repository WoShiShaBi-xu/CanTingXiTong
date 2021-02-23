
namespace CanTingLogin
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegistrationEmail = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ubtnRegistration = new Sunny.UI.UIButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.White;
            this.txtPwd.Font = new System.Drawing.Font("楷体", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.Location = new System.Drawing.Point(121, 95);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(305, 27);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("楷体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(46, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "帐号：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("楷体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(46, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "密码：";
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.BackColor = System.Drawing.Color.White;
            this.txtConfirmPwd.Font = new System.Drawing.Font("楷体", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtConfirmPwd.Location = new System.Drawing.Point(121, 163);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.PasswordChar = '*';
            this.txtConfirmPwd.Size = new System.Drawing.Size(305, 27);
            this.txtConfirmPwd.TabIndex = 2;
            this.txtConfirmPwd.Tag = "";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.Font = new System.Drawing.Font("楷体", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserName.Location = new System.Drawing.Point(121, 27);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(305, 27);
            this.txtUserName.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("楷体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(15, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "确认密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("方正舒体", 41.7479F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(511, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 73);
            this.label1.TabIndex = 29;
            this.label1.Text = "注册帐号";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ubtnRegistration);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRegistrationEmail);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.txtPwd);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtConfirmPwd);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(120, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 387);
            this.panel1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "邮箱号：";
            // 
            // txtRegistrationEmail
            // 
            this.txtRegistrationEmail.BackColor = System.Drawing.Color.White;
            this.txtRegistrationEmail.Font = new System.Drawing.Font("楷体", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRegistrationEmail.Location = new System.Drawing.Point(121, 231);
            this.txtRegistrationEmail.Name = "txtRegistrationEmail";
            this.txtRegistrationEmail.Size = new System.Drawing.Size(305, 27);
            this.txtRegistrationEmail.TabIndex = 28;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("楷体", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(312, 353);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(106, 24);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "返回登录";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // ubtnRegistration
            // 
            this.ubtnRegistration.BackColor = System.Drawing.Color.Transparent;
            this.ubtnRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ubtnRegistration.FillColor = System.Drawing.Color.LavenderBlush;
            this.ubtnRegistration.Font = new System.Drawing.Font("楷体", 15.12605F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ubtnRegistration.ForeColor = System.Drawing.Color.Black;
            this.ubtnRegistration.Location = new System.Drawing.Point(50, 286);
            this.ubtnRegistration.MinimumSize = new System.Drawing.Size(1, 1);
            this.ubtnRegistration.Name = "ubtnRegistration";
            this.ubtnRegistration.Radius = 30;
            this.ubtnRegistration.RectColor = System.Drawing.Color.Transparent;
            this.ubtnRegistration.Size = new System.Drawing.Size(357, 44);
            this.ubtnRegistration.Style = Sunny.UI.UIStyle.Custom;
            this.ubtnRegistration.TabIndex = 30;
            this.ubtnRegistration.Text = "立即注册";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1209, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册新账号";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegistrationEmail;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Sunny.UI.UIButton ubtnRegistration;
    }
}