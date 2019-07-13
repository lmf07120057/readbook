namespace Read.Book
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rtx_book = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_resume = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.trackbar_rate = new System.Windows.Forms.TrackBar();
            this.lbl_rate2 = new System.Windows.Forms.Label();
            this.lbl_volume2 = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.lbl_rate = new System.Windows.Forms.Label();
            this.trackbar_volume = new System.Windows.Forms.TrackBar();
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出语音EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于读书AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_volume)).BeginInit();
            this.menuStrip_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtx_book
            // 
            this.rtx_book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtx_book.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtx_book.Location = new System.Drawing.Point(0, 0);
            this.rtx_book.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.rtx_book.Name = "rtx_book";
            this.rtx_book.Size = new System.Drawing.Size(980, 467);
            this.rtx_book.TabIndex = 0;
            this.rtx_book.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtx_book);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_resume);
            this.splitContainer1.Panel2.Controls.Add(this.btn_stop);
            this.splitContainer1.Panel2.Controls.Add(this.btn_pause);
            this.splitContainer1.Panel2.Controls.Add(this.btn_start);
            this.splitContainer1.Panel2.Controls.Add(this.trackbar_rate);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_rate2);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_volume2);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_volume);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_rate);
            this.splitContainer1.Panel2.Controls.Add(this.trackbar_volume);
            this.splitContainer1.Size = new System.Drawing.Size(980, 578);
            this.splitContainer1.SplitterDistance = 467;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // btn_resume
            // 
            this.btn_resume.Location = new System.Drawing.Point(748, 29);
            this.btn_resume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(104, 46);
            this.btn_resume.TabIndex = 4;
            this.btn_resume.Text = "恢复";
            this.btn_resume.UseVisualStyleBackColor = true;
            this.btn_resume.Click += new System.EventHandler(this.btn_resume_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(859, 29);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(104, 46);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "停止";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(637, 29);
            this.btn_pause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(104, 46);
            this.btn_pause.TabIndex = 4;
            this.btn_pause.Text = "暂停";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(527, 29);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(104, 46);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // trackbar_rate
            // 
            this.trackbar_rate.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.trackbar_rate.LargeChange = 1;
            this.trackbar_rate.Location = new System.Drawing.Point(385, 24);
            this.trackbar_rate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackbar_rate.Minimum = -10;
            this.trackbar_rate.Name = "trackbar_rate";
            this.trackbar_rate.Size = new System.Drawing.Size(135, 56);
            this.trackbar_rate.TabIndex = 1;
            this.trackbar_rate.TickFrequency = 2;
            this.trackbar_rate.Scroll += new System.EventHandler(this.trackbar_rate_Scroll);
            // 
            // lbl_rate2
            // 
            this.lbl_rate2.AutoSize = true;
            this.lbl_rate2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_rate2.Location = new System.Drawing.Point(351, 41);
            this.lbl_rate2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rate2.Name = "lbl_rate2";
            this.lbl_rate2.Size = new System.Drawing.Size(21, 24);
            this.lbl_rate2.TabIndex = 0;
            this.lbl_rate2.Text = "0";
            // 
            // lbl_volume2
            // 
            this.lbl_volume2.AutoSize = true;
            this.lbl_volume2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_volume2.Location = new System.Drawing.Point(8, 41);
            this.lbl_volume2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_volume2.Name = "lbl_volume2";
            this.lbl_volume2.Size = new System.Drawing.Size(32, 24);
            this.lbl_volume2.TabIndex = 0;
            this.lbl_volume2.Text = "80";
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Location = new System.Drawing.Point(11, 26);
            this.lbl_volume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(37, 15);
            this.lbl_volume.TabIndex = 0;
            this.lbl_volume.Text = "声量";
            // 
            // lbl_rate
            // 
            this.lbl_rate.AutoSize = true;
            this.lbl_rate.Location = new System.Drawing.Point(348, 26);
            this.lbl_rate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rate.Name = "lbl_rate";
            this.lbl_rate.Size = new System.Drawing.Size(37, 15);
            this.lbl_rate.TabIndex = 1;
            this.lbl_rate.Text = "语速";
            // 
            // trackbar_volume
            // 
            this.trackbar_volume.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.trackbar_volume.Location = new System.Drawing.Point(49, 24);
            this.trackbar_volume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackbar_volume.Maximum = 100;
            this.trackbar_volume.Name = "trackbar_volume";
            this.trackbar_volume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackbar_volume.Size = new System.Drawing.Size(284, 56);
            this.trackbar_volume.TabIndex = 2;
            this.trackbar_volume.TickFrequency = 10;
            this.trackbar_volume.Value = 80;
            this.trackbar_volume.Scroll += new System.EventHandler(this.trackbar_volume_Scroll);
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.设置SToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip_main.Size = new System.Drawing.Size(980, 28);
            this.menuStrip_main.TabIndex = 2;
            this.menuStrip_main.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开OToolStripMenuItem,
            this.导出语音EToolStripMenuItem,
            this.清除CToolStripMenuItem,
            this.退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.打开OToolStripMenuItem.Text = "打开(&O)";
            this.打开OToolStripMenuItem.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            // 
            // 导出语音EToolStripMenuItem
            // 
            this.导出语音EToolStripMenuItem.Name = "导出语音EToolStripMenuItem";
            this.导出语音EToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.导出语音EToolStripMenuItem.Text = "导出语音(&E)";
            this.导出语音EToolStripMenuItem.Click += new System.EventHandler(this.导出语音EToolStripMenuItem_Click);
            // 
            // 清除CToolStripMenuItem
            // 
            this.清除CToolStripMenuItem.Name = "清除CToolStripMenuItem";
            this.清除CToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.清除CToolStripMenuItem.Text = "清除(&C)";
            this.清除CToolStripMenuItem.Click += new System.EventHandler(this.清除CToolStripMenuItem_Click);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // 设置SToolStripMenuItem
            // 
            this.设置SToolStripMenuItem.Name = "设置SToolStripMenuItem";
            this.设置SToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.设置SToolStripMenuItem.Text = "设置(&S)";
            this.设置SToolStripMenuItem.Click += new System.EventHandler(this.设置SToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于读书AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            
            // 
            // 关于读书AToolStripMenuItem
            // 
            this.关于读书AToolStripMenuItem.Name = "关于读书AToolStripMenuItem";
            this.关于读书AToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.关于读书AToolStripMenuItem.Text = "关于读书(&A)";
            this.关于读书AToolStripMenuItem.Click += new System.EventHandler(this.关于读书AToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 606);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "读书";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_volume)).EndInit();
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtx_book;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Label lbl_rate;
        private System.Windows.Forms.TrackBar trackbar_volume;
        private System.Windows.Forms.TrackBar trackbar_rate;
        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于读书AToolStripMenuItem;
        private System.Windows.Forms.Button btn_resume;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ToolStripMenuItem 导出语音EToolStripMenuItem;
        private System.Windows.Forms.Label lbl_volume2;
        private System.Windows.Forms.Label lbl_rate2;
    }
}

