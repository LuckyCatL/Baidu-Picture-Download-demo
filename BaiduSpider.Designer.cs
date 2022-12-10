namespace test_3
{
    partial class BaiduSpider
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bth_selectPath = new System.Windows.Forms.Button();
            this.bth_download = new System.Windows.Forms.Button();
            this.n_page = new System.Windows.Forms.NumericUpDown();
            this.t_savePath = new System.Windows.Forms.TextBox();
            this.t_keyword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.c_height = new System.Windows.Forms.NumericUpDown();
            this.c_width = new System.Windows.Forms.NumericUpDown();
            this.c_manual = new System.Windows.Forms.CheckBox();
            this.c_type = new System.Windows.Forms.ComboBox();
            this.c_size = new System.Windows.Forms.ComboBox();
            this.c_color = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_Logs = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_page)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_width)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bth_selectPath);
            this.groupBox1.Controls.Add(this.bth_download);
            this.groupBox1.Controls.Add(this.n_page);
            this.groupBox1.Controls.Add(this.t_savePath);
            this.groupBox1.Controls.Add(this.t_keyword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本设置";
            // 
            // bth_selectPath
            // 
            this.bth_selectPath.Location = new System.Drawing.Point(546, 84);
            this.bth_selectPath.Name = "bth_selectPath";
            this.bth_selectPath.Size = new System.Drawing.Size(94, 35);
            this.bth_selectPath.TabIndex = 8;
            this.bth_selectPath.Text = "选择路径";
            this.bth_selectPath.UseVisualStyleBackColor = true;
            this.bth_selectPath.Click += new System.EventHandler(this.bth_selectPath_Click);
            // 
            // bth_download
            // 
            this.bth_download.Location = new System.Drawing.Point(546, 28);
            this.bth_download.Name = "bth_download";
            this.bth_download.Size = new System.Drawing.Size(94, 35);
            this.bth_download.TabIndex = 7;
            this.bth_download.Text = "开始下载";
            this.bth_download.UseVisualStyleBackColor = true;
            this.bth_download.Click += new System.EventHandler(this.bth_download_Click);
            // 
            // n_page
            // 
            this.n_page.Location = new System.Drawing.Point(355, 36);
            this.n_page.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_page.Name = "n_page";
            this.n_page.Size = new System.Drawing.Size(170, 25);
            this.n_page.TabIndex = 6;
            this.n_page.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // t_savePath
            // 
            this.t_savePath.Location = new System.Drawing.Point(90, 91);
            this.t_savePath.Name = "t_savePath";
            this.t_savePath.Size = new System.Drawing.Size(435, 25);
            this.t_savePath.TabIndex = 5;
            this.t_savePath.TextChanged += new System.EventHandler(this.t_savePath_TextChanged);
            // 
            // t_keyword
            // 
            this.t_keyword.Location = new System.Drawing.Point(90, 36);
            this.t_keyword.Name = "t_keyword";
            this.t_keyword.Size = new System.Drawing.Size(183, 25);
            this.t_keyword.TabIndex = 3;
            this.t_keyword.TextChanged += new System.EventHandler(this.t_keyword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "保存路径";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "页数";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "关键词";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.c_height);
            this.groupBox2.Controls.Add(this.c_width);
            this.groupBox2.Controls.Add(this.c_manual);
            this.groupBox2.Controls.Add(this.c_type);
            this.groupBox2.Controls.Add(this.c_size);
            this.groupBox2.Controls.Add(this.c_color);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(29, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "筛选设置";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // c_height
            // 
            this.c_height.Enabled = false;
            this.c_height.Location = new System.Drawing.Point(552, 104);
            this.c_height.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.c_height.Name = "c_height";
            this.c_height.Size = new System.Drawing.Size(88, 25);
            this.c_height.TabIndex = 10;
            // 
            // c_width
            // 
            this.c_width.Enabled = false;
            this.c_width.Location = new System.Drawing.Point(422, 105);
            this.c_width.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.c_width.Name = "c_width";
            this.c_width.Size = new System.Drawing.Size(84, 25);
            this.c_width.TabIndex = 9;
            this.c_width.ValueChanged += new System.EventHandler(this.c_width_ValueChanged);
            // 
            // c_manual
            // 
            this.c_manual.AutoSize = true;
            this.c_manual.Location = new System.Drawing.Point(366, 107);
            this.c_manual.Name = "c_manual";
            this.c_manual.Size = new System.Drawing.Size(18, 17);
            this.c_manual.TabIndex = 8;
            this.c_manual.UseVisualStyleBackColor = true;
            this.c_manual.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // c_type
            // 
            this.c_type.FormattingEnabled = true;
            this.c_type.Items.AddRange(new object[] {
            "全部类型",
            "头像图片",
            "面部特写",
            "卡通图",
            "简笔画",
            "动态图片",
            "静态图片"});
            this.c_type.Location = new System.Drawing.Point(495, 35);
            this.c_type.Name = "c_type";
            this.c_type.Size = new System.Drawing.Size(145, 23);
            this.c_type.TabIndex = 7;
            this.c_type.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // c_size
            // 
            this.c_size.FormattingEnabled = true;
            this.c_size.Items.AddRange(new object[] {
            "全部尺寸",
            "小型图片",
            "中型图片",
            "大型图片",
            "特大型图片"});
            this.c_size.Location = new System.Drawing.Point(140, 106);
            this.c_size.Name = "c_size";
            this.c_size.Size = new System.Drawing.Size(154, 23);
            this.c_size.TabIndex = 6;
            this.c_size.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // c_color
            // 
            this.c_color.FormattingEnabled = true;
            this.c_color.Items.AddRange(new object[] {
            "全部颜色",
            "红色",
            "黄色",
            "绿色",
            "青色",
            "蓝色",
            "紫色",
            "粉色",
            "棕色",
            "橙色",
            "黑色",
            "白色",
            "黑白"});
            this.c_color.Location = new System.Drawing.Point(140, 40);
            this.c_color.Name = "c_color";
            this.c_color.Size = new System.Drawing.Size(154, 23);
            this.c_color.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "高";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "宽";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "图片类型";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "图片尺寸";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "图片主色调";
            // 
            // t_Logs
            // 
            this.t_Logs.Location = new System.Drawing.Point(33, 409);
            this.t_Logs.Multiline = true;
            this.t_Logs.Name = "t_Logs";
            this.t_Logs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.t_Logs.Size = new System.Drawing.Size(664, 294);
            this.t_Logs.TabIndex = 2;
            this.t_Logs.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BaiduSpider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 729);
            this.Controls.Add(this.t_Logs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BaiduSpider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "百度图片下载器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BaiduSpider_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_page)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_width)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox t_Logs;
        private System.Windows.Forms.TextBox t_savePath;
        private System.Windows.Forms.TextBox t_keyword;
        private System.Windows.Forms.Button bth_selectPath;
        private System.Windows.Forms.Button bth_download;
        private System.Windows.Forms.NumericUpDown n_page;
        private System.Windows.Forms.ComboBox c_type;
        private System.Windows.Forms.ComboBox c_size;
        private System.Windows.Forms.ComboBox c_color;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown c_height;
        private System.Windows.Forms.NumericUpDown c_width;
        private System.Windows.Forms.CheckBox c_manual;
    }
}

