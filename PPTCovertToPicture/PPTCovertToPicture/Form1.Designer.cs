﻿namespace PPTCovertToPicture
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_covert = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.label4 = new System.Windows.Forms.Label();
            this.btn_CheckKD = new System.Windows.Forms.Button();
            this.tBx_DanHao = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tBx_ShowKD = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.panel1.Controls.Add(this.PPTSaveUrl);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_covert);
            this.panel1.Controls.Add(this.btn_open);
            this.panel1.Location = new System.Drawing.Point(13, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 168);
            this.panel1.TabIndex = 6;
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
            this.tabControl1.Location = new System.Drawing.Point(12, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(412, 280);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(404, 254);
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
            this.tabPage2.Size = new System.Drawing.Size(404, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "文本文档加密解密";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tBx_ShowKD);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btn_CheckKD);
            this.tabPage3.Controls.Add(this.tBx_DanHao);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(404, 254);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "快递服务";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "请输入运单号";
            // 
            // btn_CheckKD
            // 
            this.btn_CheckKD.Location = new System.Drawing.Point(264, 41);
            this.btn_CheckKD.Name = "btn_CheckKD";
            this.btn_CheckKD.Size = new System.Drawing.Size(75, 23);
            this.btn_CheckKD.TabIndex = 1;
            this.btn_CheckKD.Text = "查询";
            this.btn_CheckKD.UseVisualStyleBackColor = true;
            this.btn_CheckKD.Click += new System.EventHandler(this.btn_CheckKD_Click);
            // 
            // tBx_DanHao
            // 
            this.tBx_DanHao.Location = new System.Drawing.Point(23, 41);
            this.tBx_DanHao.Name = "tBx_DanHao";
            this.tBx_DanHao.Size = new System.Drawing.Size(189, 21);
            this.tBx_DanHao.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(404, 254);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "开发中...";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tBx_ShowKD
            // 
            this.tBx_ShowKD.Location = new System.Drawing.Point(23, 106);
            this.tBx_ShowKD.Multiline = true;
            this.tBx_ShowKD.Name = "tBx_ShowKD";
            this.tBx_ShowKD.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tBx_ShowKD.Size = new System.Drawing.Size(238, 145);
            this.tBx_ShowKD.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 347);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "愈来愈好制作QQ375275672";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox tBx_DanHao;
        private System.Windows.Forms.TextBox tBx_ShowKD;
    }
}

