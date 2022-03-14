
namespace Project6_PredictPhoneNumber
{
    partial class frmAboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAboutUs));
            this.lbBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.BackColor = System.Drawing.Color.Transparent;
            this.lbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbBack.Font = new System.Drawing.Font("SN KH WAT CHROY THMOR", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBack.ForeColor = System.Drawing.Color.White;
            this.lbBack.Location = new System.Drawing.Point(16, 11);
            this.lbBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(75, 43);
            this.lbBack.TabIndex = 7;
            this.lbBack.Text = "ត្រឡប់";
            this.lbBack.Click += new System.EventHandler(this.lbExit_Click);
            this.lbBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbBack_MouseDown);
            this.lbBack.MouseEnter += new System.EventHandler(this.lbBack_MouseEnter);
            this.lbBack.MouseLeave += new System.EventHandler(this.lbBack_MouseLeave);
            // 
            // frmAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1579, 838);
            this.Controls.Add(this.lbBack);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAboutUs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBack;
    }
}