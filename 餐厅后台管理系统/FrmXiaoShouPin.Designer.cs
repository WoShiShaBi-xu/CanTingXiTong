﻿
namespace 餐厅后台管理系统
{
    partial class FrmXiaoShouPin
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("全部");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmXiaoShouPin));
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiButton5 = new Sunny.UI.UIButton();
            this.uiButton4 = new Sunny.UI.UIButton();
            this.ucmbDanWei = new Sunny.UI.UIComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.ucmbCaiPinType = new Sunny.UI.UIComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.utxtPrice = new Sunny.UI.UITextBox();
            this.utxtKuCun = new Sunny.UI.UITextBox();
            this.utxtDianDanShu = new Sunny.UI.UITextBox();
            this.utxtTeJia = new Sunny.UI.UITextBox();
            this.utxtName = new Sunny.UI.UITextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.utvXiaoShouPin = new Sunny.UI.UITreeView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvXiaosShouPin = new Sunny.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDanWei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLeiXing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubtnXiaYiYe = new Sunny.UI.UIButton();
            this.ubtnShangyiYe = new Sunny.UI.UIButton();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.utvXiaoShouPin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXiaosShouPin)).BeginInit();
            this.SuspendLayout();
            // 
            // uiButton3
            // 
            this.uiButton3.BackColor = System.Drawing.Color.Transparent;
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.FillColor = System.Drawing.Color.Brown;
            this.uiButton3.FillHoverColor = System.Drawing.Color.IndianRed;
            this.uiButton3.FillPressColor = System.Drawing.Color.Red;
            this.uiButton3.FillSelectedColor = System.Drawing.Color.Red;
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton3.Location = new System.Drawing.Point(1147, 759);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Radius = 20;
            this.uiButton3.RectColor = System.Drawing.Color.Transparent;
            this.uiButton3.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiButton3.RectPressColor = System.Drawing.Color.Transparent;
            this.uiButton3.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiButton3.Size = new System.Drawing.Size(147, 40);
            this.uiButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton3.TabIndex = 11;
            this.uiButton3.Text = "保存";
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiButton5
            // 
            this.uiButton5.BackColor = System.Drawing.Color.Transparent;
            this.uiButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton5.FillColor = System.Drawing.Color.Silver;
            this.uiButton5.FillHoverColor = System.Drawing.Color.Gray;
            this.uiButton5.FillPressColor = System.Drawing.Color.Gray;
            this.uiButton5.FillSelectedColor = System.Drawing.Color.Silver;
            this.uiButton5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton5.Location = new System.Drawing.Point(1329, 759);
            this.uiButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton5.Name = "uiButton5";
            this.uiButton5.Radius = 20;
            this.uiButton5.RectColor = System.Drawing.Color.Transparent;
            this.uiButton5.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiButton5.RectPressColor = System.Drawing.Color.Transparent;
            this.uiButton5.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiButton5.Size = new System.Drawing.Size(147, 40);
            this.uiButton5.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton5.TabIndex = 5;
            this.uiButton5.Text = "关闭";
            this.uiButton5.Click += new System.EventHandler(this.uiButton5_Click);
            // 
            // uiButton4
            // 
            this.uiButton4.BackColor = System.Drawing.Color.Transparent;
            this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton4.FillColor = System.Drawing.Color.SkyBlue;
            this.uiButton4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton4.Location = new System.Drawing.Point(783, 759);
            this.uiButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton4.Name = "uiButton4";
            this.uiButton4.Radius = 20;
            this.uiButton4.RectColor = System.Drawing.Color.Transparent;
            this.uiButton4.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiButton4.RectPressColor = System.Drawing.Color.Transparent;
            this.uiButton4.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiButton4.Size = new System.Drawing.Size(147, 40);
            this.uiButton4.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton4.TabIndex = 6;
            this.uiButton4.Text = "添加";
            this.uiButton4.Click += new System.EventHandler(this.uiButton4_Click);
            // 
            // ucmbDanWei
            // 
            this.ucmbDanWei.FillColor = System.Drawing.Color.White;
            this.ucmbDanWei.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ucmbDanWei.Items.AddRange(new object[] {
            "--请选择--"});
            this.ucmbDanWei.Location = new System.Drawing.Point(121, 147);
            this.ucmbDanWei.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucmbDanWei.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucmbDanWei.Name = "ucmbDanWei";
            this.ucmbDanWei.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucmbDanWei.RectColor = System.Drawing.Color.SkyBlue;
            this.ucmbDanWei.Size = new System.Drawing.Size(150, 34);
            this.ucmbDanWei.Style = Sunny.UI.UIStyle.Custom;
            this.ucmbDanWei.TabIndex = 17;
            this.ucmbDanWei.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("楷体", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(56, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "单位";
            // 
            // uiButton2
            // 
            this.uiButton2.BackColor = System.Drawing.Color.Transparent;
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.FillColor = System.Drawing.Color.Firebrick;
            this.uiButton2.FillHoverColor = System.Drawing.Color.Red;
            this.uiButton2.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uiButton2.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2.Location = new System.Drawing.Point(965, 759);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Radius = 20;
            this.uiButton2.RectColor = System.Drawing.Color.Transparent;
            this.uiButton2.RectHoverColor = System.Drawing.Color.Transparent;
            this.uiButton2.RectPressColor = System.Drawing.Color.Transparent;
            this.uiButton2.RectSelectedColor = System.Drawing.Color.Transparent;
            this.uiButton2.Size = new System.Drawing.Size(147, 40);
            this.uiButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton2.TabIndex = 9;
            this.uiButton2.Text = "删除";
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // ucmbCaiPinType
            // 
            this.ucmbCaiPinType.FillColor = System.Drawing.Color.White;
            this.ucmbCaiPinType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ucmbCaiPinType.Items.AddRange(new object[] {
            "--请选择--"});
            this.ucmbCaiPinType.Location = new System.Drawing.Point(472, 103);
            this.ucmbCaiPinType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucmbCaiPinType.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucmbCaiPinType.Name = "ucmbCaiPinType";
            this.ucmbCaiPinType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucmbCaiPinType.RectColor = System.Drawing.Color.SkyBlue;
            this.ucmbCaiPinType.Size = new System.Drawing.Size(251, 34);
            this.ucmbCaiPinType.Style = Sunny.UI.UIStyle.Custom;
            this.ucmbCaiPinType.TabIndex = 2;
            this.ucmbCaiPinType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ucmbDanWei);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.ucmbCaiPinType);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.utxtPrice);
            this.groupBox3.Controls.Add(this.utxtKuCun);
            this.groupBox3.Controls.Add(this.utxtDianDanShu);
            this.groupBox3.Controls.Add(this.utxtTeJia);
            this.groupBox3.Controls.Add(this.utxtName);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("楷体", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(327, 560);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1149, 193);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "销售品详细信息显示项";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(768, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "库存";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(359, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "菜品类型";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(32, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "点单数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(768, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "特价";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(407, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "价格";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(56, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "描述";
            // 
            // utxtPrice
            // 
            this.utxtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.utxtPrice.FillColor = System.Drawing.Color.White;
            this.utxtPrice.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.utxtPrice.Location = new System.Drawing.Point(472, 46);
            this.utxtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.utxtPrice.Maximum = 2147483647D;
            this.utxtPrice.Minimum = -2147483648D;
            this.utxtPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.utxtPrice.Name = "utxtPrice";
            this.utxtPrice.Padding = new System.Windows.Forms.Padding(5);
            this.utxtPrice.Size = new System.Drawing.Size(251, 34);
            this.utxtPrice.TabIndex = 19;
            // 
            // utxtKuCun
            // 
            this.utxtKuCun.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.utxtKuCun.FillColor = System.Drawing.Color.White;
            this.utxtKuCun.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.utxtKuCun.Location = new System.Drawing.Point(833, 103);
            this.utxtKuCun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.utxtKuCun.Maximum = 2147483647D;
            this.utxtKuCun.Minimum = -2147483648D;
            this.utxtKuCun.MinimumSize = new System.Drawing.Size(1, 1);
            this.utxtKuCun.Name = "utxtKuCun";
            this.utxtKuCun.Padding = new System.Windows.Forms.Padding(5);
            this.utxtKuCun.Size = new System.Drawing.Size(257, 34);
            this.utxtKuCun.TabIndex = 19;
            // 
            // utxtDianDanShu
            // 
            this.utxtDianDanShu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.utxtDianDanShu.FillColor = System.Drawing.Color.White;
            this.utxtDianDanShu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.utxtDianDanShu.Location = new System.Drawing.Point(121, 103);
            this.utxtDianDanShu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.utxtDianDanShu.Maximum = 2147483647D;
            this.utxtDianDanShu.Minimum = -2147483648D;
            this.utxtDianDanShu.MinimumSize = new System.Drawing.Size(1, 1);
            this.utxtDianDanShu.Name = "utxtDianDanShu";
            this.utxtDianDanShu.Padding = new System.Windows.Forms.Padding(5);
            this.utxtDianDanShu.Size = new System.Drawing.Size(124, 34);
            this.utxtDianDanShu.TabIndex = 20;
            // 
            // utxtTeJia
            // 
            this.utxtTeJia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.utxtTeJia.FillColor = System.Drawing.Color.White;
            this.utxtTeJia.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.utxtTeJia.Location = new System.Drawing.Point(833, 46);
            this.utxtTeJia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.utxtTeJia.Maximum = 2147483647D;
            this.utxtTeJia.Minimum = -2147483648D;
            this.utxtTeJia.MinimumSize = new System.Drawing.Size(1, 1);
            this.utxtTeJia.Name = "utxtTeJia";
            this.utxtTeJia.Padding = new System.Windows.Forms.Padding(5);
            this.utxtTeJia.Size = new System.Drawing.Size(257, 34);
            this.utxtTeJia.TabIndex = 21;
            // 
            // utxtName
            // 
            this.utxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.utxtName.FillColor = System.Drawing.Color.White;
            this.utxtName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.utxtName.Location = new System.Drawing.Point(121, 46);
            this.utxtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.utxtName.Maximum = 2147483647D;
            this.utxtName.Minimum = -2147483648D;
            this.utxtName.MinimumSize = new System.Drawing.Size(1, 1);
            this.utxtName.Name = "utxtName";
            this.utxtName.Padding = new System.Windows.Forms.Padding(5);
            this.utxtName.Size = new System.Drawing.Size(257, 34);
            this.utxtName.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.utvXiaoShouPin);
            this.groupBox1.Font = new System.Drawing.Font("楷体", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 794);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "销售品类别管理";
            // 
            // utvXiaoShouPin
            // 
            this.utvXiaoShouPin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.utvXiaoShouPin.Controls.Add(this.treeView1);
            this.utvXiaoShouPin.FillColor = System.Drawing.Color.White;
            this.utvXiaoShouPin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.utvXiaoShouPin.Location = new System.Drawing.Point(7, 26);
            this.utvXiaoShouPin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.utvXiaoShouPin.MinimumSize = new System.Drawing.Size(1, 1);
            this.utvXiaoShouPin.Name = "utvXiaoShouPin";
            treeNode1.Name = "节点0";
            treeNode1.Text = "全部";
            this.utvXiaoShouPin.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.utvXiaoShouPin.RectColor = System.Drawing.Color.SkyBlue;
            this.utvXiaoShouPin.SelectedNode = null;
            this.utvXiaoShouPin.Size = new System.Drawing.Size(292, 761);
            this.utvXiaoShouPin.Style = Sunny.UI.UIStyle.Custom;
            this.utvXiaoShouPin.TabIndex = 1;
            this.utvXiaoShouPin.Text = "uiTreeView1";
            this.utvXiaoShouPin.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.utvXiaoShouPin_AfterSelect);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(170, 140);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvXiaosShouPin);
            this.groupBox2.Font = new System.Drawing.Font("楷体", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(324, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1149, 496);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "销售品菜单列表";
            // 
            // dgvXiaosShouPin
            // 
            this.dgvXiaosShouPin.AllowUserToAddRows = false;
            this.dgvXiaosShouPin.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvXiaosShouPin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvXiaosShouPin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvXiaosShouPin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXiaosShouPin.BackgroundColor = System.Drawing.Color.White;
            this.dgvXiaosShouPin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXiaosShouPin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvXiaosShouPin.ColumnHeadersHeight = 32;
            this.dgvXiaosShouPin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvXiaosShouPin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.clDanWei,
            this.Column4,
            this.clLeiXing,
            this.Column6});
            this.dgvXiaosShouPin.EnableHeadersVisualStyles = false;
            this.dgvXiaosShouPin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvXiaosShouPin.GridColor = System.Drawing.Color.SkyBlue;
            this.dgvXiaosShouPin.Location = new System.Drawing.Point(12, 26);
            this.dgvXiaosShouPin.Name = "dgvXiaosShouPin";
            this.dgvXiaosShouPin.ReadOnly = true;
            this.dgvXiaosShouPin.RectColor = System.Drawing.Color.SkyBlue;
            this.dgvXiaosShouPin.RowHeadersVisible = false;
            this.dgvXiaosShouPin.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvXiaosShouPin.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvXiaosShouPin.RowTemplate.Height = 29;
            this.dgvXiaosShouPin.SelectedIndex = -1;
            this.dgvXiaosShouPin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXiaosShouPin.ShowGridLine = true;
            this.dgvXiaosShouPin.Size = new System.Drawing.Size(1137, 461);
            this.dgvXiaosShouPin.TabIndex = 0;
            this.dgvXiaosShouPin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXiaosShouPin_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "caiPinMingZi";
            this.Column1.HeaderText = "描述";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CaiPinJiaGe";
            this.Column2.HeaderText = "价格";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CaiPinTeJia";
            this.Column3.HeaderText = "特价";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // clDanWei
            // 
            this.clDanWei.DataPropertyName = "DanWeiMiaoShu";
            this.clDanWei.HeaderText = "单位";
            this.clDanWei.MinimumWidth = 6;
            this.clDanWei.Name = "clDanWei";
            this.clDanWei.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CaiPinDianDanShu";
            this.Column4.HeaderText = "点单数";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // clLeiXing
            // 
            this.clLeiXing.DataPropertyName = "CaiPinFenLeiMiaoShu";
            this.clLeiXing.HeaderText = "菜品类型";
            this.clLeiXing.MinimumWidth = 6;
            this.clLeiXing.Name = "clLeiXing";
            this.clLeiXing.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "CaiPinKuCun";
            this.Column6.HeaderText = "库存";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // ubtnXiaYiYe
            // 
            this.ubtnXiaYiYe.BackColor = System.Drawing.Color.Transparent;
            this.ubtnXiaYiYe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ubtnXiaYiYe.FillColor = System.Drawing.Color.SkyBlue;
            this.ubtnXiaYiYe.FillHoverColor = System.Drawing.Color.Red;
            this.ubtnXiaYiYe.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ubtnXiaYiYe.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ubtnXiaYiYe.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ubtnXiaYiYe.Location = new System.Drawing.Point(1326, 514);
            this.ubtnXiaYiYe.MinimumSize = new System.Drawing.Size(1, 1);
            this.ubtnXiaYiYe.Name = "ubtnXiaYiYe";
            this.ubtnXiaYiYe.Radius = 20;
            this.ubtnXiaYiYe.RectColor = System.Drawing.Color.Transparent;
            this.ubtnXiaYiYe.RectHoverColor = System.Drawing.Color.Transparent;
            this.ubtnXiaYiYe.RectPressColor = System.Drawing.Color.Transparent;
            this.ubtnXiaYiYe.RectSelectedColor = System.Drawing.Color.Transparent;
            this.ubtnXiaYiYe.Size = new System.Drawing.Size(147, 40);
            this.ubtnXiaYiYe.Style = Sunny.UI.UIStyle.Custom;
            this.ubtnXiaYiYe.TabIndex = 9;
            this.ubtnXiaYiYe.Text = "下一页";
            this.ubtnXiaYiYe.Click += new System.EventHandler(this.ubtnXiaYiYe_Click);
            // 
            // ubtnShangyiYe
            // 
            this.ubtnShangyiYe.BackColor = System.Drawing.Color.Transparent;
            this.ubtnShangyiYe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ubtnShangyiYe.FillColor = System.Drawing.Color.SkyBlue;
            this.ubtnShangyiYe.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ubtnShangyiYe.Location = new System.Drawing.Point(1144, 514);
            this.ubtnShangyiYe.MinimumSize = new System.Drawing.Size(1, 1);
            this.ubtnShangyiYe.Name = "ubtnShangyiYe";
            this.ubtnShangyiYe.Radius = 20;
            this.ubtnShangyiYe.RectColor = System.Drawing.Color.Transparent;
            this.ubtnShangyiYe.RectHoverColor = System.Drawing.Color.Transparent;
            this.ubtnShangyiYe.RectPressColor = System.Drawing.Color.Transparent;
            this.ubtnShangyiYe.RectSelectedColor = System.Drawing.Color.Transparent;
            this.ubtnShangyiYe.Size = new System.Drawing.Size(147, 40);
            this.ubtnShangyiYe.Style = Sunny.UI.UIStyle.Custom;
            this.ubtnShangyiYe.TabIndex = 6;
            this.ubtnShangyiYe.Text = "上一页";
            this.ubtnShangyiYe.Click += new System.EventHandler(this.ubtnShangyiYe_Click);
            // 
            // FrmXiaoShouPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 814);
            this.Controls.Add(this.uiButton3);
            this.Controls.Add(this.uiButton5);
            this.Controls.Add(this.ubtnShangyiYe);
            this.Controls.Add(this.uiButton4);
            this.Controls.Add(this.ubtnXiaYiYe);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmXiaoShouPin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售品查询";
            this.Load += new System.EventHandler(this.FrmXiaoShouPin_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.utvXiaoShouPin.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXiaosShouPin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIButton uiButton5;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIComboBox ucmbDanWei;
        private System.Windows.Forms.Label label8;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIComboBox ucmbCaiPinType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UITextBox utxtKuCun;
        private Sunny.UI.UITextBox utxtDianDanShu;
        private Sunny.UI.UITextBox utxtTeJia;
        private Sunny.UI.UITextBox utxtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private Sunny.UI.UITreeView utvXiaoShouPin;
        private System.Windows.Forms.GroupBox groupBox2;
        private Sunny.UI.UIDataGridView dgvXiaosShouPin;
        private Sunny.UI.UITextBox utxtPrice;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDanWei;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLeiXing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Sunny.UI.UIButton ubtnXiaYiYe;
        private Sunny.UI.UIButton ubtnShangyiYe;
    }
}