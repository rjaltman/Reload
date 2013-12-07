using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Reload
{
    public partial class MeantForSillyGeeseOnly : Form
    {
        public MeantForSillyGeeseOnly()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* System.IO.File.Create("C:\\Settings.javier");
            System.IO.File.WriteAllText("C:\\Settings.javier", textBox1.Text); 

            Properties.Settings.Default.whatToRun = pathToLoad.Text;
            Properties.Settings.Default.Save();*/

        }

        private void MeantForSillyGeeseOnly_Load(object sender, EventArgs e)
        {
            nowColor.BackColor = Properties.Settings.Default.nowColor;
            pathToLoad.Text = Properties.Settings.Default.whatToRun;
            taskName.Text = Properties.Settings.Default.taskName;
            enableReloadSolo.Checked = Properties.Settings.Default.solo;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.whatToRun = pathToLoad.Text;
            Properties.Settings.Default.taskName = taskName.Text;
            Properties.Settings.Default.solo = enableReloadSolo.Checked;
            Properties.Settings.Default.Save();
            this.Close();
            
            
        }

        private void nowColor_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            if (cdlg.ShowDialog() == DialogResult.OK)
            {              
                nowColor.BackColor = cdlg.Color;
                Properties.Settings.Default.nowColor = cdlg.Color;
                
            }

        }

        private void nowColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void browseForItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlg = new OpenFileDialog();
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.whatToRun = ofdlg.FileName;
                pathToLoad.Text = ofdlg.FileName;
            }
        }

        private void animatorTimer_Tick(object sender, EventArgs e)
        {
            

        }
    }
}
