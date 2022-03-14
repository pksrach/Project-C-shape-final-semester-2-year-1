using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project6_PredictPhoneNumber
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

        private void lbBack_MouseDown(object sender, MouseEventArgs e)
        {
            lbBack.ForeColor = Color.DarkRed;
        }

        private void lbBack_MouseEnter(object sender, EventArgs e)
        {
            lbBack.ForeColor = Color.Red;
        }

        private void lbBack_MouseLeave(object sender, EventArgs e)
        {
            lbBack.ForeColor = Color.White;
        }
    }
}
