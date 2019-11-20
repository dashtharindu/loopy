namespace Loopy
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.Owner = new System.Windows.Forms.Label();
            this.labelThank = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.richTextBoxAbout = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Owner
            // 
            this.Owner.AutoSize = true;
            this.Owner.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Owner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Owner.Location = new System.Drawing.Point(64, 377);
            this.Owner.Name = "Owner";
            this.Owner.Size = new System.Drawing.Size(382, 86);
            this.Owner.TabIndex = 0;
            this.Owner.Text = "Tharindu-D";
            // 
            // labelThank
            // 
            this.labelThank.AutoSize = true;
            this.labelThank.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThank.Location = new System.Drawing.Point(279, 367);
            this.labelThank.Name = "labelThank";
            this.labelThank.Size = new System.Drawing.Size(98, 28);
            this.labelThank.TabIndex = 1;
            this.labelThank.Text = "Thank You";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(152, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(94, 37);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Loopy";
            // 
            // richTextBoxAbout
            // 
            this.richTextBoxAbout.BackColor = System.Drawing.Color.MistyRose;
            this.richTextBoxAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxAbout.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxAbout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAbout.Location = new System.Drawing.Point(44, 61);
            this.richTextBoxAbout.Name = "richTextBoxAbout";
            this.richTextBoxAbout.ReadOnly = true;
            this.richTextBoxAbout.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxAbout.Size = new System.Drawing.Size(315, 303);
            this.richTextBoxAbout.TabIndex = 4;
            this.richTextBoxAbout.Text = "This is a small program which was created on my leisure time and I really hope th" +
    "is program will be helpful for all of you. \n\n\nDotnet Framework version 4.5\n\nhttp" +
    "s://github.com/dashtharindu\n";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(404, 439);
            this.Controls.Add(this.richTextBoxAbout);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelThank);
            this.Controls.Add(this.Owner);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "About";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Owner;
        private System.Windows.Forms.Label labelThank;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RichTextBox richTextBoxAbout;
    }
}