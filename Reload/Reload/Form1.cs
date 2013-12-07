using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            BackColor = Properties.Settings.Default.nowColor;
            goAhead.Text = "[click the screen anywhere to launch " + Properties.Settings.Default.taskName + "]";
            if (Properties.Settings.Default.solo)
            {
                System.Diagnostics.Process.Start("taskkill.exe", "/F /IM explorer.exe");
            }
        }

        private void Form1_Draw(object sender, PaintEventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            BackColor = Properties.Settings.Default.nowColor;
            goAhead.Text = "[click the screen anywhere to launch " + Properties.Settings.Default.taskName + "]";
            if (Properties.Settings.Default.solo)
            {
                System.Diagnostics.Process.Start("taskkill.exe", "/F /IM explorer.exe");
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.whatToRun);
        }

        private void goAhead_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.whatToRun);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WhoAreYouWhoWhoWhoWho wut = new WhoAreYouWhoWhoWhoWho();
            wut.Show();
            wut.BringToFront();
        }

        private void refreshThis_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Refresh();
            BackColor = Properties.Settings.Default.nowColor;

        }

    }
}
