
namespace 餐厅后台管理系统
{
    partial class FrmYuanGongChaXun
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYuanGongChaXun));
            this.label2 = new System.Windows.Forms.Label();
            this.修改信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dgvYuanGongMessage = new Sunny.UI.UIDataGridView();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.rbNv = new Sunny.UI.UIRadioButton();
            this.rbNan = new Sunny.UI.UIRadioButton();
            this.txtYuanGongName = new HZH_Controls.Controls.TextBoxEx();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZhiWeiName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYuanGongMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(989, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "(右键删除)";
            // 
            // 修改信息ToolStripMenuItem
            // 
            this.修改信息ToolStripMenuItem.Name = "修改信息ToolStripMenuItem";
            this.修改信息ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.修改信息ToolStripMenuItem.Text = "修改信息";
            this.修改信息ToolStripMenuItem.Click += new System.EventHandler(this.修改信息ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.修改信息ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 52);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "员工姓名";
            // 
            // dgvYuanGongMessage
            // 
            this.dgvYuanGongMessage.AllowUserToAddRows = false;
            this.dgvYuanGongMessage.AllowUserToDeleteRows = false;
            this.dgvYuanGongMessage.AllowUserToResizeColumns = false;
            this.dgvYuanGongMessage.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvYuanGongMessage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvYuanGongMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYuanGongMessage.BackgroundColor = System.Drawing.Color.White;
            this.dgvYuanGongMessage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvYuanGongMessage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvYuanGongMessage.ColumnHeadersHeight = 32;
            this.dgvYuanGongMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvYuanGongMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.ZhiWeiName,
            this.Column7});
            this.dgvYuanGongMessage.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvYuanGongMessage.EnableHeadersVisualStyles = false;
            this.dgvYuanGongMessage.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvYuanGongMessage.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvYuanGongMessage.Location = new System.Drawing.Point(12, 101);
            this.dgvYuanGongMessage.Name = "dgvYuanGongMessage";
            this.dgvYuanGongMessage.ReadOnly = true;
            this.dgvYuanGongMessage.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvYuanGongMessage.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvYuanGongMessage.RowTemplate.Height = 29;
            this.dgvYuanGongMessage.SelectedIndex = -1;
            this.dgvYuanGongMessage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYuanGongMessage.ShowGridLine = true;
            this.dgvYuanGongMessage.Size = new System.Drawing.Size(1103, 472);
            this.dgvYuanGongMessage.TabIndex = 15;
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "查询";
            this.ucBtnExt1.ConerRadius = 35;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = false;
            this.ucBtnExt1.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(713, 26);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.DeepSkyBlue;
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(159, 39);
            this.ucBtnExt1.TabIndex = 14;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.ucBtnExt1_BtnClick_1);
            // 
            // rbNv
            // 
            this.rbNv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNv.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rbNv.Location = new System.Drawing.Point(615, 32);
            this.rbNv.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbNv.Name = "rbNv";
            this.rbNv.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbNv.Size = new System.Drawing.Size(75, 24);
            this.rbNv.TabIndex = 12;
            this.rbNv.Text = "女";
            // 
            // rbNan
            // 
            this.rbNan.Checked = true;
            this.rbNan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNan.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.rbNan.Location = new System.Drawing.Point(549, 32);
            this.rbNan.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbNan.Name = "rbNan";
            this.rbNan.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbNan.Size = new System.Drawing.Size(103, 24);
            this.rbNan.TabIndex = 13;
            this.rbNan.Text = "男";
            // 
            // txtYuanGongName
            // 
            this.txtYuanGongName.DecLength = 2;
            this.txtYuanGongName.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtYuanGongName.Location = new System.Drawing.Point(259, 31);
            this.txtYuanGongName.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtYuanGongName.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtYuanGongName.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtYuanGongName.Name = "txtYuanGongName";
            this.txtYuanGongName.OldText = null;
            this.txtYuanGongName.PromptColor = System.Drawing.Color.Gray;
            this.txtYuanGongName.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtYuanGongName.PromptText = "";
            this.txtYuanGongName.RegexPattern = "";
            this.txtYuanGongName.Size = new System.Drawing.Size(259, 25);
            this.txtYuanGongName.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "YuanGongId";
            this.Column1.HeaderText = "工号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "YuanGongXingMing";
            this.Column2.HeaderText = "姓名";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "YuanGongGender";
            this.Column3.HeaderText = "性别";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "YuanGongShengRi";
            this.Column4.HeaderText = "生日";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "YuanGongGongZi";
            this.Column5.HeaderText = "工资";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // ZhiWeiName
            // 
            this.ZhiWeiName.DataPropertyName = "ZhiWeiMIngCheng";
            this.ZhiWeiName.HeaderText = "职位";
            this.ZhiWeiName.MinimumWidth = 6;
            this.ZhiWeiName.Name = "ZhiWeiName";
            this.ZhiWeiName.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "YuanGongShenFengZheng";
            this.Column7.HeaderText = "身份证";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // FrmYuanGongChaXun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 599);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvYuanGongMessage);
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.rbNv);
            this.Controls.Add(this.rbNan);
            this.Controls.Add(this.txtYuanGongName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmYuanGongChaXun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工查询";
            this.Load += new System.EventHandler(this.FrmYuanGongChaXun_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYuanGongMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 修改信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIDataGridView dgvYuanGongMessage;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private Sunny.UI.UIRadioButton rbNv;
        private Sunny.UI.UIRadioButton rbNan;
        private HZH_Controls.Controls.TextBoxEx txtYuanGongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZhiWeiName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}