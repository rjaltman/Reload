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
    public partial class WhoAreYouWhoWhoWhoWho : Form
    {
        public WhoAreYouWhoWhoWhoWho()
        {
            InitializeComponent();
        }

        private void woahThere_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (passcodeText.Text == Properties.Settings.Default.uhOhItsThatDogeAgain)
            {
                MeantForSillyGeeseOnly wut = new MeantForSillyGeeseOnly();
                wut.Show();
                wut.BringToFront();
                this.Close();
            }
            else
            {
                notifierText.Visible = true;
                passcodeText.Text = "";
            }
        }
    }
}
