using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_All_in_one
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
            frmMaster frm = new frmMaster();
            frm.Show();
            this.Visible = false;
        }

        private void frmDictionary_Load(object sender, EventArgs e)
        {
            //add Word into List Box first!           
            lstWord.Items.Add("Abbreviation"); lstWord.Items.Add("Ability"); lstWord.Items.Add("Abort"); lstWord.Items.Add("Above");
            lstWord.Items.Add("Back"); lstWord.Items.Add("Back Door"); lstWord.Items.Add("Back End"); lstWord.Items.Add("Back page");
            lstWord.Items.Add("Cache"); lstWord.Items.Add("Calculation"); lstWord.Items.Add("Calculator"); lstWord.Items.Add("Call");
            lstWord.Items.Add("Damaged"); lstWord.Items.Add("Dangerous"); lstWord.Items.Add("Dash"); lstWord.Items.Add("Dash Line");
            lstWord.Items.Add("Edge"); lstWord.Items.Add("Edit"); lstWord.Items.Add("Edition"); lstWord.Items.Add("Effect");
            lstWord.Items.Add("Fail"); lstWord.Items.Add("Failure"); lstWord.Items.Add("Fan"); lstWord.Items.Add("Farming");
            lstWord.Items.Add("Gadget"); lstWord.Items.Add("Gallery"); lstWord.Items.Add("Gap"); lstWord.Items.Add("Gateway");
            lstWord.Items.Add("Half"); lstWord.Items.Add("Handler"); lstWord.Items.Add("Handout"); lstWord.Items.Add("Hang Up");
            lstWord.Items.Add("ID"); lstWord.Items.Add("Idea"); lstWord.Items.Add("Icon"); lstWord.Items.Add("Idle");
            lstWord.Items.Add("Jagged"); lstWord.Items.Add("Job"); lstWord.Items.Add("Join"); lstWord.Items.Add("Jump");
            lstWord.Items.Add("KB"); lstWord.Items.Add("Keep"); lstWord.Items.Add("Keyboard"); lstWord.Items.Add("Keyword");
            lstWord.Items.Add("Label"); lstWord.Items.Add("Lag"); lstWord.Items.Add("Last"); lstWord.Items.Add("Last Name");
            lstWord.Items.Add("Machine"); lstWord.Items.Add("Machine Language"); lstWord.Items.Add("Mail"); lstWord.Items.Add("Mail Box");
            lstWord.Items.Add("Name"); lstWord.Items.Add("Namespace"); lstWord.Items.Add("Naughty"); lstWord.Items.Add("Nautilus");
            lstWord.Items.Add("Object"); lstWord.Items.Add("Occupation"); lstWord.Items.Add("Officer"); lstWord.Items.Add("OK");
            lstWord.Items.Add("Pack"); lstWord.Items.Add("Package"); lstWord.Items.Add("Packet"); lstWord.Items.Add("Page");
            lstWord.Items.Add("Quadratic"); lstWord.Items.Add("Qualified"); lstWord.Items.Add("Quality"); lstWord.Items.Add("Quantity");
            lstWord.Items.Add("Radial"); lstWord.Items.Add("Radio Button"); lstWord.Items.Add("Radix"); lstWord.Items.Add("Raise");
            lstWord.Items.Add("Safe"); lstWord.Items.Add("Safety"); lstWord.Items.Add("Salmon"); lstWord.Items.Add("Salutation");
            lstWord.Items.Add("Tab"); lstWord.Items.Add("Table"); lstWord.Items.Add("Tag"); lstWord.Items.Add("Target");
            lstWord.Items.Add("Ultrabold"); lstWord.Items.Add("Ultracondensed"); lstWord.Items.Add("Ultraexpanded"); lstWord.Items.Add("Ultralight");
            lstWord.Items.Add("Valid"); lstWord.Items.Add("Validate"); lstWord.Items.Add("Validation"); lstWord.Items.Add("Validity");
            lstWord.Items.Add("Warn"); lstWord.Items.Add("Warning"); lstWord.Items.Add("Watch"); lstWord.Items.Add("Watchlist");
            lstWord.Items.Add("Yahoo messenger"); lstWord.Items.Add("Yell"); lstWord.Items.Add("Yell"); lstWord.Items.Add("Yellow");
            lstWord.Items.Add("Zone"); lstWord.Items.Add("Zoom"); lstWord.Items.Add("Zoom In"); lstWord.Items.Add("Zoom Out");

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
            Word[0, 1] = "(n)"; Word[1, 1] = "(n)"; Word[2, 1] = "(tv)"; Word[3, 1] = "(prep/a)";
            Word[4, 1] = "(iv)"; Word[5, 1] = "(n)"; Word[6, 1] = "(n)"; Word[7, 1] = "(n)";
            Word[8, 1] = "(n)"; Word[9, 1] = "(n)"; Word[10, 1] = "(n)"; Word[11, 1] = "(tv)";
            Word[12, 1] = "(adj)"; Word[13, 1] = "(adj)"; Word[14, 1] = "(n)"; Word[15, 1] = "(n)";
            Word[16, 1] = "(n)"; Word[17, 1] = "(n)"; Word[18, 1] = "(n)"; Word[19, 1] = "(n)";
            Word[20, 1] = "(tv)"; Word[21, 1] = "(n)"; Word[22, 1] = "(n)"; Word[23, 1] = "(n)";
            Word[24, 1] = "(n)"; Word[25, 1] = "(n)"; Word[26, 1] = "(n)"; Word[27, 1] = "(n)";
            Word[28, 1] = "(adj)"; Word[29, 1] = "(n)"; Word[30, 1] = "(n)"; Word[31, 1] = "(tv)";
            Word[32, 1] = "(n)"; Word[33, 1] = "(n)"; Word[34, 1] = "(n)"; Word[35, 1] = "(n)";
            Word[36, 1] = "(adj)"; Word[37, 1] = "(n)"; Word[38, 1] = "(tv)"; Word[39, 1] = "(iv)";
            Word[40, 1] = "(n)"; Word[41, 1] = "(tv)"; Word[42, 1] = "(n)"; Word[43, 1] = "(n)";
            Word[44, 1] = "(n)"; Word[45, 1] = "(n)"; Word[46, 1] = "(adj)"; Word[47, 1] = "(n)";
            Word[48, 1] = "(n)"; Word[49, 1] = "(n)"; Word[50, 1] = "(n)"; Word[51, 1] = "(n)";
            Word[52, 1] = "(n)"; Word[53, 1] = "(n)"; Word[54, 1] = "(adj)"; Word[55, 1] = "(n)";
            Word[56, 1] = "(n)"; Word[57, 1] = "(n)"; Word[58, 1] = "(n)"; Word[59, 1] = "(n)";
            Word[60, 1] = "(tv)"; Word[61, 1] = "(n)"; Word[62, 1] = "(n)"; Word[63, 1] = "(n)";
            Word[64, 1] = "(adj)"; Word[65, 1] = "(adj)"; Word[66, 1] = "(n)"; Word[67, 1] = "(n)";
            Word[68, 1] = "(adj)"; Word[69, 1] = "(n)"; Word[70, 1] = "(n)"; Word[71, 1] = "(tv)";
            Word[72, 1] = "(adj)"; Word[73, 1] = "(n)"; Word[74, 1] = "(n)"; Word[75, 1] = "(n)";
            Word[76, 1] = "(n)"; Word[77, 1] = "(n)"; Word[78, 1] = "(n)"; Word[79, 1] = "(n)";
            Word[80, 1] = "(n)"; Word[81, 1] = "(n)"; Word[82, 1] = "(n)"; Word[83, 1] = "(n)";
            Word[84, 1] = "(adj)"; Word[85, 1] = "(tv)"; Word[86, 1] = "(n)"; Word[87, 1] = "(n)";
            Word[88, 1] = "(tv)"; Word[89, 1] = "(n)"; Word[90, 1] = "(tv)"; Word[91, 1] = "(n)";
            Word[92, 1] = "(n)"; Word[93, 1] = "(n)"; Word[94, 1] = "(iv)"; Word[95, 1] = "(n)";
            Word[96, 1] = "(n)"; Word[97, 1] = "(tv)"; Word[98, 1] = "(tv)"; Word[99, 1] = "(tv)";

            //Add Khmer into Third element array
            Word[0, 2] = "បំព្រួញ(ការ)"; Word[1, 2] = "លទ្ធភាព"; Word[2, 2] = "របូតចេញ"; Word[3, 2] = "ខាងលើ";
            Word[4, 2] = "ថយក្រោយ"; Word[5, 2] = "ទ្វារក្រោយ"; Word[6, 2] = "កម្មវិធីខាងក្រោយ"; Word[7, 2] = "ទំព័រផ្នែកខាងក្រោយ";
            Word[8, 2] = "សតិភ្ជាប់(ក្នុងឈីប)"; Word[9, 2] = "គណនា"; Word[10, 2] = "ឧបករណ៍គិតលេខ"; Word[11, 2] = "ហៅ";
            Word[12, 2] = "ខូចខាត"; Word[13, 2] = "គ្រោះថ្នាក់"; Word[14, 2] = "ដាច់ៗ"; Word[15, 2] = "បន្ទាត់ដាច់ៗ";
            Word[16, 2] = "ជាយ"; Word[17, 2] = "កំណែប្រែ"; Word[18, 2] = "ការបោះពុម្ភផ្សាយ"; Word[19, 2] = "ហេតុផល,ប្រសិទ្ធិភាព";
            Word[20, 2] = "បរាជ័យ"; Word[21, 2] = "បរាជ័យ(ភាព)"; Word[22, 2] = "អ្នកចូលចិត្ត"; Word[23, 2] = "របរកសិកម្ម";
            Word[24, 2] = "គ្រឿងសន្សំ"; Word[25, 2] = "ទីតាំងពិពណ៌"; Word[26, 2] = "គំលាត"; Word[27, 2] = "ច្រកចេញចូល";
            Word[28, 2] = "ពាក់កណ្ដាល"; Word[29, 2] = "អ្នកដោះស្រាយ"; Word[30, 2] = "ប្លង់បោះពុម្ភ"; Word[31, 2] = "ព្យួរ";
            Word[32, 2] = "សញ្ញាផ្ទាល់ខ្លួន"; Word[33, 2] = "មតិ"; Word[34, 2] = "រូបសញ្ញា"; Word[35, 2] = "ខ្ជិល";
            Word[36, 2] = "រឆេតរឆូត"; Word[37, 2] = "ការងារ"; Word[38, 2] = "ចូលរួម"; Word[39, 2] = "លោត";
            Word[40, 2] = "គីឡូបៃ"; Word[41, 2] = "ថែរក្សា"; Word[42, 2] = "ក្តារចុច"; Word[43, 2] = "ពាក្យគន្លឹះ";
            Word[44, 2] = "ស្លាក"; Word[45, 2] = "រយៈពេលខុសគ្នា"; Word[46, 2] = "ចុងក្រោយ"; Word[47, 2] = "នាមត្រកូល";
            Word[48, 2] = "ម៉ាស៊ីន"; Word[49, 2] = "ភាសាម៉ាស៊ីន"; Word[50, 2] = "សំបុត្រ"; Word[51, 2] = "ប្រអប់សំបត្រ";
            Word[52, 2] = "ឈ្មោះ"; Word[53, 2] = "វាលឈ្មោះ"; Word[54, 2] = "រពិស"; Word[55, 2] = "ខ្យងគុជ";
            Word[56, 2] = "កម្មវត្ថុ"; Word[57, 2] = "មុខរបប"; Word[58, 2] = "មន្រ្តី"; Word[59, 2] = "យល់ព្រម";
            Word[60, 2] = "ខ្ចប់"; Word[61, 2] = "កញ្ចប់អីវ៉ាន់"; Word[62, 2] = "កញ្ចប់"; Word[63, 2] = "ទំព័រ";
            Word[64, 2] = "បួនជ្រុង"; Word[65, 2] = "ដែលមានគុណភាព"; Word[66, 2] = "គុណភាព"; Word[67, 2] = "បរិមាណ";
            Word[68, 2] = "មូល"; Word[69, 2] = "ប្រអប់មូល"; Word[70, 2] = "គោល"; Word[71, 2] = "លើកឡើងលើ";
            Word[72, 2] = "ដែលសុវត្ថិភាព"; Word[73, 2] = "សុវត្ថិភាព"; Word[74, 2] = "ពណ៌ស្លាទុំ"; Word[75, 2] = "វន្ទានាការ";
            Word[76, 2] = "ផ្ទាំង"; Word[77, 2] = "តារាង"; Word[78, 2] = "ប្លាក"; Word[79, 2] = "គោលដៅ";
            Word[80, 2] = "មហាដិត"; Word[81, 2] = "មហាញឹក"; Word[82, 2] = "មហារង្វើល"; Word[83, 2] = "មហាស្រាល";
            Word[84, 2] = "ត្រឹមត្រូវ"; Word[85, 2] = "ធ្វើឱ្យមានសុពលភាព"; Word[86, 2] = "សុពលកម្ម"; Word[87, 2] = "សុពលភាព";
            Word[88, 2] = "ព្រមាន"; Word[89, 2] = "ព្រមាន,ប្រយ័ត្ន"; Word[90, 2] = "តាមដាន,មើល"; Word[91, 2] = "បញ្ជីតាមដាន";
            Word[92, 2] = "អ្នកនាំសារ"; Word[93, 2] = "សំរែក"; Word[94, 2] = "ស្រែក"; Word[95, 2] = "ពណ៌លឿង";
            Word[96, 2] = "តំបន់"; Word[97, 2] = "ពង្រីកបង្រួម"; Word[98, 2] = "មើលពង្រីក"; Word[99, 2] = "មើលបង្រួម";
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
            frmMaster frm = new frmMaster();
            frm.Show();
            this.Visible = false;
        }
    }//
}//
