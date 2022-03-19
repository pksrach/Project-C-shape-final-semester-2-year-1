using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_All_in_one
{
    public partial class frmAboutUs : Form
    {
        public frmAboutUs()
        {
            InitializeComponent();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            frmPhone frm = new frmPhone();
            frm.Show();
            this.Hide();
        }
    }
}
