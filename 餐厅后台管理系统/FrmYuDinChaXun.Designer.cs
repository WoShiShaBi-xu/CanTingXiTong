
namespace 餐厅后台管理系统 {
    partial class FrmYuDinChaXun {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvYuDin = new Sunny.UI.UIDataGridView();
            this.dpDateTime = new Sunny.UI.UIDatePicker();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYuDin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvYuDin
            // 
            this.dgvYuDin.AllowUserToAddRows = false;
            this.dgvYuDin.AllowUserToDeleteRows = false;
            this.dgvYuDin.AllowUserToResizeColumns = false;
            this.dgvYuDin.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvYuDin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvYuDin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYuDin.BackgroundColor = System.Drawing.Color.White;
            this.dgvYuDin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvYuDin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvYuDin.ColumnHeadersHeight = 32;
            this.dgvYuDin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvYuDin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvYuDin.EnableHeadersVisualStyles = false;
            this.dgvYuDin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvYuDin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvYuDin.Location = new System.Drawing.Point(0, 99);
            this.dgvYuDin.Name = "dgvYuDin";
            this.dgvYuDin.RowHeadersVisible = false;
            this.dgvYuDin.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvYuDin.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvYuDin.RowTemplate.Height = 29;
            this.dgvYuDin.SelectedIndex = -1;
            this.dgvYuDin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYuDin.ShowGridLine = true;
            this.dgvYuDin.Size = new System.Drawing.Size(1140, 620);
            this.dgvYuDin.TabIndex = 0;
            // 
            // dpDateTime
            // 
            this.dpDateTime.FillColor = System.Drawing.Color.White;
            this.dpDateTime.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dpDateTime.Location = new System.Drawing.Point(191, 43);
            this.dpDateTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpDateTime.MaxLength = 10;
            this.dpDateTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpDateTime.Name = "dpDateTime";
            this.dpDateTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpDateTime.Size = new System.Drawing.Size(187, 34);
            this.dpDateTime.SymbolDropDown = 61555;
            this.dpDateTime.SymbolNormal = 61555;
            this.dpDateTime.TabIndex = 1;
            this.dpDateTime.Text = "2021-02-25";
            this.dpDateTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpDateTime.Value = new System.DateTime(2021, 2, 25, 15, 35, 5, 395);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(84, 46);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "日期";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(404, 40);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(121, 38);
            this.ucBtnExt1.TabIndex = 3;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.ucBtnExt1_BtnClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "YuDingId";
            this.Column1.HeaderText = "预定id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "YuDingXingMing";
            this.Column2.HeaderText = "客户姓名";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "YuDingPhone";
            this.Column3.HeaderText = "预定电话";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "YuDingShiJian";
            this.Column4.HeaderText = "预定时间";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "预定座位";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "YuDingJinE";
            this.Column6.HeaderText = "预定金额";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // FrmYuDinChaXun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 719);
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.dpDateTime);
            this.Controls.Add(this.dgvYuDin);
            this.Name = "FrmYuDinChaXun";
            this.Text = "预定查询";
            ((System.ComponentModel.ISupportInitialize)(this.dgvYuDin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView dgvYuDin;
        private Sunny.UI.UIDatePicker dpDateTime;
        private Sunny.UI.UILabel uiLabel1;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}