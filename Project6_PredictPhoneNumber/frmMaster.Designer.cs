
namespace Project6_PredictPhoneNumber
{
    partial class frmMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaster));
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.BackColor = System.Drawing.Color.Transparent;
            this.lbPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPhone.Font = new System.Drawing.Font("SN KH WAT CHROY THMOR", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.ForeColor = System.Drawing.Color.Black;
            this.lbPhone.Location = new System.Drawing.Point(151, 287);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(310, 49);
            this.lbPhone.TabIndex = 8;
            this.lbPhone.Text = "កម្មវិធី ទស្សន៍ទាយលេខទូរស័ព្ទ";
            this.lbPhone.Click += new System.EventHandler(this.lbPhone_Click);
            this.lbPhone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbPhone_MouseDown);
            this.lbPhone.MouseEnter += new System.EventHandler(this.lbPhone_MouseEnter);
            this.lbPhone.MouseLeave += new System.EventHandler(this.lbPhone_MouseLeave);
            // 
            // lbExit
            // 
            this.lbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbExit.Font = new System.Drawing.Font("SN KH WAT CHROY THMOR", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.Color.Black;
            this.lbExit.Location = new System.Drawing.Point(1486, 17);
            this.lbExit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(37, 34);
            this.lbExit.TabIndex = 9;
            this.lbExit.Text = "បិទ";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            this.lbExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbExit_MouseDown);
            this.lbExit.MouseEnter += new System.EventHandler(this.lbExit_MouseEnter);
            this.lbExit.MouseLeave += new System.EventHandler(this.lbExit_MouseLeave);
            // 
            // frmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.lbPhone);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("SN KH WAT CHROY THMOR", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "frmMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbExit;
    }
}