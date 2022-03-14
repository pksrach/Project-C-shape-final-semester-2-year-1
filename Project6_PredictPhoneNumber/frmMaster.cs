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
    public partial class frmMaster : Form
    {
        public frmMaster()
        {
            InitializeComponent();
        }

        private void lbPhone_Click(object sender, EventArgs e)
        {
            frmPhone frm = new frmPhone();
            frm.ShowDialog();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            DialogResult click = MessageBox.Show("តើអ្នកពិតជាចង់ បិទកម្មវិធីពិតមែនទេ ?", "បិទកម្មវិធី", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (click == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lbPhone_MouseEnter(object sender, EventArgs e)
        {
            lbPhone.ForeColor = Color.Gray;
        }

        private void lbPhone_MouseLeave(object sender, EventArgs e)
        {
            lbPhone.ForeColor = Color.Black;
        }

        private void lbPhone_MouseDown(object sender, MouseEventArgs e)
        {
            lbPhone.ForeColor = Color.GhostWhite;
        }

        private void lbExit_MouseEnter(object sender, EventArgs e)
        {
            lbExit.ForeColor = Color.Red;
        }

        private void lbExit_MouseLeave(object sender, EventArgs e)
        {
            lbExit.ForeColor = Color.Black;
        }

        private void lbExit_MouseDown(object sender, MouseEventArgs e)
        {
            lbExit.ForeColor = Color.DarkRed;
        }
    }//
}//
