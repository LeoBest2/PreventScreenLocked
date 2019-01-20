using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace PreventScreenLocked
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        static extern uint SetThreadExecutionState(ExecutionFlag flags);
        [Flags]
        enum ExecutionFlag : uint
        {
            System = 0x00000001,
            Display = 0x00000002,
            Continus = 0x80000000,
        }
        //private Thread thread;
        //bool isStarted = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void PreventLock()
        {
            SetThreadExecutionState(ExecutionFlag.System | ExecutionFlag.Display | ExecutionFlag.Continus);
        }

        private void ResumeLock()
        {
            SetThreadExecutionState(ExecutionFlag.System | ExecutionFlag.Continus);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void do_Start()
        {
            //isStarted = true;
            PreventLock();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            this.BtnStartMenu.Enabled = false;
            this.BtnStopMenu.Enabled = true;
        }

        private void do_Stop()
        {
            //isStarted = false;
            ResumeLock();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            this.BtnStartMenu.Enabled = true;
            this.BtnStopMenu.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            do_Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            do_Start();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(3, "防止自动锁屏", "程序最小化到任务栏,右键查看菜单,双击显示主界面!", ToolTipIcon.Info);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
                this.ShowInTaskbar = true;
            }
        }

        private void 显示主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
            this.ShowInTaskbar = true;
        }

        private void 启动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            do_Start();
        }

        private void 停止ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            do_Stop();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Visible = false;
            System.Environment.Exit(0);
        }
    }
}
