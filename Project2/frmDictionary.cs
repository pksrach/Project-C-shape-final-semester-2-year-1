using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class frmDictionary : Form
    {
        string[,] Word;
        int WordNo = 0;
        public frmDictionary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Visible = false;
        }

        private void frmDictionary_Load(object sender, EventArgs e)
        {
            //add Word into List Box first!           
            lstWord.Items.Add("Apple"); lstWord.Items.Add("Abacus"); lstWord.Items.Add("Apply"); lstWord.Items.Add("Air");
            lstWord.Items.Add("Boy"); lstWord.Items.Add("Baby"); lstWord.Items.Add("Bad"); lstWord.Items.Add("Busy");
            lstWord.Items.Add("Cat"); lstWord.Items.Add("Car"); lstWord.Items.Add("Call"); lstWord.Items.Add("Can");
            lstWord.Items.Add("Date"); lstWord.Items.Add("Day"); lstWord.Items.Add("Daughter"); lstWord.Items.Add("Daily");
            lstWord.Items.Add("Electronic"); lstWord.Items.Add("End"); lstWord.Items.Add("Eat"); lstWord.Items.Add("Ear");

            //Get Number of Word in List Box
            WordNo = lstWord.Items.Count;

            //Create element array of WordNo
            Word = new string[WordNo, 3];

            //Warning: All elements array must be orderly with List Box

            //Scan Word from list box into First element array
            for (int i = 0; i <= WordNo - 1; i++)
            {
                Word[i, 0] = lstWord.Items[i].ToString();
            }

            //Add Type of Word into Second element array
            Word[0, 1] = "(n)"; Word[1, 1] = "(n)"; Word[2, 1] = "(v)"; Word[3, 1] = "(n)";
            Word[4, 1] = "(n)"; Word[5, 1] = "(n)"; Word[6, 1] = "(adj)"; Word[7, 1] = "(n)";
            Word[8, 1] = "(n)"; Word[9, 1] = "(n)"; Word[10, 1] = "(v)"; Word[11, 1] = "(v)";
            Word[12, 1] = "(n)"; Word[13, 1] = "(n)"; Word[14, 1] = "(n)"; Word[15, 1] = "(n)";
            Word[16, 1] = "(n)"; Word[17, 1] = "(n)"; Word[18, 1] = "(v)"; Word[19, 1] = "(n)";

            //Add Khmer into Third element array
            Word[0, 2] = "ផ្លែប៉ោម (n) ក្រុមហ៊ុន Apple"; Word[1, 2] = "ក្បាច់គិតលេខ"; Word[2, 2] = "ដាក់ពាក្យ"; Word[3, 2] = "ខ្យល់";
            Word[4, 2] = "ក្មេងប្រុស"; Word[5, 2] = "កូនង៉ែត"; Word[6, 2] = "អាក្រក់"; Word[7, 2] = "រវល់";
            Word[8, 2] = "ឆ្មា"; Word[9, 2] = "រថយន្ត"; Word[10, 2] = "ហៅ"; Word[11, 2] = "អាច";
            Word[12, 2] = "កាលបរិច្ឆេទ"; Word[13, 2] = "ថ្ងៃ"; Word[14, 2] = "កូនស្រី"; Word[15, 2] = "រាល់ថ្ងៃ";
            Word[16, 2] = "អេឡិចត្រូនិច"; Word[17, 2] = "ចប់"; Word[18, 2] = "ញាំ"; Word[19, 2] = "ត្រចៀក";
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //Search Word in List Box
            int ind = 0;
            foreach (string str in lstWord.Items)
            {
                if (str.StartsWith(txtSearch.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    lstWord.SelectedIndex = ind;
                    lstWord.TopIndex = ind;
                    //string text = listBox1.GetItemText(listBox1.SelectedItem);
                    return;

                }
                ind += 1;
            }
        }

        private void lstWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Search Word in element array and Translate
            txtWordMean.Text = "";
            for (int i = 0; i <= WordNo - 1; i++)
            {
                if (Word[i, 0] == lstWord.Text)
                {
                    txtWordMean.AppendText(Word[i, 0].ToString());

                    txtWordMean.SelectionColor = Color.Blue;
                    txtWordMean.AppendText(" " + Word[i, 1].ToString());

                    txtWordMean.SelectionColor = Color.Red;
                    txtWordMean.AppendText(" " + Word[i, 2].ToString());

                    return;
                }
            }
        }


        private void lbBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Visible = false;
        }

        private void lbBack_MouseEnter(object sender, EventArgs e)
        {
            lbBack.ForeColor = Color.Red;
        }

        private void lbBack_MouseDown(object sender, MouseEventArgs e)
        {
            lbBack.ForeColor = Color.DarkRed;
        }

        private void lbBack_MouseLeave(object sender, EventArgs e)
        {
            lbBack.ForeColor = Color.Black;
        }
    }
}
