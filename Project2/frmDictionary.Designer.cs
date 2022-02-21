
namespace Project2
{
    partial class frmDictionary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDictionary));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstWord = new System.Windows.Forms.ListBox();
            this.txtWordMean = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(28, 83);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(328, 29);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // lstWord
            // 
            this.lstWord.FormattingEnabled = true;
            this.lstWord.ItemHeight = 24;
            this.lstWord.Location = new System.Drawing.Point(28, 127);
            this.lstWord.Name = "lstWord";
            this.lstWord.Size = new System.Drawing.Size(328, 532);
            this.lstWord.TabIndex = 1;
            this.lstWord.SelectedIndexChanged += new System.EventHandler(this.lstWord_SelectedIndexChanged);
            // 
            // txtWordMean
            // 
            this.txtWordMean.BackColor = System.Drawing.Color.White;
            this.txtWordMean.Location = new System.Drawing.Point(397, 127);
            this.txtWordMean.Name = "txtWordMean";
            this.txtWordMean.Size = new System.Drawing.Size(759, 532);
            this.txtWordMean.TabIndex = 2;
            this.txtWordMean.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dictionary English Khmer Chun Nat";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWordMean);
            this.Controls.Add(this.lstWord);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmDictionary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.frmDictionary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lstWord;
        private System.Windows.Forms.RichTextBox txtWordMean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}