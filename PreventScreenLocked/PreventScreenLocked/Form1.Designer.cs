namespace PreventScreenLocked
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnDisplayMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnStartMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnStopMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(37, 23);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(146, 23);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "防止自动锁屏";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnDisplayMenu,
            this.BtnStartMenu,
            this.BtnStopMenu,
            this.BtnExitMenu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 114);
            // 
            // BtnDisplayMenu
            // 
            this.BtnDisplayMenu.Name = "BtnDisplayMenu";
            this.BtnDisplayMenu.Size = new System.Drawing.Size(152, 22);
            this.BtnDisplayMenu.Text = "显示主界面";
            this.BtnDisplayMenu.Click += new System.EventHandler(this.显示主界面ToolStripMenuItem_Click);
            // 
            // BtnStartMenu
            // 
            this.BtnStartMenu.Name = "BtnStartMenu";
            this.BtnStartMenu.Size = new System.Drawing.Size(152, 22);
            this.BtnStartMenu.Text = "启动";
            this.BtnStartMenu.Click += new System.EventHandler(this.启动ToolStripMenuItem_Click);
            // 
            // BtnStopMenu
            // 
            this.BtnStopMenu.Name = "BtnStopMenu";
            this.BtnStopMenu.Size = new System.Drawing.Size(152, 22);
            this.BtnStopMenu.Text = "停止";
            this.BtnStopMenu.Click += new System.EventHandler(this.停止ToolStripMenuItem_Click);
            // 
            // BtnExitMenu
            // 
            this.BtnExitMenu.Name = "BtnExitMenu";
            this.BtnExitMenu.Size = new System.Drawing.Size(152, 22);
            this.BtnExitMenu.Text = "退出";
            this.BtnExitMenu.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(266, 72);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "防止自动锁屏";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BtnDisplayMenu;
        private System.Windows.Forms.ToolStripMenuItem BtnStartMenu;
        private System.Windows.Forms.ToolStripMenuItem BtnStopMenu;
        private System.Windows.Forms.ToolStripMenuItem BtnExitMenu;
    }
}

