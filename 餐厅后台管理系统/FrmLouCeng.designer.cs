
namespace 餐厅后台管理系统
{
    partial class FrmLouCeng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLouCeng));
            this.dgvSearchLouCeng = new Sunny.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBreak = new Sunny.UI.UIButton();
            this.btnSave = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchLouCeng)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchLouCeng
            // 
            this.dgvSearchLouCeng.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.dgvSearchLouCeng.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearchLouCeng.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchLouCeng.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearchLouCeng.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSearchLouCeng.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchLouCeng.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearchLouCeng.ColumnHeadersHeight = 32;
            this.dgvSearchLouCeng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSearchLouCeng.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvSearchLouCeng.EnableHeadersVisualStyles = false;
            this.dgvSearchLouCeng.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvSearchLouCeng.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvSearchLouCeng.Location = new System.Drawing.Point(12, 12);
            this.dgvSearchLouCeng.Name = "dgvSearchLouCeng";
            this.dgvSearchLouCeng.RowHeadersVisible = false;
            this.dgvSearchLouCeng.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvSearchLouCeng.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSearchLouCeng.RowTemplate.Height = 29;
            this.dgvSearchLouCeng.SelectedIndex = -1;
            this.dgvSearchLouCeng.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchLouCeng.Size = new System.Drawing.Size(533, 394);
            this.dgvSearchLouCeng.StripeOddColor = System.Drawing.Color.LightBlue;
            this.dgvSearchLouCeng.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "楼层描述";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "可使用否";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnBreak
            // 
            this.btnBreak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBreak.FillColor = System.Drawing.Color.SlateGray;
            this.btnBreak.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBreak.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBreak.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnBreak.Location = new System.Drawing.Point(435, 412);
            this.btnBreak.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Radius = 15;
            this.btnBreak.Size = new System.Drawing.Size(110, 39);
            this.btnBreak.Style = Sunny.UI.UIStyle.Custom;
            this.btnBreak.TabIndex = 5;
            this.btnBreak.Text = "返回";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.Firebrick;
            this.btnSave.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSave.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnSave.Location = new System.Drawing.Point(300, 412);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Radius = 15;
            this.btnSave.Size = new System.Drawing.Size(110, 39);
            this.btnSave.Style = Sunny.UI.UIStyle.Custom;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            // 
            // FrmLouCengTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 463);
            this.Controls.Add(this.dgvSearchLouCeng);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLouCengTwo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "餐厅楼层设置";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchLouCeng)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView dgvSearchLouCeng;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private Sunny.UI.UIButton btnBreak;
        private Sunny.UI.UIButton btnSave;
    }
}