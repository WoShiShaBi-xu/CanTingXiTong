
namespace 餐厅
{
    partial class FrmYuDing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYuDing));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtName = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btnYuDing = new Sunny.UI.UIButton();
            this.cboZuoWei = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txtPhone = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txtMoney = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.tpTime = new Sunny.UI.UITimePicker();
            this.btnReturn = new Sunny.UI.UIButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvYuLiu = new Sunny.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYuLiu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FillColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtName.Location = new System.Drawing.Point(162, 52);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Maximum = 2147483647D;
            this.txtName.Minimum = -2147483648D;
            this.txtName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(5);
            this.txtName.Radius = 15;
            this.txtName.RectColor = System.Drawing.Color.Silver;
            this.txtName.Size = new System.Drawing.Size(257, 34);
            this.txtName.Style = Sunny.UI.UIStyle.Custom;
            this.txtName.TabIndex = 0;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(35, 52);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(120, 35);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "客人姓名：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnYuDing
            // 
            this.btnYuDing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYuDing.FillColor = System.Drawing.Color.Tan;
            this.btnYuDing.FillHoverColor = System.Drawing.Color.Peru;
            this.btnYuDing.FillPressColor = System.Drawing.Color.Peru;
            this.btnYuDing.FillSelectedColor = System.Drawing.Color.Peru;
            this.btnYuDing.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnYuDing.Location = new System.Drawing.Point(787, 575);
            this.btnYuDing.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnYuDing.Name = "btnYuDing";
            this.btnYuDing.Radius = 20;
            this.btnYuDing.RectColor = System.Drawing.Color.White;
            this.btnYuDing.RectHoverColor = System.Drawing.Color.Peru;
            this.btnYuDing.RectPressColor = System.Drawing.Color.Peru;
            this.btnYuDing.RectSelectedColor = System.Drawing.Color.Peru;
            this.btnYuDing.Size = new System.Drawing.Size(174, 43);
            this.btnYuDing.Style = Sunny.UI.UIStyle.Custom;
            this.btnYuDing.TabIndex = 2;
            this.btnYuDing.Text = "预定";
            // 
            // cboZuoWei
            // 
            this.cboZuoWei.FillColor = System.Drawing.Color.White;
            this.cboZuoWei.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cboZuoWei.Location = new System.Drawing.Point(162, 126);
            this.cboZuoWei.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboZuoWei.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboZuoWei.Name = "cboZuoWei";
            this.cboZuoWei.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboZuoWei.Radius = 15;
            this.cboZuoWei.RectColor = System.Drawing.Color.Silver;
            this.cboZuoWei.Size = new System.Drawing.Size(257, 34);
            this.cboZuoWei.Style = Sunny.UI.UIStyle.Custom;
            this.cboZuoWei.TabIndex = 3;
            this.cboZuoWei.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(35, 126);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(120, 35);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "预定座位：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FillColor = System.Drawing.Color.White;
            this.txtPhone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtPhone.Location = new System.Drawing.Point(162, 200);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Maximum = 2147483647D;
            this.txtPhone.Minimum = -2147483648D;
            this.txtPhone.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(5);
            this.txtPhone.Radius = 15;
            this.txtPhone.RectColor = System.Drawing.Color.Silver;
            this.txtPhone.Size = new System.Drawing.Size(257, 34);
            this.txtPhone.Style = Sunny.UI.UIStyle.Custom;
            this.txtPhone.TabIndex = 0;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(35, 200);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(120, 35);
            this.uiLabel3.TabIndex = 1;
            this.uiLabel3.Text = "预留电话：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMoney
            // 
            this.txtMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoney.FillColor = System.Drawing.Color.White;
            this.txtMoney.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtMoney.Location = new System.Drawing.Point(162, 274);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoney.Maximum = 2147483647D;
            this.txtMoney.Minimum = -2147483648D;
            this.txtMoney.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Padding = new System.Windows.Forms.Padding(5);
            this.txtMoney.Radius = 15;
            this.txtMoney.RectColor = System.Drawing.Color.Silver;
            this.txtMoney.Size = new System.Drawing.Size(257, 34);
            this.txtMoney.Style = Sunny.UI.UIStyle.Custom;
            this.txtMoney.TabIndex = 0;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(35, 274);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(120, 35);
            this.uiLabel4.TabIndex = 1;
            this.uiLabel4.Text = "预付金额：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(35, 348);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(120, 35);
            this.uiLabel5.TabIndex = 1;
            this.uiLabel5.Text = "预定时间：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpTime
            // 
            this.tpTime.FillColor = System.Drawing.Color.White;
            this.tpTime.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tpTime.Location = new System.Drawing.Point(162, 348);
            this.tpTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpTime.MaxLength = 8;
            this.tpTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.tpTime.Name = "tpTime";
            this.tpTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.tpTime.Radius = 15;
            this.tpTime.RectColor = System.Drawing.Color.Silver;
            this.tpTime.Size = new System.Drawing.Size(257, 34);
            this.tpTime.Style = Sunny.UI.UIStyle.Custom;
            this.tpTime.SymbolDropDown = 61555;
            this.tpTime.SymbolNormal = 61555;
            this.tpTime.TabIndex = 4;
            this.tpTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tpTime.Value = new System.DateTime(2021, 2, 23, 10, 15, 41, 989);
            // 
            // btnReturn
            // 
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FillColor = System.Drawing.Color.Silver;
            this.btnReturn.FillHoverColor = System.Drawing.Color.Gray;
            this.btnReturn.FillPressColor = System.Drawing.Color.Gray;
            this.btnReturn.FillSelectedColor = System.Drawing.Color.Gray;
            this.btnReturn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnReturn.Location = new System.Drawing.Point(1014, 575);
            this.btnReturn.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Radius = 20;
            this.btnReturn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReturn.RectHoverColor = System.Drawing.Color.Gray;
            this.btnReturn.RectPressColor = System.Drawing.Color.Gray;
            this.btnReturn.RectSelectedColor = System.Drawing.Color.Gray;
            this.btnReturn.Size = new System.Drawing.Size(182, 43);
            this.btnReturn.Style = Sunny.UI.UIStyle.Custom;
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "返回";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1217, 27);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(63, 24);
            this.toolStripButton2.Text = "登记";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(63, 24);
            this.toolStripButton3.Text = "修改";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(63, 24);
            this.toolStripButton4.Text = "刷新";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(63, 24);
            this.toolStripButton5.Text = "删除";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtMoney);
            this.groupBox1.Controls.Add(this.tpTime);
            this.groupBox1.Controls.Add(this.uiLabel1);
            this.groupBox1.Controls.Add(this.cboZuoWei);
            this.groupBox1.Controls.Add(this.uiLabel3);
            this.groupBox1.Controls.Add(this.uiLabel4);
            this.groupBox1.Controls.Add(this.uiLabel5);
            this.groupBox1.Controls.Add(this.uiLabel2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.groupBox1.Location = new System.Drawing.Point(747, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 408);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "顾客信息";
            // 
            // dgvYuLiu
            // 
            this.dgvYuLiu.AllowUserToAddRows = false;
            this.dgvYuLiu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvYuLiu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvYuLiu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYuLiu.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvYuLiu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvYuLiu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvYuLiu.ColumnHeadersHeight = 32;
            this.dgvYuLiu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvYuLiu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvYuLiu.EnableHeadersVisualStyles = false;
            this.dgvYuLiu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvYuLiu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvYuLiu.Location = new System.Drawing.Point(12, 31);
            this.dgvYuLiu.Name = "dgvYuLiu";
            this.dgvYuLiu.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvYuLiu.RowHeadersVisible = false;
            this.dgvYuLiu.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvYuLiu.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvYuLiu.RowTemplate.Height = 29;
            this.dgvYuLiu.SelectedIndex = -1;
            this.dgvYuLiu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYuLiu.ShowGridLine = true;
            this.dgvYuLiu.Size = new System.Drawing.Size(714, 682);
            this.dgvYuLiu.StripeOddColor = System.Drawing.Color.White;
            this.dgvYuLiu.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "顾客名称";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "预定座位";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "预留电话";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "预付金额";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "预定时间";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // FrmYuDing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 725);
            this.Controls.Add(this.dgvYuLiu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnYuDing);
            this.Controls.Add(this.btnReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmYuDing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客人预定";
            this.Load += new System.EventHandler(this.FrmYuDing_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYuLiu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btnYuDing;
        private Sunny.UI.UIComboBox cboZuoWei;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtPhone;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtMoney;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITimePicker tpTime;
        private Sunny.UI.UIButton btnReturn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.GroupBox groupBox1;
        private Sunny.UI.UIDataGridView dgvYuLiu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}