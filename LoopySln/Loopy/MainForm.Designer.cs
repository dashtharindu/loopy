namespace Loopy
{
    partial class LoopyMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoopyMainForm));
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.checkBoxSec = new System.Windows.Forms.CheckBox();
            this.groupBoxSec = new System.Windows.Forms.GroupBox();
            this.textBoxToSec = new System.Windows.Forms.TextBox();
            this.labelToSec = new System.Windows.Forms.Label();
            this.labelIncDecSec = new System.Windows.Forms.Label();
            this.textBoxVarNameSec = new System.Windows.Forms.TextBox();
            this.labelVarNameSec = new System.Windows.Forms.Label();
            this.labelFromSec = new System.Windows.Forms.Label();
            this.textBoxFromSec = new System.Windows.Forms.TextBox();
            this.comboBoxIncDec = new System.Windows.Forms.ComboBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.textBoxVarName = new System.Windows.Forms.TextBox();
            this.labelVarName = new System.Windows.Forms.Label();
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMessage = new System.Windows.Forms.Label();
            this.groupBoxMain.SuspendLayout();
            this.groupBoxSec.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(103, 61);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInput.Size = new System.Drawing.Size(668, 93);
            this.textBoxInput.TabIndex = 1;
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.ForeColor = System.Drawing.Color.Maroon;
            this.labelMain.Location = new System.Drawing.Point(657, 0);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(126, 45);
            this.labelMain.TabIndex = 12;
            this.labelMain.Text = "  Loopy";
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine.Location = new System.Drawing.Point(12, 61);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(85, 21);
            this.labelLine.TabIndex = 12;
            this.labelLine.Text = "Your Text :";
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.checkBoxSec);
            this.groupBoxMain.Controls.Add(this.groupBoxSec);
            this.groupBoxMain.Controls.Add(this.comboBoxIncDec);
            this.groupBoxMain.Controls.Add(this.textBoxTo);
            this.groupBoxMain.Controls.Add(this.labelTo);
            this.groupBoxMain.Controls.Add(this.textBoxFrom);
            this.groupBoxMain.Controls.Add(this.labelFrom);
            this.groupBoxMain.Controls.Add(this.textBoxVarName);
            this.groupBoxMain.Controls.Add(this.labelVarName);
            this.groupBoxMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMain.Location = new System.Drawing.Point(16, 177);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(755, 163);
            this.groupBoxMain.TabIndex = 2;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Customize Varable";
            // 
            // checkBoxSec
            // 
            this.checkBoxSec.AutoSize = true;
            this.checkBoxSec.BackColor = System.Drawing.Color.LavenderBlush;
            this.checkBoxSec.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSec.Location = new System.Drawing.Point(23, 92);
            this.checkBoxSec.Name = "checkBoxSec";
            this.checkBoxSec.Size = new System.Drawing.Size(111, 17);
            this.checkBoxSec.TabIndex = 22;
            this.checkBoxSec.Text = "Use 2nd variable";
            this.checkBoxSec.UseVisualStyleBackColor = false;
            this.checkBoxSec.CheckedChanged += new System.EventHandler(this.checkBoxSec_CheckedChanged);
            // 
            // groupBoxSec
            // 
            this.groupBoxSec.Controls.Add(this.textBoxToSec);
            this.groupBoxSec.Controls.Add(this.labelToSec);
            this.groupBoxSec.Controls.Add(this.labelIncDecSec);
            this.groupBoxSec.Controls.Add(this.textBoxVarNameSec);
            this.groupBoxSec.Controls.Add(this.labelVarNameSec);
            this.groupBoxSec.Controls.Add(this.labelFromSec);
            this.groupBoxSec.Controls.Add(this.textBoxFromSec);
            this.groupBoxSec.Location = new System.Drawing.Point(0, 106);
            this.groupBoxSec.Name = "groupBoxSec";
            this.groupBoxSec.Size = new System.Drawing.Size(755, 57);
            this.groupBoxSec.TabIndex = 21;
            this.groupBoxSec.TabStop = false;
            // 
            // textBoxToSec
            // 
            this.textBoxToSec.BackColor = System.Drawing.Color.PeachPuff;
            this.textBoxToSec.Location = new System.Drawing.Point(639, 24);
            this.textBoxToSec.MaxLength = 6;
            this.textBoxToSec.Name = "textBoxToSec";
            this.textBoxToSec.ReadOnly = true;
            this.textBoxToSec.Size = new System.Drawing.Size(49, 25);
            this.textBoxToSec.TabIndex = 21;
            this.textBoxToSec.Text = "0";
            this.textBoxToSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelToSec
            // 
            this.labelToSec.AutoSize = true;
            this.labelToSec.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToSec.Location = new System.Drawing.Point(612, 27);
            this.labelToSec.Name = "labelToSec";
            this.labelToSec.Size = new System.Drawing.Size(21, 17);
            this.labelToSec.TabIndex = 20;
            this.labelToSec.Text = "to";
            // 
            // labelIncDecSec
            // 
            this.labelIncDecSec.AutoSize = true;
            this.labelIncDecSec.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncDecSec.ForeColor = System.Drawing.Color.Black;
            this.labelIncDecSec.Location = new System.Drawing.Point(322, 25);
            this.labelIncDecSec.Name = "labelIncDecSec";
            this.labelIncDecSec.Size = new System.Drawing.Size(86, 20);
            this.labelIncDecSec.TabIndex = 14;
            this.labelIncDecSec.Text = "Decrement";
            this.labelIncDecSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxVarNameSec
            // 
            this.textBoxVarNameSec.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxVarNameSec.Location = new System.Drawing.Point(130, 24);
            this.textBoxVarNameSec.Name = "textBoxVarNameSec";
            this.textBoxVarNameSec.Size = new System.Drawing.Size(149, 25);
            this.textBoxVarNameSec.TabIndex = 13;
            this.textBoxVarNameSec.Text = "[LoopX]";
            // 
            // labelVarNameSec
            // 
            this.labelVarNameSec.AutoSize = true;
            this.labelVarNameSec.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVarNameSec.Location = new System.Drawing.Point(6, 27);
            this.labelVarNameSec.Name = "labelVarNameSec";
            this.labelVarNameSec.Size = new System.Drawing.Size(122, 17);
            this.labelVarNameSec.TabIndex = 19;
            this.labelVarNameSec.Text = "2nd Variable Name";
            // 
            // labelFromSec
            // 
            this.labelFromSec.AutoSize = true;
            this.labelFromSec.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFromSec.Location = new System.Drawing.Point(501, 27);
            this.labelFromSec.Name = "labelFromSec";
            this.labelFromSec.Size = new System.Drawing.Size(37, 17);
            this.labelFromSec.TabIndex = 18;
            this.labelFromSec.Text = "from";
            // 
            // textBoxFromSec
            // 
            this.textBoxFromSec.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxFromSec.Location = new System.Drawing.Point(544, 24);
            this.textBoxFromSec.MaxLength = 6;
            this.textBoxFromSec.Name = "textBoxFromSec";
            this.textBoxFromSec.Size = new System.Drawing.Size(49, 25);
            this.textBoxFromSec.TabIndex = 15;
            this.textBoxFromSec.Text = "100";
            this.textBoxFromSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFromSec.TextChanged += new System.EventHandler(this.textBoxFromSec_TextChanged);
            // 
            // comboBoxIncDec
            // 
            this.comboBoxIncDec.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBoxIncDec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxIncDec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIncDec.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxIncDec.FormattingEnabled = true;
            this.comboBoxIncDec.Items.AddRange(new object[] {
            "Increment",
            "Decrement"});
            this.comboBoxIncDec.Location = new System.Drawing.Point(310, 42);
            this.comboBoxIncDec.Name = "comboBoxIncDec";
            this.comboBoxIncDec.Size = new System.Drawing.Size(121, 25);
            this.comboBoxIncDec.TabIndex = 3;
            this.comboBoxIncDec.SelectedIndexChanged += new System.EventHandler(this.comboBoxIncDec_SelectedIndexChanged);
            // 
            // textBoxTo
            // 
            this.textBoxTo.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxTo.Location = new System.Drawing.Point(639, 42);
            this.textBoxTo.MaxLength = 6;
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(49, 25);
            this.textBoxTo.TabIndex = 5;
            this.textBoxTo.Text = "100";
            this.textBoxTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(612, 45);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(21, 17);
            this.labelTo.TabIndex = 12;
            this.labelTo.Text = "to";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxFrom.Location = new System.Drawing.Point(544, 42);
            this.textBoxFrom.MaxLength = 6;
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(49, 25);
            this.textBoxFrom.TabIndex = 4;
            this.textBoxFrom.Text = "0";
            this.textBoxFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(501, 45);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(37, 17);
            this.labelFrom.TabIndex = 12;
            this.labelFrom.Text = "from";
            // 
            // textBoxVarName
            // 
            this.textBoxVarName.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxVarName.Location = new System.Drawing.Point(130, 42);
            this.textBoxVarName.Name = "textBoxVarName";
            this.textBoxVarName.Size = new System.Drawing.Size(149, 25);
            this.textBoxVarName.TabIndex = 2;
            this.textBoxVarName.Text = "[LoopY]";
            // 
            // labelVarName
            // 
            this.labelVarName.AutoSize = true;
            this.labelVarName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVarName.Location = new System.Drawing.Point(20, 45);
            this.labelVarName.Name = "labelVarName";
            this.labelVarName.Size = new System.Drawing.Size(95, 17);
            this.labelVarName.TabIndex = 12;
            this.labelVarName.Text = "Variable Name";
            // 
            // progressBarMain
            // 
            this.progressBarMain.Location = new System.Drawing.Point(16, 410);
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(755, 10);
            this.progressBarMain.TabIndex = 12;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxOutput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(16, 422);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(755, 152);
            this.textBoxOutput.TabIndex = 7;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.Pink;
            this.buttonGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGenerate.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.buttonGenerate.FlatAppearance.BorderSize = 2;
            this.buttonGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.buttonGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(619, 360);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(152, 36);
            this.buttonGenerate.TabIndex = 6;
            this.buttonGenerate.Text = "Generate >>";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(183, 594);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(142, 36);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear Output";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.Pink;
            this.buttonCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCopy.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.buttonCopy.FlatAppearance.BorderSize = 2;
            this.buttonCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.buttonCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopy.Location = new System.Drawing.Point(619, 594);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(152, 36);
            this.buttonCopy.TabIndex = 8;
            this.buttonCopy.Text = "Copy To Clipboard";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(16, 594);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(142, 36);
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "Restart";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.LightPink;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(783, 24);
            this.menuStripMain.TabIndex = 10;
            this.menuStripMain.Text = "Menu";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.themeToolStripMenuItem.Text = "Theme";
            this.themeToolStripMenuItem.Click += new System.EventHandler(this.themeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripMenuItem.Text = "About";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Black;
            this.labelMessage.Location = new System.Drawing.Point(81, 360);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 20);
            this.labelMessage.TabIndex = 13;
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoopyMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(783, 651);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.progressBarMain);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoopyMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loopy";
            this.Load += new System.EventHandler(this.LoopyMainForm_Load);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.groupBoxSec.ResumeLayout(false);
            this.groupBoxSec.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.TextBox textBoxVarName;
        private System.Windows.Forms.Label labelVarName;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.ProgressBar progressBarMain;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.ComboBox comboBoxIncDec;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxFromSec;
        private System.Windows.Forms.Label labelFromSec;
        private System.Windows.Forms.TextBox textBoxVarNameSec;
        private System.Windows.Forms.Label labelVarNameSec;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.CheckBox checkBoxSec;
        private System.Windows.Forms.GroupBox groupBoxSec;
        private System.Windows.Forms.Label labelIncDecSec;
        private System.Windows.Forms.TextBox textBoxToSec;
        private System.Windows.Forms.Label labelToSec;
    }
}

