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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.labelVarName = new System.Windows.Forms.Label();
            this.textBoxVarName = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.comboBoxIncDec = new System.Windows.Forms.ComboBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBoxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(103, 71);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInput.Size = new System.Drawing.Size(668, 48);
            this.textBoxInput.TabIndex = 0;
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.ForeColor = System.Drawing.Color.Black;
            this.labelMain.Location = new System.Drawing.Point(663, -1);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(108, 45);
            this.labelMain.TabIndex = 1;
            this.labelMain.Text = "Loopy";
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine.Location = new System.Drawing.Point(12, 71);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(85, 21);
            this.labelLine.TabIndex = 2;
            this.labelLine.Text = "Your Text :";
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.comboBoxIncDec);
            this.groupBoxMain.Controls.Add(this.textBoxTo);
            this.groupBoxMain.Controls.Add(this.labelTo);
            this.groupBoxMain.Controls.Add(this.textBoxFrom);
            this.groupBoxMain.Controls.Add(this.labelFrom);
            this.groupBoxMain.Controls.Add(this.textBoxVarName);
            this.groupBoxMain.Controls.Add(this.labelVarName);
            this.groupBoxMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMain.Location = new System.Drawing.Point(16, 171);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(755, 81);
            this.groupBoxMain.TabIndex = 3;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Customize Varable";
            // 
            // labelVarName
            // 
            this.labelVarName.AutoSize = true;
            this.labelVarName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVarName.Location = new System.Drawing.Point(20, 45);
            this.labelVarName.Name = "labelVarName";
            this.labelVarName.Size = new System.Drawing.Size(95, 17);
            this.labelVarName.TabIndex = 0;
            this.labelVarName.Text = "Variable Name";
            // 
            // textBoxVarName
            // 
            this.textBoxVarName.Location = new System.Drawing.Point(130, 42);
            this.textBoxVarName.Name = "textBoxVarName";
            this.textBoxVarName.Size = new System.Drawing.Size(149, 25);
            this.textBoxVarName.TabIndex = 1;
            this.textBoxVarName.Text = "[Loopy]";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(510, 42);
            this.textBoxFrom.MaxLength = 10;
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(79, 25);
            this.textBoxFrom.TabIndex = 3;
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
            this.labelFrom.TabIndex = 2;
            this.labelFrom.Text = "from";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(639, 42);
            this.textBoxTo.MaxLength = 10;
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(79, 25);
            this.textBoxTo.TabIndex = 4;
            this.textBoxTo.Text = "1000000000";
            this.textBoxTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(612, 45);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(21, 17);
            this.labelTo.TabIndex = 4;
            this.labelTo.Text = "to";
            // 
            // progressBarMain
            // 
            this.progressBarMain.Location = new System.Drawing.Point(16, 322);
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(755, 22);
            this.progressBarMain.TabIndex = 4;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(16, 334);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(755, 142);
            this.textBoxOutput.TabIndex = 5;
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
            this.buttonGenerate.Location = new System.Drawing.Point(619, 268);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(152, 36);
            this.buttonGenerate.TabIndex = 5;
            this.buttonGenerate.Text = "Generate >>";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(463, 483);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(142, 36);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear Output";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(629, 483);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(142, 36);
            this.buttonCopy.TabIndex = 7;
            this.buttonCopy.Text = "Copy To Clipboard";
            this.buttonCopy.UseVisualStyleBackColor = true;
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
            this.comboBoxIncDec.TabIndex = 2;
            this.comboBoxIncDec.SelectedIndexChanged += new System.EventHandler(this.comboBoxIncDec_SelectedIndexChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(16, 483);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(142, 36);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // LoopyMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(783, 535);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoopyMainForm";
            this.Text = "Loopy";
            this.Load += new System.EventHandler(this.LoopyMainForm_Load);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
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
    }
}

