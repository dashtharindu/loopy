﻿namespace Loopy
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
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
            this.comboBoxIncDecSec = new System.Windows.Forms.ComboBox();
            this.textBoxToSec = new System.Windows.Forms.TextBox();
            this.labelToSec = new System.Windows.Forms.Label();
            this.textBoxFromSec = new System.Windows.Forms.TextBox();
            this.labelFromSec = new System.Windows.Forms.Label();
            this.textBoxVarNameSec = new System.Windows.Forms.TextBox();
            this.labelVarNameSec = new System.Windows.Forms.Label();
            this.labelOp = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.groupBoxMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
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
            this.labelMain.ForeColor = System.Drawing.Color.Black;
            this.labelMain.Location = new System.Drawing.Point(663, 0);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(108, 45);
            this.labelMain.TabIndex = 12;
            this.labelMain.Text = "Loopy";
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
            this.groupBoxMain.Controls.Add(this.labelOp);
            this.groupBoxMain.Controls.Add(this.comboBoxIncDecSec);
            this.groupBoxMain.Controls.Add(this.textBoxToSec);
            this.groupBoxMain.Controls.Add(this.labelToSec);
            this.groupBoxMain.Controls.Add(this.textBoxFromSec);
            this.groupBoxMain.Controls.Add(this.labelFromSec);
            this.groupBoxMain.Controls.Add(this.textBoxVarNameSec);
            this.groupBoxMain.Controls.Add(this.labelVarNameSec);
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
            // comboBoxIncDec
            // 
            this.comboBoxIncDec.BackColor = System.Drawing.Color.White;
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
            this.textBoxTo.Location = new System.Drawing.Point(639, 42);
            this.textBoxTo.MaxLength = 10;
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(79, 25);
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
            this.textBoxFrom.Location = new System.Drawing.Point(510, 42);
            this.textBoxFrom.MaxLength = 10;
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(79, 25);
            this.textBoxFrom.TabIndex = 4;
            this.textBoxFrom.Text = "0";
            this.textBoxFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(467, 45);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(37, 17);
            this.labelFrom.TabIndex = 12;
            this.labelFrom.Text = "from";
            // 
            // textBoxVarName
            // 
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
            this.buttonGenerate.BackColor = System.Drawing.Color.LightGreen;
            this.buttonGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGenerate.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonGenerate.FlatAppearance.BorderSize = 2;
            this.buttonGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
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
            this.buttonClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.Green;
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
            this.buttonCopy.BackColor = System.Drawing.Color.LightGreen;
            this.buttonCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCopy.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonCopy.FlatAppearance.BorderSize = 2;
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.buttonReset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            // 
            // comboBoxIncDecSec
            // 
            this.comboBoxIncDecSec.BackColor = System.Drawing.Color.White;
            this.comboBoxIncDecSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxIncDecSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIncDecSec.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxIncDecSec.FormattingEnabled = true;
            this.comboBoxIncDecSec.Items.AddRange(new object[] {
            "Increment",
            "Decrement"});
            this.comboBoxIncDecSec.Location = new System.Drawing.Point(310, 103);
            this.comboBoxIncDecSec.Name = "comboBoxIncDecSec";
            this.comboBoxIncDecSec.Size = new System.Drawing.Size(121, 25);
            this.comboBoxIncDecSec.TabIndex = 14;
            this.comboBoxIncDecSec.SelectedIndexChanged += new System.EventHandler(this.comboBoxIncDecSec_SelectedIndexChanged);
            // 
            // textBoxToSec
            // 
            this.textBoxToSec.Location = new System.Drawing.Point(639, 103);
            this.textBoxToSec.MaxLength = 10;
            this.textBoxToSec.Name = "textBoxToSec";
            this.textBoxToSec.Size = new System.Drawing.Size(79, 25);
            this.textBoxToSec.TabIndex = 16;
            this.textBoxToSec.Text = "100";
            this.textBoxToSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelToSec
            // 
            this.labelToSec.AutoSize = true;
            this.labelToSec.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToSec.Location = new System.Drawing.Point(612, 106);
            this.labelToSec.Name = "labelToSec";
            this.labelToSec.Size = new System.Drawing.Size(21, 17);
            this.labelToSec.TabIndex = 17;
            this.labelToSec.Text = "to";
            // 
            // textBoxFromSec
            // 
            this.textBoxFromSec.Location = new System.Drawing.Point(510, 103);
            this.textBoxFromSec.MaxLength = 10;
            this.textBoxFromSec.Name = "textBoxFromSec";
            this.textBoxFromSec.Size = new System.Drawing.Size(79, 25);
            this.textBoxFromSec.TabIndex = 15;
            this.textBoxFromSec.Text = "0";
            this.textBoxFromSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFromSec
            // 
            this.labelFromSec.AutoSize = true;
            this.labelFromSec.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFromSec.Location = new System.Drawing.Point(467, 106);
            this.labelFromSec.Name = "labelFromSec";
            this.labelFromSec.Size = new System.Drawing.Size(37, 17);
            this.labelFromSec.TabIndex = 18;
            this.labelFromSec.Text = "from";
            // 
            // textBoxVarNameSec
            // 
            this.textBoxVarNameSec.Location = new System.Drawing.Point(130, 103);
            this.textBoxVarNameSec.Name = "textBoxVarNameSec";
            this.textBoxVarNameSec.Size = new System.Drawing.Size(149, 25);
            this.textBoxVarNameSec.TabIndex = 13;
            this.textBoxVarNameSec.Text = "[LoopX]";
            // 
            // labelVarNameSec
            // 
            this.labelVarNameSec.AutoSize = true;
            this.labelVarNameSec.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVarNameSec.Location = new System.Drawing.Point(6, 106);
            this.labelVarNameSec.Name = "labelVarNameSec";
            this.labelVarNameSec.Size = new System.Drawing.Size(122, 17);
            this.labelVarNameSec.TabIndex = 19;
            this.labelVarNameSec.Text = "2nd Variable Name";
            // 
            // labelOp
            // 
            this.labelOp.AutoSize = true;
            this.labelOp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOp.Location = new System.Drawing.Point(32, 123);
            this.labelOp.Name = "labelOp";
            this.labelOp.Size = new System.Drawing.Size(64, 17);
            this.labelOp.TabIndex = 20;
            this.labelOp.Text = "(Optional)";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Black;
            this.labelMessage.Location = new System.Drawing.Point(55, 368);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 21);
            this.labelMessage.TabIndex = 13;
            // 
            // LoopyMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoopyMainForm";
            this.Text = "Loopy";
            this.Load += new System.EventHandler(this.LoopyMainForm_Load);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
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
        private System.Windows.Forms.Label labelOp;
        private System.Windows.Forms.ComboBox comboBoxIncDecSec;
        private System.Windows.Forms.TextBox textBoxToSec;
        private System.Windows.Forms.Label labelToSec;
        private System.Windows.Forms.TextBox textBoxFromSec;
        private System.Windows.Forms.Label labelFromSec;
        private System.Windows.Forms.TextBox textBoxVarNameSec;
        private System.Windows.Forms.Label labelVarNameSec;
        private System.Windows.Forms.Label labelMessage;
    }
}

