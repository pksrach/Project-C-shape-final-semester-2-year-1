using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Project6_PredictPhoneNumber
{
    public partial class frmPhone : Form
    {
        int result = 0, sumJ = 0;
        Hashtable hash = new Hashtable();
        public frmPhone()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txtPhone.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hash.Add(1, "អ្នកជាមនុស្សមាន អំណាចចូលចិត្តធ្វើជាមេដឹកនាំគេ ។ ប៉ុន្តែជាមនុស្ស អន្ទះសារអ៊ូរទាំច្រើន ចិត្តរាយមាយឆាប់ខឹងឆាប់បាត់ ។");
            hash.Add(2, "អ្នកជាមនុស្សឆាប់ ញាប់ញ័រ មានមន្តស្នេហ៍ ព្រោះនិយាយស្តីផ្អែមល្ហែម ចូលចិត្តធ្វើអ្វីស្ងាត់ៗម្នាក់ឯង សម្បកក្រៅមើលទៅជាមនុស្សកាចនិងម៉ឺងម៉ាត់ ប៉ុន្តែ ដឹងអីខាងក្នុងរបស់អ្នកវិញទន់ជ្រាយតែម្តង ។");
            hash.Add(3, "អ្នកជាមនុស្ស និយាយសំឡេងខ្លាំងៗឮៗជាមនុស្សខ្ជិល ។ ចំណុចល្អ របស់អ្នកគឺជាមនុស្សមានការតាំងចិត្តច្បាស់លាស់ប្រាកដប្រជា បើគិតចង់ធ្វើអ្វីមួយ ហើយ គឺត្រូវធ្វើឱ្យបានសម្រេចមិនទុកចោលកណ្តាលទីឡើយ ។");
            hash.Add(4, "អ្នកគឺជាមនុស្ស ប្រកបដោយវោហារសព្ទពូកែទ្រឹស្តីនិយាយហើយ អ្នក ស្តាប់ចូលចិត្តមិនមានអារម្មណ៍ធុញទ្រាន់ ។ ម្ល៉ោះហើយបានជាមានគេចូលចិត្ត ច្រើន និងមានមិត្តភក្តិច្រើន ប៉ុន្តែមានចរិតចូលចិត្តផ្លាស់ប្តូរដៃគូស្នេហា ។");
            hash.Add(5, "អ្នកជាមនុស្សមានហេតុផលគិតមុនធ្វើមានភាពវៃឆ្លាត មិនឆេវឆាវ ប៉ិនអាណិតគេ មិនចូលចិត្តសម្តីកុហក ។");
            hash.Add(6, "អ្នកជាមនុស្សដែលសម្បូរស្នេហ៍ ច្រើនតែចំណាយប្រាក់ទៅលើការតែង ខ្លួននិងការសប្បាយផ្សេងៗ ។");
            hash.Add(7, "អ្នកជាមនុស្សឆាប់ ភ័យ ឆាប់តក់ស្លុត ឆាប់ខ្វល់ខ្វាយ ។ ពេលណាខឹងខ្លាំង ច្រើនតែបាត់បង់ម្ចាស់ការ និយាយស្តីច្រើនតែខុស ។ ជួនកាលរឿងមិនត្រូវជា បញ្ហាសោះ ប៉ុន្តែពេលខឹងបែរជានិយាយបង្កើតបញ្ហាធំទៅវិញ ។ ដូច្នេះត្រូវ ព្យាយាមធ្វើចិត្តឱ្យត្រជាក់គិតសិនមុននឹងនិយាយ ។");
            hash.Add(8, "អ្នកជាមនុស្សឆាប់ជឿគេ ឆាប់ទុកចិត្តគេមាននិស្ស័យជាមនុស្សហ៊ានស៊ី ហ៊ានសង ។");
            hash.Add(9, "អ្នកជាមនុស្សបុរាណនិយម អភិរក្សនិយមប្រសិនបើអាយុនៅក្មេងក៏មាន ទស្សនៈបែបជាមនុស្សចាស់ដែរ ។");
            richTextBox1.ReadOnly = true;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                lbResult.Text = "";
                richTextBox1.Text = "";
            }
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPhone.Clear();
            richTextBox1.Clear();
            lbResult.Text = "";
            txtPhone.Focus();
        }

        private void lbExit_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void lbExit_MouseLeave(object sender, EventArgs e)
        {
            lbExit.ForeColor = Color.White;
        }

        private void lbExit_MouseEnter(object sender, EventArgs e)
        {
            lbExit.ForeColor = Color.Red;
        }

        private void lbExit_MouseDown(object sender, MouseEventArgs e)
        {
            lbExit.ForeColor = Color.DarkRed;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }

        private void lbResult_TextChanged(object sender, EventArgs e)
        {
            if (lbResult.Text == "")
            {
                richTextBox1.Clear();
            }
            else
            {
                int reResult = Convert.ToInt32(lbResult.Text);
                richTextBox1.Text = hash[reResult].ToString();
            }
        }

        private void lbAboutUs_MouseEnter(object sender, EventArgs e)
        {
            lbAboutUs.ForeColor = Color.Black;
        }

        private void lbAboutUs_MouseLeave(object sender, EventArgs e)
        {
            lbAboutUs.ForeColor = Color.White;
        }

        private void lbAboutUs_MouseDown(object sender, MouseEventArgs e)
        {
            lbAboutUs.ForeColor = Color.Gray;
        }

        private void lbAboutUs_Click(object sender, EventArgs e)
        {
            frmAboutUs frm = new frmAboutUs();
            frm.Show();
            this.Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.Focus();
                richTextBox1.Clear();
            }
            else
            {
                if (txtPhone.TextLength >= 9)
                {
                    string numberPhone = txtPhone.Text;
                    while (numberPhone.Length > 1)
                    {
                        char[] ch = numberPhone.ToCharArray();
                        int j = 0;
                        int sum = 0;
                        for (int i = 0; i < ch.Length; i++)
                        {
                            if (sumJ > 2)
                            {
                                sum += int.Parse(ch[i].ToString());
                            }
                            sumJ += j++;
                        }
                        numberPhone = sum.ToString();
                        result = sum;
                    }
                    lbResult.Text = Convert.ToString(result);
                    sumJ = 0;
                    result = 0;
                }
                else
                {
                    
                    sumJ = 0;
                    lbResult.Text = "";
                }
                if (result > 0)
                {
                    richTextBox1.Text = hash[result].ToString();
                }
            }
        }
    }
}
