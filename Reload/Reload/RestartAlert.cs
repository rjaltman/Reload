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
    public partial class RestartAlert : Form
    {
        public RestartAlert()
        {
            InitializeComponent();
        }

        private void aCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
