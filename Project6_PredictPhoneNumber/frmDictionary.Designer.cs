
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
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(54, 196);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(263, 28);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // lstWord
            // 
            this.lstWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWord.FormattingEnabled = true;
            this.lstWord.ItemHeight = 25;
            this.lstWord.Location = new System.Drawing.Point(54, 277);
            this.lstWord.Name = "lstWord";
            this.lstWord.Size = new System.Drawing.Size(263, 350);
            this.lstWord.TabIndex = 1;
            this.lstWord.SelectedIndexChanged += new System.EventHandler(this.lstWord_SelectedIndexChanged);
            // 
            // txtWordMean
            // 
            this.txtWordMean.BackColor = System.Drawing.Color.White;
            this.txtWordMean.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWordMean.Font = new System.Drawing.Font("Khmer OS System CN", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordMean.Location = new System.Drawing.Point(388, 194);
            this.txtWordMean.Name = "txtWordMean";
            this.txtWordMean.ReadOnly = true;
            this.txtWordMean.Size = new System.Drawing.Size(723, 431);
            this.txtWordMean.TabIndex = 2;
            this.txtWordMean.Text = "";
            // 
            // frmDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.txtWordMean);
            this.Controls.Add(this.lstWord);
            this.Controls.Add(this.txtSearch);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDictionary";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDictionary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lstWord;
        private System.Windows.Forms.RichTextBox txtWordMean;
    }
}