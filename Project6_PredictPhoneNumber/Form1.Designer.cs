
namespace Project6_PredictPhoneNumber
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOK = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbExit = new System.Windows.Forms.Label();
            this.lbAboutUs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOK.Location = new System.Drawing.Point(919, 149);
            this.btnOK.Margin = new System.Windows.Forms.Padding(0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(161, 47);
            this.btnOK.TabIndex = 0;
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPhone.Location = new System.Drawing.Point(383, 158);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(433, 28);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.Color.Transparent;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbResult.Location = new System.Drawing.Point(322, 270);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(130, 56);
            this.lbResult.TabIndex = 2;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbResult.TextChanged += new System.EventHandler(this.lbResult_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("SN KH WAT CHROY THMOR", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBox1.Location = new System.Drawing.Point(76, 398);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1036, 221);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("SN KH WAT CHROY THMOR", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(1029, 276);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "សម្អាត";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbExit.Font = new System.Drawing.Font("SN KH WAT CHROY THMOR", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.Color.White;
            this.lbExit.Location = new System.Drawing.Point(12, 9);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(77, 34);
            this.lbExit.TabIndex = 6;
            this.lbExit.Text = "ចាកចេញ";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            this.lbExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbExit_MouseDown);
            this.lbExit.MouseEnter += new System.EventHandler(this.lbExit_MouseEnter);
            this.lbExit.MouseLeave += new System.EventHandler(this.lbExit_MouseLeave);
            this.lbExit.MouseHover += new System.EventHandler(this.lbExit_MouseHover);
            // 
            // lbAboutUs
            // 
            this.lbAboutUs.AutoSize = true;
            this.lbAboutUs.BackColor = System.Drawing.Color.Transparent;
            this.lbAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAboutUs.Font = new System.Drawing.Font("SN KH WAT CHROY THMOR", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAboutUs.ForeColor = System.Drawing.Color.White;
            this.lbAboutUs.Location = new System.Drawing.Point(95, 9);
            this.lbAboutUs.Name = "lbAboutUs";
            this.lbAboutUs.Size = new System.Drawing.Size(76, 34);
            this.lbAboutUs.TabIndex = 7;
            this.lbAboutUs.Text = "អំពីកម្មវិធី";
            this.lbAboutUs.Click += new System.EventHandler(this.lbAboutUs_Click);
            this.lbAboutUs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbAboutUs_MouseDown);
            this.lbAboutUs.MouseEnter += new System.EventHandler(this.lbAboutUs_MouseEnter);
            this.lbAboutUs.MouseLeave += new System.EventHandler(this.lbAboutUs_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.lbAboutUs);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnOK);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Label lbAboutUs;
    }
}

