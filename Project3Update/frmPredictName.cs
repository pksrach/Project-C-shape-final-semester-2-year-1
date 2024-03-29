﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class frmPredictName : Form
    {
        public frmPredictName()
        {
            InitializeComponent();
        }
        String fullName = "";




        void JubTi12Auto()
        {
            fullName = txtName.Text;
            char[] fullNameArr = fullName.ToCharArray();
            fullName = "";

            foreach (char ch in fullNameArr)
            {
                string str = ch.ToString().ToLower();
                if (str == "a" || str == "j" || str == "s")
                {
                    fullName = fullName + "1";
                }
                else if (str == "b" || str == "k" || str == "t")
                {
                    fullName = fullName + "2";
                }
                else if (str == "c" || str == "l" || str == "u")
                {
                    fullName = fullName + "3";
                }
                else if (str == "d" || str == "m" || str == "v")
                {
                    fullName = fullName + "4";
                }
                else if (str == "e" || str == "n" || str == "w")
                {
                    fullName = fullName + "5";
                }
                else if (str == "f" || str == "o" || str == "x")
                {
                    fullName = fullName + "6";
                }
                else if (str == "g" || str == "p" || str == "y")
                {
                    fullName = fullName + "7";
                }
                else if (str == "h" || str == "q" || str == "z")
                {
                    fullName = fullName + "8";
                }
                else if (str == "i" || str == "r")
                {
                    fullName = fullName + "9";
                }
                else
                {
                    fullName = fullName + "0";
                }
            }//foreach
            while (fullName.Length > 1)
            {
                char[] arr = fullName.ToCharArray();
                int sum = 0;
                foreach (char ch in arr)
                {
                    sum = sum + int.Parse(ch.ToString());
                }
                fullName = sum.ToString();
            }//while
            lblNumber.Text = fullName;
        }
        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (txtName.Text == "")
                {
                    lblNumber.Text = "0";
                }
                else
                    JubTi12Auto();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txtName.Text != "")
            {
                JubTi12Auto();
                //linkLabel1_LinkClicked(sender, (LinkLabelLinkClickedEventArgs)e);


            }
            else txtName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtName.Focus();
            lblNumber.Text = "0";
            txtDefinition.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string str = txtDefinition.Text;
            
            if (txtName.Text == "")
            {
                lblNumber.Text = "0";
            }
        }

        public void Justify(System.Windows.Forms.Label label)
        {
            string text = label.Text;
            string[] lines = text.Split(new[] { "\r\n" }, StringSplitOptions.None).Select(l => l.Trim()).ToArray();

            List<string> result = new List<string>();

            foreach (string line in lines)
            {
                result.Add(StretchToWidth(line, label));
            }

            label.Text = string.Join("\r\n", result);
        }
        private string StretchToWidth(string text, Label label)
        {
            if (text.Length < 2)
                return text;

            // A hair space is the smallest possible non-visible character we can insert
            const char hairspace = '\u200A';

            // If we measure just the width of the space we might get too much because of added paddings so we have to do it a bit differently
            double basewidth = TextRenderer.MeasureText(text, label.Font).Width;
            double doublewidth = TextRenderer.MeasureText(text + text, label.Font).Width;
            double doublewidthplusspace = TextRenderer.MeasureText(text + hairspace + text, label.Font).Width;
            double spacewidth = doublewidthplusspace - doublewidth;

            //The space we have to fill up with spaces is whatever is left
            double leftoverspace = label.Width - basewidth;

            //Calculate the amount of spaces we need to insert
            int approximateInserts = Math.Max(0, (int)Math.Floor(leftoverspace / spacewidth));

            //Insert spaces
            return InsertFillerChar(hairspace, text, approximateInserts);
        }

        private static string InsertFillerChar(char filler, string text, int inserts)
        {
            string result = "";
            int inserted = 0;

            for (int i = 0; i < text.Length; i++)
            {
                //Add one character of the original text
                result += text[i];

                //Only add spaces between characters, not at the end
                if (i >= text.Length - 1) continue;

                //Determine how many characters should have been inserted so far
                int shouldbeinserted = (int)(inserts * (i + 1) / (text.Length - 1.0));
                int insertnow = shouldbeinserted - inserted;
                for (int j = 0; j < insertnow; j++)
                    result += filler;
                inserted += insertnow;
            }

            return result;
        }
        private void lblNumber_TextChanged(object sender, EventArgs e)
        {
            
        }//

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblNumber.Text == "1")
            {
                
               txtDefinition.Text = "សម្បូរដោយសេចក្ដីក្លាហាន និងគំនិតផ្សងព្រេង គំនិតអារកាត់ខ្លាំងឯកច្ឆន្ទ។ ជាទូទៅច្រើនប្រកបដោយឆ្មើងឆ្មាតយ៉ាងមាំទាំ និងថាមពខាងចរិយាដ៏ធំចំពោះសត្រូវ។ ជាមនុស្សកើតមកសម្រាប់ធ្វើមេគេ ឬជាអ្នកល្បីល្បាញ ប្រសិនបើជាគ្មានកាលៈទេសៈអ្វីមកខ្ចាស់ការរីកចម្រើនខាងផ្លូវគំនិតរបស់គេទេ។";
            }
            else if (lblNumber.Text == "2")
            {
                //txtDefinition.Clear();
                txtDefinition.Text = "មានចរិតជាអ្នកឆាប់រំភើបបំផុតឆាប់ខឹង តែចូលចិត្តគោរពអ្នកដទៃ  ។ ជាអ្នកចេះស្តាប់បង្គាប់ ចូលចិត្តឱ្យគេដឹកនាំជាជាងបញ្ជាគេ ។ មនុស្សជំពូកនេះ ពេញចិត្តការរាក់ទាក់រាប់អានណាស់ ហើយតែងតែខិតខំ បំពេញបំណងជនដែលមកសុំជំនួយពីខ្លួន។";
            }
            else if (lblNumber.Text == "3")
            {
                //txtDefinition.Clear();
                txtDefinition.Text = "ជាមនុស្សពោរពេញដោយថាមពលនិងគំនិតបង្កើតស្រឡាញ់ជីវភាពតាមគ្រប់លក្ខណៈហើយអ្វីក៏អាចទាក់ចិត្តគេបានដែរ ។ ជាអ្នកសុទិដ្ឋិនិយម និងទុកចិត្តខ្លួនឯង ។ ចេះភ្លក់រសជាតិនៃការសប្បាយនៃជីវិតហើយចេះទទួលទិដ្ឋិភាពជា វិជ្ជមានក៏ដូចជាទិដ្ឋិភាពមិនសូវសប្បាយដែរ ។ រហ័សរហួនហើយឆាប់ទទួល ឥទ្ធិពលពីគេ ដូចមនុស្សឯទៀតដែរ តែក៏ឆាប់ជួបនឹងវិបត្តិផ្លូវចិត្តដែរ ។";
            }
            else if (lblNumber.Text == "4")
            {
                //txtDefinition.Clear();
                txtDefinition.Text = "ជាអ្នកធ្វើការមិនខ្លាចនឿយហត់ប្រកបដោយគំនិតម៉ឺងម៉ាត់និងប្រាកដនិយម ។ មនុស្សជំពូកលេខ៤ស្រឡាញ់វិជ្ជាជីវៈរបស់ខ្លួនណាស់ ។ ជាទូទៅ ដោយអាស្រ័យលើគុណសម្បត្តិពិសេសរបស់ខ្លួនជាអ្នករៀបចំ និង ដឹកនាំ មនុស្សនេះ ច្រើនទទួលជោគជ័យជានិច្ចក្នុងកិច្ចការ ។ គុណសម្បត្តិពិសេសរបស់មនុស្សជំពូកលេខ៤គឺមនៈសិការក្នុងវិជ្ជាជីវៈ ការទៀងទាត់និងការឱហាត ";
            }
            else if (lblNumber.Text == "5")
            {
                //txtDefinition.Clear();
                txtDefinition.Text = "មានទំនោរចិត្តជាអ្នកស្វាហាប់រហ័សរហួនប្រកបដោយ ថាមពល ។ ដោយមានគំនិតផ្សងព្រេងជានិស្ស័យមនុស្សនេះស្រឡាញ់សេរីភាពណាស់ហើយដើម្បីសេរីភាពមនុស្សនេះមិនញញើតនឹងលះបង់អ្វីៗគ្រប់យ៉ាង ។ គ្មានអ្វីដែលថាធ្វើទៅមិនកើតសម្រាប់មនុស្សនេះទេហើយការណាដែលគេថា មិនអាចធ្វើបាន មនុស្សនេះចូលចិត្តធ្វើបំផុត ។ គឺជាមនុស្សពិបាកបំផុតហើយហ៊ានប្រយុទ្ធនឹងគ្រោះថ្នាក់បំផុតដែរ ។ គេជាអ្នកសុទិដ្ឋិនិយម មានការត្រង់ត្រាប់ដែលមិនអាចបំបែកបាន គឺគុណសម្បត្តិទាំងនេះ ហើយដែលញ៉ាំងឱ្យគេ ពុះពារឧបសគ្គគ្រប់បែបយ៉ាងបានដោយងាយ ។";
            }
            else if (lblNumber.Text == "6")
            {
                //txtDefinition.Clear();
                txtDefinition.Text = "អ្នកប្រកបដោយអាត្មានថ្លៃថ្នូរហើយសុចរិត ។ គេសំគាល់មនុស្សនេះបានត្រង់មាននិស្ស័យខាងស្រឡាញ់យុត្តិធម៌និងកាតព្វកិច្ច ។ គេចូលចិត្តធ្វើល្អនឹង អ្នកដទៃតែចំពោះគ្រួសាររបស់គេវិញ គេហ៊ានលះបង់គ្រប់យ៉ាងដើម្បីផ្គត់ផ្គង់ ។ គេជាអ្នកមានមនៈសិការហើយគត់មត់ពិសេសចំពោះការណាដែលទាក់ទងផ្ទាល់ចំពោះខ្លួនគេ ។ ថ្វីបើគេជាមនុស្សប្រយ័ត្នប្រយែងមិនងាយសំដែងឱ្យឃើញការរំភើបរបស់គេក្តីក៏គេរាប់អានអ្នកផងដោយរាក់ទាក់បំផុត ";
            }
            else if (lblNumber.Text == "7")
            {
                //txtDefinition.Clear();
                txtDefinition.Text = "មាននប្រាជ្ញាឆ្លាតស្អំឆាប់យល់មិនងាយជឿរឿងអ្វីមួយៗ ដោយងាយទេ ។បើនឹងជឿលុះណាតែបានពិចារណាបានដិតដល់ណាស់ ។ គេមិនចូលចិត្តការងារណាដែលមិនស្របនឹងគំនិតប្រាជ្ញារបស់គេទេ  ។";
            }
            else if (lblNumber.Text == "8")
            {
                //txtDefinition.Clear();
                txtDefinition.Text = "មនុស្សប្រកបដោយកំលាំងខាងឆន្ទៈរកមិនបាន ហើយមានចរិតរឹងដូចដែក ។ ទុកចិត្តខ្លួនឯងណាស់ហើយបើនឹងកាន់ការអ្វីមួយហើយគឺធ្វើឱ្យទាល់តែបាន សំរេចទើបសុខចិត្ត ។ មិនចេះសំលុតគេហើយបើជួបប្រទះនឹងការពិបាកអ្វីមួយនៅពេលកំពុងចង់ សំរេចបំណងអ្វីមួយហើយមនុស្សនេះឥតចេះរាថយឬក៏ខកចិត្តទេគឺពុះពារទាល់ តែបានដល់គោលដៅ ។ ជាទូទៅគឺជាមនុស្សស្អប់ការខ្ចីខ្លាហើយចរិតនេះសោត ទៀតតែងនាំមនុស្សេះឱ្យបានជួបជួនជោគជ័យជួនធ្លាក់ទឹក ។ ប៉ុន្តែទោះជាយ៉ាងណាក៏មិនចេះរារែកដែរ ។";
            }
            else if (lblNumber.Text == "9")
            {
                //txtDefinition.Clear();
                txtDefinition.Text = "គឺជាមនុស្សប្រកបដោយភាពរំភើបដ៏ជ្រាលជ្រៅនិងមនុស្សធម៌ដ៏អស្ចារ្យ ។ជាមនុស្សចិត្តល្អណាស់ឱ្យតែមានគេមកសុំជំនួយភ្លាមគឺជួយគេដោយឥឥតគិត ផលប្រយោជន៍ទេ ។ គេជាអ្នកឧត្តមគតិនិយមផងប្រលោមនិយមផងអញ្ចឹងហើយបានជាគេជាមនុស្សចូលចិត្តមើលឃើញអ្នកដទៃល្អហើយស្មោះត្រង់ ។ គឺគេទុកចិត្តលើ មនុស្សដោយឥឥតរើសមុខ ។ ";
            }
            else
            {
                txtDefinition.Text = "";
            }
            //Justify(txtDefinition);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (lblNumber.Text == "1")
            {
                
                txtDefinition.Text = " ជាមនុស្សមានគំនិតថ្លៃថ្នូរ ហើយខ្ពង់ខ្ពស់ព្រមទាំងប្រកបដោយប្រាជ្ញាឈ្លាសវៃ ប្លែកពីគេ។ ជាអ្នកតែងធ្វើឱ្យគេចាប់អារម្មណ៍មកលើខ្លួន ហើយច្រើនកាន់កាប់ មុខងារធំដុំនៅកន្លែងធ្វើការ ។ ដោយហេតុជនជំពូកលេខ១នេះ មានបុគ្គលភាព ត្រចេះត្រចង់ជននេះក៏ក្លាយជាអ្នកមានវាសនាខាងធ្វើឱ្យមានអ្នកកោតសរសើរខ្លួនច្រើន មិត្តភកិ្តក៏ច្រើន តែសត្រូវក៏ច្រើនដែរ។";
            }
            else if (lblNumber.Text == "2")
            {
                //txtDefinition.Clear();
                txtDefinition.Text = "ខ្លួនជាអ្នករាក់ទាក់មនោសញ្ចេតនាចូលចិត្តនិយាយរឿងផ្ទាល់ខ្លួនប្រាប់គេមនុស្សជំពូកលេខ២ តែងបណ្តោយខ្លួនទៅតាមទឹកចិត្ត ជាជាងទៅតាម វិចារណញ្ញាណ នៅពេលខ្លួនក្តាប់ស្ថានការណ៍បានហើយក្តី ក៏មនុស្សជំពូក លេខ២តែងតែនៅមានការរំភើបជានិច្ចនៅពេលដែលខ្លួនជួបប្រទះនឹងការ លំបាក ។ ដោយខ្លួនមិនសូវចេះរស់ក្នុងជីវភាពសង្គមមនុស្សនេះចូលចិត្តរស់នៅ តែឯកឯងព្រោះស្អប់បរិយាកាសអាប់អួរណាស់ ។ ";
            }
            else if (lblNumber.Text == "3")
            {
                //txtDefinition.Clear();
                txtDefinition.Text = "ចូលចំណោមឆាប់ចុះរហូតដល់គេអាចនិយាយបានថាមនុស្សជំពូកលេខ៣នេះគឺជាមនុស្សងាយសម្របតាមជីវភាពក្នុងសហគមន៍បំផុត។ ជាអ្នកចេះទប់ចិត្តបានយ៉ាងត្រចះត្រចង់ហើយយ៉ាងសប្បាយទៀតរួចចេះធ្វើឱ្យអ្នកផងពេញចិត្តគ្រប់ៗគ្នា ។ អ៊ីចឹងហើយបានជាមនុស្សនេះងាយរកមិត្តភាពពី អ្នកដទៃណាស់ ។ បានជាឆាប់ទទួលការរាប់អានដូច្នេះព្រោះមនុស្សជំពូកលេខ៣មិនចូលចិត្តចោទបញ្ហាច្រើនទេព្រោះខ្លាចការរស់នៅដោយសប្បាយឆាប់បាត់បង់ទៅវិញ ដូចដែលខ្លួនងាយរកបានមក ។";
            }
            else if (lblNumber.Text == "4")
            {
                //txtDefinition.Clear();
                txtDefinition.Text = "ជាអ្នកប្រយ័ត្នប្រយែង ហើយគត់មត់ ។ មិនងាយប្រព្រឹត្តអំពើផ្តេសផ្តាសទេព្រោះជាមនុស្សមានស្មារតីម៉ីម៉ាត់ មិនចេះរវើរវាយ ។ គឺជាមិត្តភក្តិដ៏ប្រសើរខាងស្មោះត្រង់បំផុតតែមិនពូកែខាងប្រើទឹកមុខទេហើយឆាប់ខឹងណាស់ ។បើនឹងជឿលើរឿងអ្វីមួយគឺទាល់តែពិចារណាហ្មត់ចត់ណាស់តែបើទុកចិត្តហើយទោះត្រូវធ្វើអ្វីក៏ធ្វើដែរ ឱ្យតែមនុស្សដែលខ្លួនស្រឡាញ់នោះបានពេញចិត្ត ។";
            }
            else if (lblNumber.Text == "5")
            {
                //txtDefinition.Clear();
                txtDefinition.Text = "ហ៊ានអារកាត់ដោយឥតរារែក គឺគេជាមនុស្សក្នុងជំពូកអ្នកដែលហ៊ានសំរេច កិច្ចការ ដោយមិនសូវគិតច្រើន ។ គេជាអ្នកប្រកបដោយគំនិតភ្លឺស្វាង និងគួរឱ្យទាក់ចិត្តនៅក្នុងសង្គម ។ បើនិយាយឱ្យសាមញ្ញគឺស៊ីដាច់គេដាច់ឯងតែម្តង មិត្តភក្តិក៏ច្រើនអ្នកសើចសរសើរក៏ច្រើនទៀត ។ ក៏ប៉ុន្តែជនជំពូកលេខ៥ក៏ជាមនុស្សមិនចេះអត់ធ្មត់ ហើយឆាប់ខឹងផងតែគឺជាគុណវិបត្តិដែលអាចឱ្យ អធ្យាស្រ័យបានព្រោះមនុស្សនេះចេះធ្វើឱ្យគេរាប់អានណាស់ ។";
            }
            else if (lblNumber.Text == "6")
            {
                //txtDefinition.Clear();
                txtDefinition.Text = "គេមាននិស្ស័យជាអ្នកស្ងប់ស្ងៀមហើយនឹងធឹងព្រមទាំងស្លូតបូតនិងសោះ អង្គើយជាមួយនឹងអាការៈស្ងប់ស្ងៀមនិងអត់ធ្មត់ ។ មនុស្សជំពូកលេខ៦ច្រើនតែធ្វើឱ្យអ្នកផងរាប់អានណាស់តែក្នុងចំណោមជនខាងក្រោយនេះគ្មានជនណាម្នាក់ហ៊ានអះអាងថាបានស្គាល់គំនិតរបស់មនុស្សឱ្យបាន ច្បាស់លាស់ទេ ។ ការពិតបើ";
            }
            else if (lblNumber.Text == "7")
            {
                //txtDefinition.Clear();
                txtDefinition.Text = "ជាអ្នកម៉ឺងម៉ាត់ បើនឹងអារកាត់រឿងអ្វីមួយគេច្រើនតែធ្វើឡើងដោយវិចារណញ្ញាណគឺមិនមែនដោយផ្លូវចិត្តទេ ។ គេជាមិត្តភក្តិម្នាក់ចេះស្គាល់ទុក្ខធុរៈចេះយោគយល់គ្នាទៅវិញទៅមកមិនងាយប្រកាន់ខឹងតែបើបានជា ប្រកាន់ ខឹងហើយក៏មិនងាយជានាវិញដែរ ។ គេជាមនុស្សគួរឱ្យទុកចិត្តរាប់អានបានព្រោះមិនចូលចិត្តផ្តល់ទុក្ខឱ្យអ្នកដទៃ ។";
            }
            else if (lblNumber.Text == "8")
            {
                //txtDefinition.Clear();
                txtDefinition.Text = "ជាមនុស្សមានគំនិតប្រយុទ្ធហើយស្វាហាប់ហ៊ានតស៊ូយ៉ាងពេញទំហឹងដើម្បី ការពារឧត្តមគតិដែលខ្លួនជឿថាល្អ ។ មានចិត្តលោភលន់ហើយស្វិតស្វាញ ។ បើចង់សំរេចគោលបំណងអ្វីមួយហើយមនុស្សលេខ៨សុខចិត្តលះបង់គោល បំណងដទៃទៀតចោលសិន ដើម្បីធ្វើគោលបំណងនេះឱ្យទាល់តែបានសំរេច ។ អ៊ីចឹងហើយ បានជាមានអ្នកចូលចិត្តរាប់អានគេច្រើនណាស់ ។ ស្នេហា៖ ក្នុងរឿងស្នេហាមនុស្សជំពូកលេខ៨ ច្រើនប្រែប្រួលមិននឹងឬទេ ។ មានម៉ូថ្នាក់ថ្នមគូគាប់មានម៉ូទៀតបែបរៀងគេចៗហើយបែបវារី ។ ដោយហេតុមនុស្សនេះមានចរិតពិបាកបែបនេះមនុស្សជំពូកលេខ៨ ត្រូវរក គូ ស្រករណាដែលចេះយល់ខ្លួនចេះអត់ឱនចំពោះទឹកមុខប្រែប្រួលគ្មានឈប់ឈរ របស់ខ្លួន ។ ជាទូទៅគួររៀបការជាមួយមនុស្សជំពូកលេខ២ ។ការពិតភាពស្រស់ស្រាយ និងចិត្តសន្តោសរបស់មនុស្សលេខ២តែងមានជោគ ជ័យលើភាពជាអ្នកជិះជាន់របស់មនុស្សជំពូកលេខ៨ ។";
            }
            else if (lblNumber.Text == "9")
            {
                //txtDefinition.Clear();
                txtDefinition.Text = "ដោយហេតុគេមាននិស្ស័យស្រស់ស្រាយហើយចូលចំណោមចុះនោះមនុស្សជំពូកលេខ៩តែងមានមិត្តភក្តិច្រើនក៏ប៉ុន្តែគេក៏តែងឃើញមនុស្សនេះមានសត្រូវខ្លះ ដែរ ។ ជាការផ្ទុយដែលជួនកាលមនុស្សនេះមានប្រតិកម្មបែបជាអ្នកការទូតឬក៏ មិននិយាយការពិតប្រាប់គេឯង ។ មិនជាអ្នកម៉ត់ចត់ទេតែទោះជាយ៉ាងណាក៏មនុស្សនេះច្រើនតែធ្វើឱ្យគេមាន សមានចិត្តមកលើខ្លួនជានិច្ច ។";
                


            }
            else
            {
                txtDefinition.Text = "";
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblNumber.Text == "1")
            {
                txtDefinition.Text = "ជនជំពូកលេខ១មានទំនោរចិត្តជាអ្នកត្រួតត្រាហើយចូលចិត្តបញ្ជាលើមនុស្ស ដែលខ្លួនជ្រើសរើសជាគូរគាប់ណាស់។ ច្រើនមានចិត្តប្រចណ្ឌមិនព្រមឱ្យគូរគាប់ របស់ខ្លួនមានចិត្តវៀចវេរទេ។បើរៀបការជាមួយមនុស្សជំពូកលេខ២ និងលេខ៦ទើបល្អ។ មិនសូវល្អជាមួយលេខ៥ ឬលេខ៧ ព្រោះច្រើនទាស់ទែងគ្នា។ ";
            }
            else if (lblNumber.Text == "2")
            {
                txtDefinition.Text = "មនុស្សជំពូកលេខ២ច្រើនជាស្វាមីឬភរិយាគ្រប់លក្ខណ៍ ។ ការពិតមនុស្សជំពូក នេះដោយអាស្រ័យលើទឹកចិត្តសណ្តោសនិងមនោសញ្ចេតនារបស់ខ្លួនតែងប្រឹង ប្រែងផ្តល់ឱ្យគូគាប់របស់ខ្លួននូវសុខុមាលភាពនិងសុភមង្គល។ មានពេលខ្លះទោះ ជានៅចំពោះមុខសីលធម៌ឬក៏ប្រាកដនិយមដែលជាការចាំបាច់សម្រាប់ការរស់នៅក្តីក៏មនុស្សជំពូកនេះ មិនចោលភាពអណ្តែតអណ្តូងរបស់ខ្លួនដែរ ។ បើរៀបការជាមួយមនុស្សជំពូកលេខ៤ និងលេខ៦ទើបល្អ ។ តែជាមួយលេខ៨ និងលេខ៩ ក៏ល្អដែរ ព្រោះមានលក្ខណៈប្រហែលគ្នា ។";
            }
            else if (lblNumber.Text == "3")
            {
                txtDefinition.Text = "ថ្វីបើមនុស្សជំពូកលេខ៣ជាអ្នកមានទឹកចិត្ដទោរទន់ក៏ដោយក៏នៅមុនពេលរកគូស្រករមនុស្សនេះចូលចិត្តធ្វើពិសោធន៍ចិត្តគូគាប់របស់ខ្លួនមុនជានិច្ច ។ លុះរៀបការហើយមនុស្សនេះតែងខិតខំបំពេចិត្តគូគាប់និងកូនចៅរបស់ខ្លួនណាស់ ។ យកល្អត្រូវរៀបការនឹងមនុស្សជំពូកលេខ៣ដូចគ្នានិងលេខ៨ ។";
            }
            else if (lblNumber.Text == "4")
            {
                txtDefinition.Text = "មនុស្សជំពូកលេខ៤ មិនងាយចាប់ចិត្តស្រឡាញ់គេងាយៗទេ ហើយបើនឹងរៀបការជាមួយអ្នកណាម្នាក់វិញ ទាល់តែបានសង្កេតមើលចិត្តថ្លើមអស់ចិត្តអស់ចង់ ។ គឺជាភរិយាឬស្វាមីដ៏ប្រសើរប្រកបដោយគំនិតទទួលខុសត្រូវ និងសីលធម៌ ។ និយាយឱ្យខ្លីទៅបើលោកអ្នកចង់រកគូស្រករជាអ្នករវើរវាយហើយល្ងង់ខ្លៅសូមកុំយកមនុស្សជំពូកលេខ៤នេះឱ្យសោះ ។មនុស្សនេះ បើរៀបការជាមួយនឹង មនុស្សជំពូកលេខ៤, ៧ និង ៩ គឺប្រសើរណាស់ ព្រោះរវាងគ្នានឹងគ្នា មានភាពស្របខាងប្រាជ្ញាច្រើនណាស់។";
            }
            else if (lblNumber.Text == "5")
            {
                txtDefinition.Text = "ដោយគេជាអ្នកឆ្លាត្តក្នុងរឿងស្នេហាគេច្រើនបានទទួលជោគជ័យជានិច្ច។ គេចូលចិត្តរៀបការយ៉ាងហ៊ឹកហ៊ាក់ហើយការរស់នៅជាមួយគេច្រើនតែបានជួប ប្រទះនឹងរឿងថ្មីជានិច្ចតែរឿងថ្មីទាំងនេះមិនមែនសុទ្ធតែជារឿងសប្បាយទេ ។ គេត្រូវរៀបការជាមួយមនុស្សជំពូកលេខ៥ដូចគ្នាហើយការរួមរស់របស់គេច្រើនតែជួបនឹងរឿងថ្មី ហើយគ្រោតគ្រាតបន្តិច។";
            }
            else if (lblNumber.Text == "6")
            {
                txtDefinition.Text = "មនុស្សជំពូកលេខ៦មិនងាយដាក់ចិត្តស្រឡាញ់គេផ្តេសផ្តាសទេតែបើបានជាចាប់ចិត្តស្រឡាញ់ហើយគឺស្លាប់ទៅយកទៅផង ។ បើបានជារៀបការនឹងអ្នកណាមួយហើយមនុស្សនេះថ្នាក់ថ្នមគេគ្រប់បែបយ៉ាង ហើយមិនព្រមឱ្យគូស្រកររវើរវាយក្រៅពីខ្លួនទេ ។ គំនិតចង់បានតែម្នាក់ឯងនេះជាការមួយមិនគួរគាប់ទេប៉ុន្តែគូស្រករមិនខ្ជាក់ចិត្ត បានឡើយព្រោះគេចេះថ្នាក់ថ្នមនិងស្រស់ស្រាយបំផុត ។ បើរៀបការជាមួយ មនុស្សជំពូកលេខ៦ដូចគ្នា គឺល្អណាស់ ។ ជាមួយលេខ១ក៏បាន តែត្រូវលេខ១ សុខចិត្តឱ្យលេខ៦ដឹកនាំត្រួតត្រាទើបបាន ។";
            }
            else if (lblNumber.Text == "7")
            {
                txtDefinition.Text = "ដោយគេជាមនុស្សមានប្រាជ្ញាគេមិនសូវខកចិត្តក្នុងរឿងគូស្រករទេគេច្រើនរើសបានគូគាប់ស្របតាមសេចក្តីប្រាថ្នារបស់គេ ។ គេមិនចូលចិត្តរើសគូស្រករណាដែលមិនឆ្លាតស្អំឡើយ ។ យកល្អត្រូវរៀបការជាមួយនឹងមនុស្សជំពូកលេខ៩ និងលេខ៤ព្រោះប្រាជ្ញា និងចិត្តជាអ្នកមនុស្សនិយមមានស្របគ្នា ។ មិនគួររៀបការជាមួយមនុស្សជំពូកលេខ១ទេ ព្រោះច្រើនទាស់ទែងគ្នា ។";
            }
            else if (lblNumber.Text == "8")
            {
                txtDefinition.Text = "ក្នុងរឿងស្នេហាមនុស្សជំពូកលេខ៨ ច្រើនប្រែប្រួលមិននឹងឬទេ ។ មានម៉ូថ្នាក់ថ្នមគូគាប់មានម៉ូទៀតបែបរៀងគេចៗហើយបែបវារី ។ ដោយហេតុមនុស្សនេះមានចរិតពិបាកបែបនេះមនុស្សជំពូកលេខ៨ ត្រូវរក គូស្រករណាដែលចេះយល់ខ្លួនចេះអត់ឱនចំពោះទឹកមុខប្រែប្រួលគ្មានឈប់ឈរ របស់ខ្លួន ។ ជាទូទៅគួររៀបការជាមួយមនុស្សជំពូកលេខ២ ។ការពិតភាពស្រស់ស្រាយ និងចិត្តសន្តោសរបស់មនុស្សលេខ២តែងមានជោគ ជ័យលើភាពជាអ្នកជិះជាន់របស់មនុស្សជំពូកលេខ៨ ។";
            }
            else if (lblNumber.Text == "9")
            {
                txtDefinition.Text = "ជាអ្នកមានចិត្តស្មោះត្រង់ក្នុងស្នេហាគឺជាគូស្រករដ៏ឧត្តមថ្វីបើពេលខ្លះមនុស្ស ជំពូកនេះមិនរវីរវល់នឹងការថ្នាក់ថ្នមគ្រួសារព្រោះតែខ្លួនជាប់រវល់នឹង ប្រយោជន៍ដ៏ច្រើនហើយប្លែកក្តី ។ យកល្អមនុស្សជំពូកលេខ៩ត្រូវរៀបការជាមួយមនុស្សជំពូកលេខ៩ ដូចគ្នា លេខ៧ ឬលេខ៤ ។ គូស្រករបែបនេះស្គាល់សុខទុក្ខគ្នាណាស់ ដោយហេតុមាន គំនិត និងប្រយោជន៍រួមជាមូលដ្ឋាន ។";
            }
            else
            {
                txtDefinition.Text = "";
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblNumber.Text == "1")
            {
                txtDefinition.Text = "ជាមនុស្សដែលកើតមកសម្រាប់តែបានទទួលជោគជ័យក្នុងអ្វីៗដែលខ្លួនកាន់កាប់។ ថ្វីបើគេជាអ្នកមានគំនិតខាងការបង្កើត ហើយពិចារណាច្រើនក្តី។ មនុស្សជំពូកលេខ១ ធ្វើការក្នុងរដ្ឋបាលក៏ពូកែ រត់ការក៏ពូកែ។ តែទោះជាធ្វើការអ្វីក៏មនុស្សនេះត្រូវកាន់កាប់ការនោះតែម្នាក់ឯង ឬធ្វើជាមេគេទើបស្រប តាមវាសនារបស់គេ ។ តាមពិតទៅថ្វីបើគេជាអ្នកធ្វើការដោយស្វិតស្វាញ និងមនសិការមនុស្សជំពូកលេខ១មិនចូលចិត្តស្ថិតនៅក្រោមឱវាទគេទេ។ ក្នុងទំនាក់ទំនងជាមួយចៅហ្វាយនាយរបស់ខ្លួនមនុស្សជំពូកលេខ១ច្រើនចូលចិត្តកាត់ណាស់។";
            }
            else if (lblNumber.Text == "2")
            {
                txtDefinition.Text = "ជាមនុស្សគិតច្រើននិងមានគំនិតបង្កើតតែកង្វះខាងភាពឈ្លានពានរបស់មនុស្សនេះ តែងនាំឱ្យមនុស្សជំពូកនេះចូលចិត្តធ្វើជាចិត្តវិទូជាឧបការីសង្គមនិងជា លេខាធិការដ៏មានប្រសិទ្ធភាព ។ សរុបសេចក្តីទៅគឺជាមនុស្សដែលកើតមក សម្រាប់តែទទួលជោគជ័យក្នុងវិជ្ជាជីវៈណាដែលតម្រូវឱ្យមានមនសិការវិជ្ជាជីវៈនិងការឱហាតក្នុងកិច្ចការ ។";
            }
            else if (lblNumber.Text == "3")
            {
                txtDefinition.Text = "ដោយមានការរហ័សរហួន និងគំនិតផ្ដើមពីធម្មជាតិមកស្រាប់មនុស្សនេះចូលចិត្ត ប្រកបរបរណាដែលខ្លួនអាចបង្ហាញឱ្យឃើញនូវការប៉ិនប្រសប់ និងគំនិតផ្តួចផ្តើម របស់ខ្លួនណាស់ ។ បើធ្វើជាអ្នកកាសែតអ្នកថតរូបវិចិត្រករ គឺប្រសើរណាស់ ព្រោះអាចបានទទួលជោគជ័យច្រើន ។ ម្យ៉ាងទៀតមុខរបរខាងការផ្សាយខាងទំនាក់ទំនងសាធារណៈ ពោលឱ្យខ្លី គឺឱ្យតែមុខរបរណាមានទំនាក់ទំនងនឹងមនុស្សដទៃច្រើន មនុស្សជំពូកលេខ៣ ប្រសប់ធ្វើឱ្យបានជោគជ័យបំផុត ។";
            }
            else if (lblNumber.Text == "4")
            {
                txtDefinition.Text = "ដោយមានធម្មជាតិជាអ្នកស្រឡាញ់ការសិក្សាមនុស្សជំពូកលេខ៤មាននិស្ស័យ ខាងកិច្ចការណាដែលមានទ្រឹស្តី ជាអាទិ៍ ។ គេច្រើនជាគណិតវិទូអ្នកស្រាវជ្រាវ វិស្វករ និងសាស្ត្រាចារ្យ ។ ជាទូទៅមុខរបររបស់គេមិនហុចជោគជ័យឱ្យឃើញ ភ្លាមៗទេ ។ តែបើនឹងចាប់កិច្ចការអ្វីមួយហើយអ្នកដែលស្គាល់គេតែងសរសើរ ព្រមទាំងសង្ឃឹមលើគេ ជានិច្ច ។";
            }
            else if (lblNumber.Text == "5")
            {
                txtDefinition.Text = "អ្វីៗដែលធ្វើឱ្យមនុស្សបានទទួលជោគជ័យភ្លាមៗដូចជាការប៉ិនប្រសប់ការឈ្លាសវៃនិងការវាយឫកគឺសុទ្ធតែលក្ខណៈរបស់មនុស្សជំពូកលេខ៥ទាំងអស់ ។ ក៏ប៉ុន្តែ ដោយហេតុថាមនុស្សជំពូកនេះច្រើនជាអ្នករហេចរហាច ខ្វះវិន័យមនុស្សនេះ ច្រើនទទួលជោគជ័យក្នុងមុខរបរណាដែលអាចឱ្យខ្លួនគេសំដែងអំណោយធម្មជាតិព្រមទទាំងគំនិតផ្ដើមរបស់គេបាន ។ គេច្រើនសង្កេតឃើញមនុស្សជំពូកលេខ៥ ជាសិល្បករ អ្នកកាសែត អ្នកនិពន្ធ អ្នកបើកបរកប៉ាល់ ជាដើម ។";
            }
            else if (lblNumber.Text == "6")
            {
                txtDefinition.Text = "មនុស្សជំពូកលេខ៦មិនសូវជាអ្នកមានចិត្តលោភទេអ៊ីចឹងហើយបានគេកើតមកមិនពូកែខាងការជជែកវែកញែកដែលត្រូវការឱ្យមានគំនិតផ្តួចផ្តើមនិងបញ្ចេញបញ្ចូល ។ បំណងខាងបញ្ហាមនុស្សតែងជំរុញមនុស្សនេះឱ្យចូលចិត្តធ្វើការណា ដែលទាក់ទង នឹងសង្គមដូចជាគ្រូពេទ្យឧបការីសង្គមនិងសាស្ត្រាចារ្យជាដើម ។ និយាយឱ្យចំទៅ មនុស្សជំពូកនេះ កើតមកសម្រាប់តែទទួលជោគជ័យក្នុងវិជ្ជាជីវៈណា ដែលត្រូវការការព្យាយាម ការស្លូតបូត និងគំនិតលះបង់ ។ ";
            }
            else if (lblNumber.Text == "7")
            {
                txtDefinition.Text = "មនុស្សនេះចូលចិត្តស្រឡាញ់ការងារណា ដែលប្រើប្រាជ្ញា ។ គេច្រើនជាសង្គមវិទូ សិល្បករ មេធាវី រដ្ឋបាល ឬពាណិជ្ជករ ។ ជាទូទៅ ក្នុងមុខរបរគេច្រើនបានទទួលជោគជ័យរហ័សណាស់ ។";
            }
            else if (lblNumber.Text == "8")
            {
                txtDefinition.Text = "ដោយហេតុមាននិស្ស័យខាងគំនិតបង្កើតច្រើន និងប្រកបដោយថាមពលអស្ចារ្យទៀតនោះមនុស្សជំពូកលេខ៨ត្រូវវាសនាចារមកឱ្យបានទទួលជោគជ័យក្នុងកិច្ចការសព្វសារពើ ។ តែធ្វើអ្វីហើយគឺធ្វើដោយមផ្សំតបំផុត ។";
            }
            else if (lblNumber.Text == "9")
            {
                txtDefinition.Text = "មនុស្សជំពូកលេខ៩ ចូលចិត្តតែការងារណាដែលនាំឱ្យអាចរស់នៅជាមួយអ្នក ផងបានរហូតព្រោះមនុស្សជំពូកនេះ ចូលចិត្តទាក់ទងនឹងធ្វើសហការជាមួយ អ្នកដទៃណាស់ ។ គេច្រើនតែធ្វើជាចៅក្រម មេធាវី គ្រូពេទ្យឬសាស្ត្រាចារ្យ ។ យកល្អមនុស្សជំពូកលេខ៩ គួរកាន់កាប់មុខរបរទាំងនេះ។";
            }
            else
            {
                txtDefinition.Text = "";
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblNumber.Text == "1")
            {
                txtDefinition.Text = "	មនុស្សជំពូកលេខ១ប្រសប់ប្រកបរបបណាស់ហើយតែងរកចំណេញបានច្រើនផង។ តែជាអកុសលរកបានប៉ុន្មាន ចាយអស់ប៉ុណ្ណឹង បើនិយាយឱ្យខ្លីគឺរកក៏ធូរ ចាយក៏ធូរ។";
            }
            else if (lblNumber.Text == "2")
            {
                txtDefinition.Text = "ជាអ្នកសន្សំប្រាក់ផុតលេខហើយមិនចូលចិត្តខាតបង់លុយកក់ទទេៗក្នុងមុខរបរមានគ្រោះថ្នាក់ឬមិនជាក់ច្បាស់ឡើយ ។ គឺចូលចិត្តយកលុយទៅរកស៊ីដោយមាន បែបផែន ហើយមិនចូលចិត្តលេងល្បែងស៊ីសងទេ ។ប៉ុន្តែដោយខ្លួនជាអ្នកចិត្តល្អពីធម្មជាតិមកនោះមនុស្សជំពូកនេះហ៊ានចំណាយទៅលើមនុស្សដែលខ្លួនស្រឡាញ់ដោយឥឥតញញើតដៃទេ ។";
            }
            else if (lblNumber.Text == "3")
            {
                txtDefinition.Text = "ជាមនុស្សចិត្តល្អហើយចាយធំផង ។ ចូលចិត្តធ្វើម៉េចឱ្យតែអ្នកមកជួបនឹងខ្លួនបានសប្បាយចង់អស់ប៉ុន្មានក៏អស់ទៅ ព្រោះចូលចិត្តគិតថា លុយមិនមែនធ្វើមកសម្រាប់តែសន្សំ តែសម្រាប់ចាយ ឱ្យបានសប្បាយចិត្ត ។";
            }
            else if (lblNumber.Text == "4")
            {
                txtDefinition.Text = "មនុស្សជំពូកលេខ៤ប្រើលុយកាក់ដោយប្រយ័ត្នប្រយែងណាស់ហើយមិនស្រប រកស៊ីក្នុងមុខរបរណាដែលអាចមានកំហាតបង់ទេ ។ គេចូលចិត្តសន្សំលុយហើយពូកែទុកដាក់បំផុត ។ ស្ថានភាពហិរញ្ញវត្ថុរបស់គេច្រើនតែមាំទាំ ។ គេមិនមែនជាមនុស្សកំណាញ់ទេតែបើនឹងចាយវាយគឺគេចាយ តែលុយណាដែលគេយល់ថាអាចចាយបាន ។";
            }
            else if (lblNumber.Text == "5")
            {
                txtDefinition.Text = "ចំពោះរឿងលុយកាក់ មនុស្សនេះច្រើនជួបឧបសគ្គ ។ ជួនកាលគេជាមហាសេដ្ឋី ជួនកាលគេក៏ក្ររហាមដែរ ។ ការពិតគេជាអ្នកចាយធំហើយចូលចិត្តបំពេញចំណូលចិត្តរបស់ខ្លួនគ្រប់យ៉ាង ដោយគ្មានខ្វល់ថារឿងសប្បាយនោះនឹងឱ្យខ្លួនគេទៅរួចឬក៏ទេឡើយ ។ មនុស្សជំពូកនេះឥតចេះសន្សំលុយកាក់ទាល់តែសោះហើយរឿងរត់ការប្រឡេមប្រឡំក៏អត់ចេះដែរ។";
            }
            else if (lblNumber.Text == "6")
            {
                txtDefinition.Text = "គេមិនសូវឃើញមនុស្សជំពូកលេខ៦នេះមានទ្រព្យជាដុំកំភួនទេព្រោះមនុស្ស នេះគ្មានចិត្តស្រេកឃ្លានចង់មានចង់បានឡើយមានប៉ុន្មានស៊ីប៉ុណ្ណឹង ។ គេមិនមែនជាអ្នកចាយវាយធំទេប៉ុន្តែគេក៏មិនឱ្យតម្លៃធំទៅលើរឿងលុយកាក់ដែរ ។";
            }
            else if (lblNumber.Text == "7")
            {
                txtDefinition.Text = "គេមិនជាអ្នកចាយធូរ តែក៏មិនជាអ្នកកំណាញ់ដែរ ។ កិច្ចការណាត្រូវចាយទើប គេចាយ ។ និយាយឱ្យខ្លីទៅ គឺគេចេះចាយមានមុខមានបែប ។ គេមិនសូវជួបប្រទះនឹងរឿងទាល់លុយកាក់ទេហើយក៏ច្រើនហ៊ានចាយវាយជួយមិត្តភក្តិដែលជួបប្រទះនឹងការលំបាកផ្នែកហិរញ្ញវត្ថុទៀតផង ។";
            }
            else if (lblNumber.Text == "8")
            {
                txtDefinition.Text = "គេជាមនុស្សពូកែខាងយកលុយទៅរកស៊ីណាស់ ។ ទោះជាសម្បត្តិទ្រព្យរបស់ មានធំឬតូចក៏ដោយឱ្យតែគេប្រកបរបរគេមិនងាយខូចខាតលុយកាក់ទេ ។ មនុស្សធំៗ ជាច្រើនដែលស្ថិតនៅក្នុងជំពូកមនុស្សលេខ៨នេះច្រើនរក ទ្រព្យសម្បត្តិបានស្តុកស្តមណាស់ ដោយចាប់រកស៊ីពីគ្មានមួយសេនទៅ ។";
            }
            else if (lblNumber.Text == "9")
            {
                txtDefinition.Text = "	ក្នុងរឿងរកលុយកាក់មនុស្សជំពូកលេខ៩មិនពូកែទាល់តែសោះ ។ តែគេច្រើនជាមនុស្សមានសំណាងក្នុងរឿងរកលុយកាក់ទៅវិញ ហើយជាមនុស្សចិត្តល្អ ចំពោះអ្នកខ្វះខាត ។";
            }
            else
            {
                txtDefinition.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }///
}///
