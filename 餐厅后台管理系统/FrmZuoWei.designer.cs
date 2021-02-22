
namespace 餐厅后台管理系统
{
    partial class FrmZuoWei
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmZuoWei));
            this.dgvSearchZuoWei = new Sunny.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CboLouCeng = new Sunny.UI.UIComboBox();
            this.txtZuoWeiMiaoShu = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btnSearch = new Sunny.UI.UIButton();
            this.btnBreak = new Sunny.UI.UIButton();
            this.btnSave = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchZuoWei)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchZuoWei
            // 
            this.dgvSearchZuoWei.AllowUserToAddRows = false;
            this.dgvSearchZuoWei.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.dgvSearchZuoWei.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearchZuoWei.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchZuoWei.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearchZuoWei.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSearchZuoWei.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchZuoWei.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearchZuoWei.ColumnHeadersHeight = 32;
            this.dgvSearchZuoWei.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSearchZuoWei.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dgvSearchZuoWei.EnableHeadersVisualStyles = false;
            this.dgvSearchZuoWei.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvSearchZuoWei.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvSearchZuoWei.Location = new System.Drawing.Point(9, 58);
            this.dgvSearchZuoWei.Name = "dgvSearchZuoWei";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchZuoWei.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSearchZuoWei.RowHeadersVisible = false;
            this.dgvSearchZuoWei.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvSearchZuoWei.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSearchZuoWei.RowTemplate.Height = 29;
            this.dgvSearchZuoWei.SelectedIndex = -1;
            this.dgvSearchZuoWei.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchZuoWei.Size = new System.Drawing.Size(967, 628);
            this.dgvSearchZuoWei.StripeOddColor = System.Drawing.Color.LightBlue;
            this.dgvSearchZuoWei.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ZuoWeiId";
            this.Column1.HeaderText = "座位编号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ZuoWeiBeiZhu";
            this.Column2.HeaderText = "座位描述";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CengShuMiaoShu";
            this.Column4.HeaderText = "隶属于";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "停/用设置";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CboLouCeng
            // 
            this.CboLouCeng.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CboLouCeng.FillColor = System.Drawing.Color.White;
            this.CboLouCeng.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CboLouCeng.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CboLouCeng.Location = new System.Drawing.Point(507, 12);
            this.CboLouCeng.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CboLouCeng.MinimumSize = new System.Drawing.Size(63, 0);
            this.CboLouCeng.Name = "CboLouCeng";
            this.CboLouCeng.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.CboLouCeng.Size = new System.Drawing.Size(186, 34);
            this.CboLouCeng.TabIndex = 12;
            this.CboLouCeng.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtZuoWeiMiaoShu
            // 
            this.txtZuoWeiMiaoShu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtZuoWeiMiaoShu.FillColor = System.Drawing.Color.White;
            this.txtZuoWeiMiaoShu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtZuoWeiMiaoShu.Location = new System.Drawing.Point(169, 12);
            this.txtZuoWeiMiaoShu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtZuoWeiMiaoShu.Maximum = 2147483647D;
            this.txtZuoWeiMiaoShu.Minimum = -2147483648D;
            this.txtZuoWeiMiaoShu.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtZuoWeiMiaoShu.Name = "txtZuoWeiMiaoShu";
            this.txtZuoWeiMiaoShu.Padding = new System.Windows.Forms.Padding(5);
            this.txtZuoWeiMiaoShu.Size = new System.Drawing.Size(199, 34);
            this.txtZuoWeiMiaoShu.TabIndex = 11;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(436, 13);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(83, 34);
            this.uiLabel2.TabIndex = 9;
            this.uiLabel2.Text = "楼层：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(16, 12);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(146, 34);
            this.uiLabel1.TabIndex = 10;
            this.uiLabel1.Text = "座位描述：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FillColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnSearch.Location = new System.Drawing.Point(764, 12);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Radius = 30;
            this.btnSearch.Size = new System.Drawing.Size(127, 35);
            this.btnSearch.Style = Sunny.UI.UIStyle.Custom;
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "检索";
            // 
            // btnBreak
            // 
            this.btnBreak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBreak.FillColor = System.Drawing.Color.SlateGray;
            this.btnBreak.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBreak.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBreak.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnBreak.Location = new System.Drawing.Point(839, 705);
            this.btnBreak.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Radius = 15;
            this.btnBreak.Size = new System.Drawing.Size(110, 39);
            this.btnBreak.Style = Sunny.UI.UIStyle.Custom;
            this.btnBreak.TabIndex = 7;
            this.btnBreak.Text = "返回";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.Firebrick;
            this.btnSave.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSave.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnSave.Location = new System.Drawing.Point(704, 705);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Radius = 15;
            this.btnSave.Size = new System.Drawing.Size(110, 39);
            this.btnSave.Style = Sunny.UI.UIStyle.Custom;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            // 
            // FrmZuoWeiTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 757);
            this.Controls.Add(this.dgvSearchZuoWei);
            this.Controls.Add(this.CboLouCeng);
            this.Controls.Add(this.txtZuoWeiMiaoShu);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmZuoWeiTwo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "座位停/用设置";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchZuoWei)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView dgvSearchZuoWei;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private Sunny.UI.UIComboBox CboLouCeng;
        private Sunny.UI.UITextBox txtZuoWeiMiaoShu;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btnSearch;
        private Sunny.UI.UIButton btnBreak;
        private Sunny.UI.UIButton btnSave;
    }
}