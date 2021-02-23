
namespace 餐厅 {
    partial class FormJiaDan {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("节点0");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("节点0", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("全部", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJiaDan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tvCaiPinLeiBie = new Sunny.UI.UITreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCaiPinLieBiao = new Sunny.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvYiDian = new Sunny.UI.UIDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBreak = new HZH_Controls.Controls.UCBtnExt();
            this.btnChuangDan = new HZH_Controls.Controls.UCBtnExt();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCanZhuoHao = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.TxtKeRenCount = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.txtFuWuYuan = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.txtDanShu = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txtBeiZhu = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.txtKaiTaiTime = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txtKaiTaiRen = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.txtLiuShuiDan = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txtCaiPinName = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.btnSearch = new HZH_Controls.Controls.UCBtnExt();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaiPinLieBiao)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYiDian)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox2.Controls.Add(this.tvCaiPinLeiBie);
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 794);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "菜品类别";
            // 
            // tvCaiPinLeiBie
            // 
            this.tvCaiPinLeiBie.FillColor = System.Drawing.Color.White;
            this.tvCaiPinLeiBie.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tvCaiPinLeiBie.Location = new System.Drawing.Point(7, 26);
            this.tvCaiPinLeiBie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvCaiPinLeiBie.MinimumSize = new System.Drawing.Size(1, 1);
            this.tvCaiPinLeiBie.Name = "tvCaiPinLeiBie";
            treeNode4.Name = "节点0";
            treeNode4.Text = "节点0";
            treeNode5.Name = "节点0";
            treeNode5.Text = "节点0";
            treeNode6.Name = "节点0";
            treeNode6.Text = "全部";
            this.tvCaiPinLeiBie.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.tvCaiPinLeiBie.RectColor = System.Drawing.Color.Silver;
            this.tvCaiPinLeiBie.SelectedNode = null;
            this.tvCaiPinLeiBie.Size = new System.Drawing.Size(205, 760);
            this.tvCaiPinLeiBie.Style = Sunny.UI.UIStyle.Custom;
            this.tvCaiPinLeiBie.TabIndex = 0;
            this.tvCaiPinLeiBie.Text = "uiTreeView1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "文件夹.png");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCaiPinLieBiao);
            this.groupBox3.Location = new System.Drawing.Point(237, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 794);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "菜品列表";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dgvCaiPinLieBiao
            // 
            this.dgvCaiPinLieBiao.AllowUserToAddRows = false;
            this.dgvCaiPinLieBiao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvCaiPinLieBiao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCaiPinLieBiao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaiPinLieBiao.BackgroundColor = System.Drawing.Color.White;
            this.dgvCaiPinLieBiao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaiPinLieBiao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCaiPinLieBiao.ColumnHeadersHeight = 32;
            this.dgvCaiPinLieBiao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCaiPinLieBiao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvCaiPinLieBiao.EnableHeadersVisualStyles = false;
            this.dgvCaiPinLieBiao.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvCaiPinLieBiao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvCaiPinLieBiao.Location = new System.Drawing.Point(0, 24);
            this.dgvCaiPinLieBiao.Name = "dgvCaiPinLieBiao";
            this.dgvCaiPinLieBiao.ReadOnly = true;
            this.dgvCaiPinLieBiao.RectColor = System.Drawing.Color.Silver;
            this.dgvCaiPinLieBiao.RowHeadersVisible = false;
            this.dgvCaiPinLieBiao.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvCaiPinLieBiao.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCaiPinLieBiao.RowTemplate.Height = 29;
            this.dgvCaiPinLieBiao.SelectedIndex = -1;
            this.dgvCaiPinLieBiao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaiPinLieBiao.ShowGridLine = true;
            this.dgvCaiPinLieBiao.Size = new System.Drawing.Size(628, 762);
            this.dgvCaiPinLieBiao.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "编号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "名称";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "价格";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "特价";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvYiDian);
            this.groupBox4.Location = new System.Drawing.Point(883, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1128, 794);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "已点列表";
            // 
            // dgvYiDian
            // 
            this.dgvYiDian.AllowUserToAddRows = false;
            this.dgvYiDian.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvYiDian.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvYiDian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYiDian.BackgroundColor = System.Drawing.Color.White;
            this.dgvYiDian.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvYiDian.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvYiDian.ColumnHeadersHeight = 32;
            this.dgvYiDian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvYiDian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvYiDian.EnableHeadersVisualStyles = false;
            this.dgvYiDian.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvYiDian.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvYiDian.Location = new System.Drawing.Point(19, 24);
            this.dgvYiDian.Name = "dgvYiDian";
            this.dgvYiDian.ReadOnly = true;
            this.dgvYiDian.RectColor = System.Drawing.Color.Silver;
            this.dgvYiDian.RowHeadersVisible = false;
            this.dgvYiDian.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgvYiDian.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvYiDian.RowTemplate.Height = 29;
            this.dgvYiDian.SelectedIndex = -1;
            this.dgvYiDian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYiDian.ShowGridLine = true;
            this.dgvYiDian.Size = new System.Drawing.Size(1102, 754);
            this.dgvYiDian.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "编号";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "名称";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "价格";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "特价";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // btnBreak
            // 
            this.btnBreak.BackColor = System.Drawing.Color.White;
            this.btnBreak.BtnBackColor = System.Drawing.Color.White;
            this.btnBreak.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBreak.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(61)))), ((int)(((byte)(67)))));
            this.btnBreak.BtnText = "返回";
            this.btnBreak.ConerRadius = 35;
            this.btnBreak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBreak.EnabledMouseEffect = false;
            this.btnBreak.FillColor = System.Drawing.Color.Silver;
            this.btnBreak.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnBreak.IsRadius = true;
            this.btnBreak.IsShowRect = true;
            this.btnBreak.IsShowTips = false;
            this.btnBreak.Location = new System.Drawing.Point(1785, 984);
            this.btnBreak.Margin = new System.Windows.Forms.Padding(0);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.btnBreak.RectWidth = 1;
            this.btnBreak.Size = new System.Drawing.Size(120, 45);
            this.btnBreak.TabIndex = 5;
            this.btnBreak.TabStop = false;
            this.btnBreak.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnBreak.TipsText = "";
            this.btnBreak.BtnClick += new System.EventHandler(this.btnJiaDan_BtnClick);
            // 
            // btnChuangDan
            // 
            this.btnChuangDan.BackColor = System.Drawing.Color.White;
            this.btnChuangDan.BtnBackColor = System.Drawing.Color.White;
            this.btnChuangDan.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChuangDan.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(61)))), ((int)(((byte)(67)))));
            this.btnChuangDan.BtnText = "传单";
            this.btnChuangDan.ConerRadius = 35;
            this.btnChuangDan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChuangDan.EnabledMouseEffect = false;
            this.btnChuangDan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.btnChuangDan.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnChuangDan.IsRadius = true;
            this.btnChuangDan.IsShowRect = true;
            this.btnChuangDan.IsShowTips = false;
            this.btnChuangDan.Location = new System.Drawing.Point(1651, 984);
            this.btnChuangDan.Margin = new System.Windows.Forms.Padding(0);
            this.btnChuangDan.Name = "btnChuangDan";
            this.btnChuangDan.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.btnChuangDan.RectWidth = 1;
            this.btnChuangDan.Size = new System.Drawing.Size(120, 45);
            this.btnChuangDan.TabIndex = 5;
            this.btnChuangDan.TabStop = false;
            this.btnChuangDan.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnChuangDan.TipsText = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCanZhuoHao);
            this.groupBox1.Controls.Add(this.uiLabel4);
            this.groupBox1.Controls.Add(this.TxtKeRenCount);
            this.groupBox1.Controls.Add(this.uiLabel6);
            this.groupBox1.Controls.Add(this.txtFuWuYuan);
            this.groupBox1.Controls.Add(this.uiLabel8);
            this.groupBox1.Controls.Add(this.txtDanShu);
            this.groupBox1.Controls.Add(this.uiLabel3);
            this.groupBox1.Controls.Add(this.txtBeiZhu);
            this.groupBox1.Controls.Add(this.uiLabel7);
            this.groupBox1.Controls.Add(this.txtKaiTaiTime);
            this.groupBox1.Controls.Add(this.uiLabel2);
            this.groupBox1.Controls.Add(this.txtKaiTaiRen);
            this.groupBox1.Controls.Add(this.uiLabel5);
            this.groupBox1.Controls.Add(this.txtLiuShuiDan);
            this.groupBox1.Controls.Add(this.uiLabel1);
            this.groupBox1.Location = new System.Drawing.Point(19, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1991, 147);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // txtCanZhuoHao
            // 
            this.txtCanZhuoHao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCanZhuoHao.FillColor = System.Drawing.Color.White;
            this.txtCanZhuoHao.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCanZhuoHao.Location = new System.Drawing.Point(1407, 26);
            this.txtCanZhuoHao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCanZhuoHao.Maximum = 2147483647D;
            this.txtCanZhuoHao.Minimum = -2147483648D;
            this.txtCanZhuoHao.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCanZhuoHao.Name = "txtCanZhuoHao";
            this.txtCanZhuoHao.Padding = new System.Windows.Forms.Padding(5);
            this.txtCanZhuoHao.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCanZhuoHao.Size = new System.Drawing.Size(316, 34);
            this.txtCanZhuoHao.Style = Sunny.UI.UIStyle.Custom;
            this.txtCanZhuoHao.TabIndex = 11;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(1273, 33);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(104, 23);
            this.uiLabel4.TabIndex = 4;
            this.uiLabel4.Text = "餐桌号：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtKeRenCount
            // 
            this.TxtKeRenCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtKeRenCount.FillColor = System.Drawing.Color.White;
            this.TxtKeRenCount.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TxtKeRenCount.Location = new System.Drawing.Point(490, 87);
            this.TxtKeRenCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtKeRenCount.Maximum = 2147483647D;
            this.TxtKeRenCount.Minimum = -2147483648D;
            this.TxtKeRenCount.MinimumSize = new System.Drawing.Size(1, 1);
            this.TxtKeRenCount.Name = "TxtKeRenCount";
            this.TxtKeRenCount.Padding = new System.Windows.Forms.Padding(5);
            this.TxtKeRenCount.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtKeRenCount.Size = new System.Drawing.Size(78, 34);
            this.TxtKeRenCount.Style = Sunny.UI.UIStyle.Custom;
            this.TxtKeRenCount.TabIndex = 12;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(353, 90);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(115, 23);
            this.uiLabel6.TabIndex = 5;
            this.uiLabel6.Text = "客人数量：";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFuWuYuan
            // 
            this.txtFuWuYuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFuWuYuan.FillColor = System.Drawing.Color.White;
            this.txtFuWuYuan.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtFuWuYuan.Location = new System.Drawing.Point(1632, 87);
            this.txtFuWuYuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFuWuYuan.Maximum = 2147483647D;
            this.txtFuWuYuan.Minimum = -2147483648D;
            this.txtFuWuYuan.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFuWuYuan.Name = "txtFuWuYuan";
            this.txtFuWuYuan.Padding = new System.Windows.Forms.Padding(5);
            this.txtFuWuYuan.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFuWuYuan.Size = new System.Drawing.Size(188, 34);
            this.txtFuWuYuan.Style = Sunny.UI.UIStyle.Custom;
            this.txtFuWuYuan.TabIndex = 13;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.Location = new System.Drawing.Point(1510, 91);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(97, 23);
            this.uiLabel8.TabIndex = 6;
            this.uiLabel8.Text = "服务员：";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDanShu
            // 
            this.txtDanShu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDanShu.FillColor = System.Drawing.Color.White;
            this.txtDanShu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtDanShu.Location = new System.Drawing.Point(1166, 26);
            this.txtDanShu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDanShu.Maximum = 2147483647D;
            this.txtDanShu.Minimum = -2147483648D;
            this.txtDanShu.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDanShu.Name = "txtDanShu";
            this.txtDanShu.Padding = new System.Windows.Forms.Padding(5);
            this.txtDanShu.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDanShu.Size = new System.Drawing.Size(69, 34);
            this.txtDanShu.Style = Sunny.UI.UIStyle.Custom;
            this.txtDanShu.TabIndex = 13;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(1082, 29);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(87, 23);
            this.uiLabel3.TabIndex = 6;
            this.uiLabel3.Text = "单数：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBeiZhu
            // 
            this.txtBeiZhu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBeiZhu.FillColor = System.Drawing.Color.White;
            this.txtBeiZhu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtBeiZhu.Location = new System.Drawing.Point(687, 87);
            this.txtBeiZhu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBeiZhu.Maximum = 2147483647D;
            this.txtBeiZhu.Minimum = -2147483648D;
            this.txtBeiZhu.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBeiZhu.Name = "txtBeiZhu";
            this.txtBeiZhu.Padding = new System.Windows.Forms.Padding(5);
            this.txtBeiZhu.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBeiZhu.Size = new System.Drawing.Size(794, 34);
            this.txtBeiZhu.Style = Sunny.UI.UIStyle.Custom;
            this.txtBeiZhu.TabIndex = 14;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(613, 89);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(103, 23);
            this.uiLabel7.TabIndex = 7;
            this.uiLabel7.Text = "备注：";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKaiTaiTime
            // 
            this.txtKaiTaiTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKaiTaiTime.FillColor = System.Drawing.Color.White;
            this.txtKaiTaiTime.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtKaiTaiTime.Location = new System.Drawing.Point(655, 26);
            this.txtKaiTaiTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKaiTaiTime.Maximum = 2147483647D;
            this.txtKaiTaiTime.Minimum = -2147483648D;
            this.txtKaiTaiTime.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtKaiTaiTime.Name = "txtKaiTaiTime";
            this.txtKaiTaiTime.Padding = new System.Windows.Forms.Padding(5);
            this.txtKaiTaiTime.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtKaiTaiTime.Size = new System.Drawing.Size(402, 34);
            this.txtKaiTaiTime.Style = Sunny.UI.UIStyle.Custom;
            this.txtKaiTaiTime.TabIndex = 15;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(525, 33);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(123, 23);
            this.uiLabel2.TabIndex = 8;
            this.uiLabel2.Text = "开单时间：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKaiTaiRen
            // 
            this.txtKaiTaiRen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKaiTaiRen.FillColor = System.Drawing.Color.White;
            this.txtKaiTaiRen.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtKaiTaiRen.Location = new System.Drawing.Point(104, 87);
            this.txtKaiTaiRen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKaiTaiRen.Maximum = 2147483647D;
            this.txtKaiTaiRen.Minimum = -2147483648D;
            this.txtKaiTaiRen.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtKaiTaiRen.Name = "txtKaiTaiRen";
            this.txtKaiTaiRen.Padding = new System.Windows.Forms.Padding(5);
            this.txtKaiTaiRen.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtKaiTaiRen.Size = new System.Drawing.Size(207, 34);
            this.txtKaiTaiRen.Style = Sunny.UI.UIStyle.Custom;
            this.txtKaiTaiRen.TabIndex = 16;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(18, 94);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(100, 23);
            this.uiLabel5.TabIndex = 9;
            this.uiLabel5.Text = "开台人：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLiuShuiDan
            // 
            this.txtLiuShuiDan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLiuShuiDan.FillColor = System.Drawing.Color.White;
            this.txtLiuShuiDan.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtLiuShuiDan.Location = new System.Drawing.Point(104, 26);
            this.txtLiuShuiDan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLiuShuiDan.Maximum = 2147483647D;
            this.txtLiuShuiDan.Minimum = -2147483648D;
            this.txtLiuShuiDan.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtLiuShuiDan.Name = "txtLiuShuiDan";
            this.txtLiuShuiDan.Padding = new System.Windows.Forms.Padding(5);
            this.txtLiuShuiDan.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLiuShuiDan.Size = new System.Drawing.Size(402, 34);
            this.txtLiuShuiDan.Style = Sunny.UI.UIStyle.Custom;
            this.txtLiuShuiDan.TabIndex = 17;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(18, 33);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 10;
            this.uiLabel1.Text = "流水单：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCaiPinName
            // 
            this.txtCaiPinName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCaiPinName.FillColor = System.Drawing.Color.White;
            this.txtCaiPinName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCaiPinName.Location = new System.Drawing.Point(432, 984);
            this.txtCaiPinName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCaiPinName.Maximum = 2147483647D;
            this.txtCaiPinName.Minimum = -2147483648D;
            this.txtCaiPinName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCaiPinName.Name = "txtCaiPinName";
            this.txtCaiPinName.Padding = new System.Windows.Forms.Padding(5);
            this.txtCaiPinName.RectColor = System.Drawing.Color.Gray;
            this.txtCaiPinName.Size = new System.Drawing.Size(226, 34);
            this.txtCaiPinName.Style = Sunny.UI.UIStyle.Custom;
            this.txtCaiPinName.TabIndex = 18;
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel9.Location = new System.Drawing.Point(198, 989);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(227, 23);
            this.uiLabel9.TabIndex = 17;
            this.uiLabel9.Text = "菜品名(支持模糊查询)：";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BtnBackColor = System.Drawing.Color.White;
            this.btnSearch.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(61)))), ((int)(((byte)(67)))));
            this.btnSearch.BtnText = "查询";
            this.btnSearch.ConerRadius = 35;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.EnabledMouseEffect = false;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSearch.IsRadius = true;
            this.btnSearch.IsShowRect = true;
            this.btnSearch.IsShowTips = false;
            this.btnSearch.Location = new System.Drawing.Point(693, 976);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.btnSearch.RectWidth = 1;
            this.btnSearch.Size = new System.Drawing.Size(120, 45);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.TabStop = false;
            this.btnSearch.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnSearch.TipsText = "";
            // 
            // FormJiaDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtCaiPinName);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnChuangDan);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormJiaDan";
            this.Text = "加单点菜";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaiPinLieBiao)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYiDian)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private HZH_Controls.Controls.UCBtnExt btnBreak;
        private HZH_Controls.Controls.UCBtnExt btnChuangDan;
        private Sunny.UI.UITreeView tvCaiPinLeiBie;
        private System.Windows.Forms.GroupBox groupBox1;
        private Sunny.UI.UITextBox txtCanZhuoHao;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox TxtKeRenCount;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox txtDanShu;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtBeiZhu;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox txtKaiTaiTime;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtKaiTaiRen;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox txtLiuShuiDan;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtFuWuYuan;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox txtCaiPinName;
        private Sunny.UI.UILabel uiLabel9;
        private HZH_Controls.Controls.UCBtnExt btnSearch;
        private Sunny.UI.UIDataGridView dgvCaiPinLieBiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Sunny.UI.UIDataGridView dgvYiDian;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}