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
    public partial class FirstRun : Form
    {
        public FirstRun()
        {
            InitializeComponent();
        }

        private void woahThere_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            submitAndStart.Visible = true;
            setAdminText.Visible = true;
            passcodeToSet.Visible = true;
            postPasscodeStatement.Visible = true;
            heyThere.Visible = false;
            descripText.Visible = false;
            submit.Visible = false;

        }

        private void FirstRun_Load(object sender, EventArgs e)
        {
            /*if (Properties.Settings.Default.uhOhItsThatDogeAgain != "")
            {
                Form1 moveAlong = new Form1();
                moveAlong.Show();
                moveAlong.BringToFront();
                this.Hide();
            }

            this.Hide();
            this.Visible = false;*/

        }

        private void submitAndStart_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.uhOhItsThatDogeAgain = passcodeToSet.Text;
            Properties.Settings.Default.Save();
            RestartAlert real = new RestartAlert();
            real.Show();
            real.BringToFront();
            this.Hide();
        }
    }
}
