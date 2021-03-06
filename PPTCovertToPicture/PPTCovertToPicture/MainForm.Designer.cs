﻿namespace PPTCovertToPicture
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_covert = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PPTSaveUrl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_saveUrl = new System.Windows.Forms.Label();
            this.btn_saveUrl = new System.Windows.Forms.Button();
            this.btn_jiemi = new System.Windows.Forms.Button();
            this.btn_jiami = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cBx_DanHao = new System.Windows.Forms.ComboBox();
            this.dataGridView_KD = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_KDN = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cBx_ShipperCode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_CheckKD = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ChooseScreen = new System.Windows.Forms.Button();
            this.btn_SaveScreen = new System.Windows.Forms.Button();
            this.btn_FullScreen = new System.Windows.Forms.Button();
            this.lb_SaveScreen = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lblResult = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButtonGoogle = new System.Windows.Forms.RadioButton();
            this.radioButtonYouDao = new System.Windows.Forms.RadioButton();
            this.radioButtonBaiDu = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTrans = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.timer_Time = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.功能介绍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开发者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KD)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(17, 27);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "选择PPT";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_covert
            // 
            this.btn_covert.Location = new System.Drawing.Point(179, 27);
            this.btn_covert.Name = "btn_covert";
            this.btn_covert.Size = new System.Drawing.Size(75, 23);
            this.btn_covert.TabIndex = 1;
            this.btn_covert.Text = "开始转换";
            this.btn_covert.UseVisualStyleBackColor = true;
            this.btn_covert.Click += new System.EventHandler(this.btn_covert_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(98, 27);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "保存位置";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "PPT转图片";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 131);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.PPTSaveUrl);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_covert);
            this.panel1.Controls.Add(this.btn_open);
            this.panel1.Location = new System.Drawing.Point(13, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 248);
            this.panel1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.Location = new System.Drawing.Point(310, 27);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 106);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "拖拽至此";
            this.textBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox2_DragDrop);
            this.textBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox2_DragEnter);
            // 
            // PPTSaveUrl
            // 
            this.PPTSaveUrl.AutoSize = true;
            this.PPTSaveUrl.Location = new System.Drawing.Point(9, 84);
            this.PPTSaveUrl.MaximumSize = new System.Drawing.Size(320, 0);
            this.PPTSaveUrl.Name = "PPTSaveUrl";
            this.PPTSaveUrl.Size = new System.Drawing.Size(53, 12);
            this.PPTSaveUrl.TabIndex = 6;
            this.PPTSaveUrl.Text = "保存位置";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lb_saveUrl);
            this.panel2.Controls.Add(this.btn_saveUrl);
            this.panel2.Controls.Add(this.btn_jiemi);
            this.panel2.Controls.Add(this.btn_jiami);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(14, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 208);
            this.panel2.TabIndex = 7;
            // 
            // lb_saveUrl
            // 
            this.lb_saveUrl.AutoSize = true;
            this.lb_saveUrl.Location = new System.Drawing.Point(3, 136);
            this.lb_saveUrl.MaximumSize = new System.Drawing.Size(320, 0);
            this.lb_saveUrl.Name = "lb_saveUrl";
            this.lb_saveUrl.Size = new System.Drawing.Size(53, 12);
            this.lb_saveUrl.TabIndex = 7;
            this.lb_saveUrl.Text = "保存位置";
            // 
            // btn_saveUrl
            // 
            this.btn_saveUrl.Location = new System.Drawing.Point(5, 100);
            this.btn_saveUrl.Name = "btn_saveUrl";
            this.btn_saveUrl.Size = new System.Drawing.Size(75, 23);
            this.btn_saveUrl.TabIndex = 11;
            this.btn_saveUrl.Text = "保存位置";
            this.btn_saveUrl.UseVisualStyleBackColor = true;
            this.btn_saveUrl.Click += new System.EventHandler(this.btn_saveUrl_Click);
            // 
            // btn_jiemi
            // 
            this.btn_jiemi.Location = new System.Drawing.Point(229, 176);
            this.btn_jiemi.Name = "btn_jiemi";
            this.btn_jiemi.Size = new System.Drawing.Size(75, 23);
            this.btn_jiemi.TabIndex = 10;
            this.btn_jiemi.Text = "解密";
            this.btn_jiemi.UseVisualStyleBackColor = true;
            this.btn_jiemi.Click += new System.EventHandler(this.btn_jiemi_Click);
            // 
            // btn_jiami
            // 
            this.btn_jiami.Location = new System.Drawing.Point(124, 176);
            this.btn_jiami.Name = "btn_jiami";
            this.btn_jiami.Size = new System.Drawing.Size(75, 23);
            this.btn_jiami.TabIndex = 9;
            this.btn_jiami.Text = "加密";
            this.btn_jiami.UseVisualStyleBackColor = true;
            this.btn_jiami.Click += new System.EventHandler(this.btn_jiami_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.MaximumSize = new System.Drawing.Size(320, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "文档位置";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "选择文档";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "加密解密文档";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(7, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(462, 301);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(454, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PPT转图片";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(454, 275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "文本文档加密解密";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cBx_DanHao);
            this.tabPage3.Controls.Add(this.dataGridView_KD);
            this.tabPage3.Controls.Add(this.lb_KDN);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.cBx_ShipperCode);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btn_CheckKD);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(454, 275);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "快递查询";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cBx_DanHao
            // 
            this.cBx_DanHao.FormattingEnabled = true;
            this.cBx_DanHao.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cBx_DanHao.Items.AddRange(new object[] {
            "清除记录"});
            this.cBx_DanHao.Location = new System.Drawing.Point(104, 42);
            this.cBx_DanHao.Name = "cBx_DanHao";
            this.cBx_DanHao.Size = new System.Drawing.Size(181, 20);
            this.cBx_DanHao.Sorted = true;
            this.cBx_DanHao.TabIndex = 9;
            this.cBx_DanHao.SelectedIndexChanged += new System.EventHandler(this.cBx_DanHao_SelectedIndexChanged);
            this.cBx_DanHao.TextChanged += new System.EventHandler(this.cBx_DanHao_TextChanged);
            this.cBx_DanHao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cBx_DanHao_MouseClick);
            // 
            // dataGridView_KD
            // 
            this.dataGridView_KD.AllowUserToDeleteRows = false;
            this.dataGridView_KD.AllowUserToResizeColumns = false;
            this.dataGridView_KD.AllowUserToResizeRows = false;
            this.dataGridView_KD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_KD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.状态,
            this.Remark});
            this.dataGridView_KD.Location = new System.Drawing.Point(23, 119);
            this.dataGridView_KD.Name = "dataGridView_KD";
            this.dataGridView_KD.RowHeadersVisible = false;
            this.dataGridView_KD.RowHeadersWidth = 4;
            this.dataGridView_KD.RowTemplate.Height = 23;
            this.dataGridView_KD.Size = new System.Drawing.Size(417, 141);
            this.dataGridView_KD.TabIndex = 8;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.time.HeaderText = "时间";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 54;
            // 
            // 状态
            // 
            this.状态.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.状态.HeaderText = "状态";
            this.状态.Name = "状态";
            this.状态.ReadOnly = true;
            this.状态.Width = 54;
            // 
            // Remark
            // 
            this.Remark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Width = 54;
            // 
            // lb_KDN
            // 
            this.lb_KDN.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_KDN.Location = new System.Drawing.Point(102, 65);
            this.lb_KDN.Name = "lb_KDN";
            this.lb_KDN.Size = new System.Drawing.Size(300, 51);
            this.lb_KDN.TabIndex = 7;
            this.lb_KDN.Text = "null";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "最新动态";
            // 
            // cBx_ShipperCode
            // 
            this.cBx_ShipperCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBx_ShipperCode.FormattingEnabled = true;
            this.cBx_ShipperCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cBx_ShipperCode.Items.AddRange(new object[] {
            "EMS",
            "顺丰",
            "圆通",
            "百世快递",
            "中通",
            "韵达\t",
            "申通",
            "德邦",
            "优速",
            "宅急送",
            "京东",
            "信丰",
            "全峰",
            "跨越速运",
            "安能",
            "快捷",
            "国通",
            "天天",
            "邮政快递包裹"});
            this.cBx_ShipperCode.Location = new System.Drawing.Point(104, 14);
            this.cBx_ShipperCode.Name = "cBx_ShipperCode";
            this.cBx_ShipperCode.Size = new System.Drawing.Size(121, 20);
            this.cBx_ShipperCode.TabIndex = 5;
            this.cBx_ShipperCode.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "请选择快递";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "请输入运单号";
            // 
            // btn_CheckKD
            // 
            this.btn_CheckKD.Location = new System.Drawing.Point(314, 39);
            this.btn_CheckKD.Name = "btn_CheckKD";
            this.btn_CheckKD.Size = new System.Drawing.Size(75, 23);
            this.btn_CheckKD.TabIndex = 1;
            this.btn_CheckKD.Text = "查询";
            this.btn_CheckKD.UseVisualStyleBackColor = true;
            this.btn_CheckKD.Click += new System.EventHandler(this.btn_CheckKD_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.panel3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(454, 275);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "截屏\\录屏";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(239, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 219);
            this.panel4.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "录屏";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "截屏";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_ChooseScreen);
            this.panel3.Controls.Add(this.btn_SaveScreen);
            this.panel3.Controls.Add(this.btn_FullScreen);
            this.panel3.Controls.Add(this.lb_SaveScreen);
            this.panel3.Location = new System.Drawing.Point(3, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 219);
            this.panel3.TabIndex = 3;
            // 
            // btn_ChooseScreen
            // 
            this.btn_ChooseScreen.Enabled = false;
            this.btn_ChooseScreen.Location = new System.Drawing.Point(113, 98);
            this.btn_ChooseScreen.Name = "btn_ChooseScreen";
            this.btn_ChooseScreen.Size = new System.Drawing.Size(75, 35);
            this.btn_ChooseScreen.TabIndex = 2;
            this.btn_ChooseScreen.Text = "鼠标截屏";
            this.btn_ChooseScreen.UseVisualStyleBackColor = true;
            this.btn_ChooseScreen.Click += new System.EventHandler(this.btn_ChooseScreen_Click);
            // 
            // btn_SaveScreen
            // 
            this.btn_SaveScreen.Location = new System.Drawing.Point(5, 21);
            this.btn_SaveScreen.Name = "btn_SaveScreen";
            this.btn_SaveScreen.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveScreen.TabIndex = 0;
            this.btn_SaveScreen.Text = "保存位置";
            this.btn_SaveScreen.UseVisualStyleBackColor = true;
            this.btn_SaveScreen.Click += new System.EventHandler(this.btn_SaveScreen_Click);
            // 
            // btn_FullScreen
            // 
            this.btn_FullScreen.Location = new System.Drawing.Point(5, 98);
            this.btn_FullScreen.Name = "btn_FullScreen";
            this.btn_FullScreen.Size = new System.Drawing.Size(75, 35);
            this.btn_FullScreen.TabIndex = 2;
            this.btn_FullScreen.Text = "截取全屏(&A)";
            this.btn_FullScreen.UseVisualStyleBackColor = true;
            this.btn_FullScreen.Click += new System.EventHandler(this.btn_FullScreen_Click);
            // 
            // lb_SaveScreen
            // 
            this.lb_SaveScreen.AutoSize = true;
            this.lb_SaveScreen.Location = new System.Drawing.Point(3, 59);
            this.lb_SaveScreen.Name = "lb_SaveScreen";
            this.lb_SaveScreen.Size = new System.Drawing.Size(41, 12);
            this.lb_SaveScreen.TabIndex = 1;
            this.lb_SaveScreen.Text = "label7";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(454, 275);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "LinqToXml";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "按对象生成XML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.lblResult);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.textBox1);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.radioButtonGoogle);
            this.tabPage6.Controls.Add(this.radioButtonYouDao);
            this.tabPage6.Controls.Add(this.radioButtonBaiDu);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.btnTrans);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(454, 275);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "翻译";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(257, 89);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(29, 12);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "输出";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "翻译内容";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 136);
            this.textBox1.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "请选择翻译工具";
            // 
            // radioButtonGoogle
            // 
            this.radioButtonGoogle.AutoSize = true;
            this.radioButtonGoogle.Location = new System.Drawing.Point(299, 46);
            this.radioButtonGoogle.Name = "radioButtonGoogle";
            this.radioButtonGoogle.Size = new System.Drawing.Size(47, 16);
            this.radioButtonGoogle.TabIndex = 4;
            this.radioButtonGoogle.TabStop = true;
            this.radioButtonGoogle.Text = "谷歌";
            this.radioButtonGoogle.UseVisualStyleBackColor = true;
            // 
            // radioButtonYouDao
            // 
            this.radioButtonYouDao.AutoSize = true;
            this.radioButtonYouDao.Location = new System.Drawing.Point(151, 46);
            this.radioButtonYouDao.Name = "radioButtonYouDao";
            this.radioButtonYouDao.Size = new System.Drawing.Size(47, 16);
            this.radioButtonYouDao.TabIndex = 3;
            this.radioButtonYouDao.TabStop = true;
            this.radioButtonYouDao.Text = "有道";
            this.radioButtonYouDao.UseVisualStyleBackColor = true;
            // 
            // radioButtonBaiDu
            // 
            this.radioButtonBaiDu.AutoSize = true;
            this.radioButtonBaiDu.Location = new System.Drawing.Point(15, 46);
            this.radioButtonBaiDu.Name = "radioButtonBaiDu";
            this.radioButtonBaiDu.Size = new System.Drawing.Size(47, 16);
            this.radioButtonBaiDu.TabIndex = 2;
            this.radioButtonBaiDu.TabStop = true;
            this.radioButtonBaiDu.Text = "百度";
            this.radioButtonBaiDu.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "暂未开放使用";
            // 
            // btnTrans
            // 
            this.btnTrans.Location = new System.Drawing.Point(157, 228);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(75, 23);
            this.btnTrans.TabIndex = 0;
            this.btnTrans.Text = "翻译";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(333, 338);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(41, 12);
            this.lbl_time.TabIndex = 10;
            this.lbl_time.Text = "label7";
            // 
            // timer_Time
            // 
            this.timer_Time.Enabled = true;
            this.timer_Time.Tick += new System.EventHandler(this.timer_Time_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.功能介绍ToolStripMenuItem,
            this.开发者ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 功能介绍ToolStripMenuItem
            // 
            this.功能介绍ToolStripMenuItem.Name = "功能介绍ToolStripMenuItem";
            this.功能介绍ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.功能介绍ToolStripMenuItem.Text = "功能介绍";
            this.功能介绍ToolStripMenuItem.Click += new System.EventHandler(this.功能介绍ToolStripMenuItem_Click);
            // 
            // 开发者ToolStripMenuItem
            // 
            this.开发者ToolStripMenuItem.Name = "开发者ToolStripMenuItem";
            this.开发者ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.开发者ToolStripMenuItem.Text = "开发者";
            this.开发者ToolStripMenuItem.Click += new System.EventHandler(this.开发者ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 354);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "工具箱";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KD)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_covert;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_jiemi;
        private System.Windows.Forms.Button btn_jiami;
        private System.Windows.Forms.Label PPTSaveUrl;
        private System.Windows.Forms.Button btn_saveUrl;
        private System.Windows.Forms.Label lb_saveUrl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_CheckKD;
        private System.Windows.Forms.Label lb_KDN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBx_ShipperCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_KD;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer_Time;
        private System.Windows.Forms.Button btn_SaveScreen;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lb_SaveScreen;
        private System.Windows.Forms.Button btn_ChooseScreen;
        private System.Windows.Forms.Button btn_FullScreen;
        private System.Windows.Forms.ComboBox cBx_DanHao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 功能介绍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开发者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButtonGoogle;
        private System.Windows.Forms.RadioButton radioButtonYouDao;
        private System.Windows.Forms.RadioButton radioButtonBaiDu;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

