using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        // Token: 0x06000003 RID: 3
        [DllImport("user32.dll")]
        private static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        // Token: 0x0600004C RID: 76
        [DllImport("user32", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        // Token: 0x0600004D RID: 77
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        // Token: 0x0600004E RID: 78


        // Token: 0x0600004F RID: 79
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowThreadProcessId(IntPtr intptr_0, out int int_0);

        // Token: 0x06000050 RID: 80
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowTextLength(IntPtr intptr_0);

        // Token: 0x06000051 RID: 81
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_0);
        public Form1()
        {
            InitializeComponent();
        }

        private void Cps_Tick(object sender, EventArgs e)
        {
            this.label2.Text = Convert.ToString(this.gunaTrackBar1.Value);
        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaCheckBox1.Checked)
            {
                gunaCheckBox3.Visible = true;
                gunaCheckBox2.Visible = true;
                button1.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                gunaTrackBar1.Visible = true;
            }
            else
            {
                gunaCheckBox3.Visible = false;
                gunaCheckBox2.Visible = false;
                button1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                gunaTrackBar1.Visible = false;
            }
        }



private void F_Load(object sender, EventArgs e)
        {

        }

        private void gunaTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Clicker_Tick(object sender, EventArgs e)
        {
            if (gunaCheckBox3.Checked)
            {

                OnlyMc.Start();
            }
            else
            {
                bool flag = Control.MouseButtons == MouseButtons.Left;
                int interval = 1000 / this.gunaTrackBar1.Value - 2;
                if (flag)
                {
                    IntPtr foregroundWindow = Form1.GetForegroundWindow();
                    Form1.PostMessage(foregroundWindow, 513u, 0, 0);
                    Form1.PostMessage(foregroundWindow, 514u, 0, 0);
                    this.Clicker.Interval = interval;
                    
                }
                OnlyMc.Stop();
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text.Contains("Toggle [ON]"))
            {
                this.Clicker.Start();
                this.button1.Text = "Toggle [OFF]";
                return;
            }
            this.Clicker.Stop();
            this.button1.Text = "Toggle [ON]";
        }

        private void gunaCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaCheckBox2.Checked)
            {
                gunaTrackBar1.Maximum = 50;

            }
            else
            {
                gunaTrackBar1.Maximum = 20;
            }
        }
        private string method_0()
        {
            string result = string.Empty;
            IntPtr foregroundWindow = Form1.GetForegroundWindow();
            int num = Form1.GetWindowTextLength(foregroundWindow) + 1;
            StringBuilder stringBuilder = new StringBuilder(num);
            if (Form1.GetWindowText(foregroundWindow, stringBuilder, num) > 0)
            {
                result = stringBuilder.ToString();
            }
            return result;
        }

        private void gunaCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void OnlyMc_Tick(object sender, EventArgs e)
        {
            if ((this.method_0().Contains("Minecraft") || this.method_0().Contains("Badlion") || this.method_0().Contains("Lunar Client") || this.method_0().Contains("Labymod") || this.method_0().Contains("OCMC") || this.method_0().Contains("Cheatbreaker") || this.method_0().Contains("J3Ultimate")))
            {
                bool flag = Control.MouseButtons == MouseButtons.Left;
                int interval = 1000 / this.gunaTrackBar1.Value - 2;
                if (flag)
                {
                    IntPtr foregroundWindow = Form1.GetForegroundWindow();
                    Form1.PostMessage(foregroundWindow, 513u, 0, 0);
                    Form1.PostMessage(foregroundWindow, 514u, 0, 0);
                    this.Clicker.Interval = interval;
 
                
            }
        }
    }
    }
}




