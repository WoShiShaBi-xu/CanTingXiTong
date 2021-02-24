
namespace 餐厅后台管理系统
{
    partial class FrmAddZuoWei
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddZuoWei));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.ubtnAdd = new Sunny.UI.UIButton();
            this.utxtShuLiang = new Sunny.UI.UITextBox();
            this.ucmbLouCeng = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.ubtnBreak = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(57, 36);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(73, 23);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "楼层：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ubtnAdd
            // 
            this.ubtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ubtnAdd.FillColor = System.Drawing.Color.SkyBlue;
            this.ubtnAdd.FillHoverColor = System.Drawing.Color.CornflowerBlue;
            this.ubtnAdd.FillPressColor = System.Drawing.Color.CornflowerBlue;
            this.ubtnAdd.FillSelectedColor = System.Drawing.Color.CornflowerBlue;
            this.ubtnAdd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ubtnAdd.Location = new System.Drawing.Point(58, 190);
            this.ubtnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.ubtnAdd.Name = "ubtnAdd";
            this.ubtnAdd.Radius = 20;
            this.ubtnAdd.Size = new System.Drawing.Size(156, 44);
            this.ubtnAdd.Style = Sunny.UI.UIStyle.Custom;
            this.ubtnAdd.TabIndex = 2;
            this.ubtnAdd.Text = "添加";
            this.ubtnAdd.Click += new System.EventHandler(this.ubtnAdd_Click);
            // 
            // utxtShuLiang
            // 
            this.utxtShuLiang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.utxtShuLiang.FillColor = System.Drawing.Color.White;
            this.utxtShuLiang.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.utxtShuLiang.Location = new System.Drawing.Point(150, 121);
            this.utxtShuLiang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.utxtShuLiang.Maximum = 2147483647D;
            this.utxtShuLiang.Minimum = -2147483648D;
            this.utxtShuLiang.MinimumSize = new System.Drawing.Size(1, 1);
            this.utxtShuLiang.Name = "utxtShuLiang";
            this.utxtShuLiang.Padding = new System.Windows.Forms.Padding(5);
            this.utxtShuLiang.Size = new System.Drawing.Size(235, 34);
            this.utxtShuLiang.TabIndex = 3;
            // 
            // ucmbLouCeng
            // 
            this.ucmbLouCeng.FillColor = System.Drawing.Color.White;
            this.ucmbLouCeng.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ucmbLouCeng.Location = new System.Drawing.Point(150, 33);
            this.ucmbLouCeng.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucmbLouCeng.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucmbLouCeng.Name = "ucmbLouCeng";
            this.ucmbLouCeng.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucmbLouCeng.Size = new System.Drawing.Size(235, 34);
            this.ucmbLouCeng.TabIndex = 4;
            this.ucmbLouCeng.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(22, 124);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(118, 23);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "座位数量：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ubtnBreak
            // 
            this.ubtnBreak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ubtnBreak.FillColor = System.Drawing.Color.Silver;
            this.ubtnBreak.FillHoverColor = System.Drawing.Color.Gray;
            this.ubtnBreak.FillPressColor = System.Drawing.Color.Gray;
            this.ubtnBreak.FillSelectedColor = System.Drawing.Color.Gray;
            this.ubtnBreak.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ubtnBreak.Location = new System.Drawing.Point(279, 190);
            this.ubtnBreak.MinimumSize = new System.Drawing.Size(1, 1);
            this.ubtnBreak.Name = "ubtnBreak";
            this.ubtnBreak.Radius = 20;
            this.ubtnBreak.RectColor = System.Drawing.Color.Gray;
            this.ubtnBreak.Size = new System.Drawing.Size(156, 44);
            this.ubtnBreak.Style = Sunny.UI.UIStyle.Custom;
            this.ubtnBreak.TabIndex = 2;
            this.ubtnBreak.Text = "返回";
            this.ubtnBreak.Click += new System.EventHandler(this.ubtnBreak_Click);
            // 
            // FrmAddZuoWei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 283);
            this.Controls.Add(this.ucmbLouCeng);
            this.Controls.Add(this.utxtShuLiang);
            this.Controls.Add(this.ubtnBreak);
            this.Controls.Add(this.ubtnAdd);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAddZuoWei";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加座位设置";
            this.Load += new System.EventHandler(this.FrmAddZuoWei_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton ubtnAdd;
        private Sunny.UI.UITextBox utxtShuLiang;
        private Sunny.UI.UIComboBox ucmbLouCeng;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton ubtnBreak;
    }
}