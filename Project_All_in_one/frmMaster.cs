using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_All_in_one
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
            lbPredicPhone.ForeColor = Color.Gray;
        }

        private void lbPhone_MouseLeave(object sender, EventArgs e)
        {
            lbPredicPhone.ForeColor = Color.Black;
        }

        private void lbPhone_MouseDown(object sender, MouseEventArgs e)
        {
            lbPredicPhone.ForeColor = Color.GhostWhite;
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

        private void frmMaster_Load(object sender, EventArgs e)
        {

        }

        private void lbPredicName_Click(object sender, EventArgs e)
        {
            frmPredictName frm = new frmPredictName();
            frm.ShowDialog();
        }

        private void lbPredicName_MouseEnter(object sender, EventArgs e)
        {
            lbPredicName.ForeColor = Color.Gray;
        }

        private void lbPredicName_MouseDown(object sender, MouseEventArgs e)
        {
            lbPredicName.ForeColor = Color.GhostWhite;
        }

        private void lbPredicName_MouseLeave(object sender, EventArgs e)
        {
            lbPredicName.ForeColor = Color.Black;
        }

        private void lbDictionary_MouseEnter(object sender, EventArgs e)
        {
            lbDictionary.ForeColor = Color.Gray;
        }

        private void lbDictionary_MouseDown(object sender, MouseEventArgs e)
        {
            lbDictionary.ForeColor = Color.GhostWhite;
        }

        private void lbDictionary_MouseLeave(object sender, EventArgs e)
        {
            lbDictionary.ForeColor = Color.Black;
        }

        private void lbDictionary_Click(object sender, EventArgs e)
        {
            frmDictionary frm = new frmDictionary();
            frm.ShowDialog();
        }

        private void lbAboutUs_MouseEnter(object sender, EventArgs e)
        {
            lbAboutUs.ForeColor = Color.Gray;
        }

        private void lbAboutUs_MouseDown(object sender, MouseEventArgs e)
        {
            lbAboutUs.ForeColor = Color.GhostWhite;
        }

        private void lbAboutUs_MouseLeave(object sender, EventArgs e)
        {
            lbAboutUs.ForeColor = Color.Black;
        }

        private void lbAboutUs_Click(object sender, EventArgs e)
        {
            frmAboutUs frm = new frmAboutUs();
            frm.ShowDialog();
        }
    }//
}//
