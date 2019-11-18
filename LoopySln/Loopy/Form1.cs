using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loopy
{
    public partial class LoopyMainForm : Form
    {
        public LoopyMainForm()
        {
            InitializeComponent();
        }

        private void LoopyMainForm_Load(object sender, EventArgs e)
        {
            comboBoxIncDec.SelectedIndex = 0;
            comboBoxIncDecSec.SelectedIndex = 1;
        }

        private void comboBoxIncDec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIncDec.Text == "Decrement")
            {
                textBoxFrom.Text = "100";
                textBoxTo.Text = "0";
            }
            else
            {
                textBoxFrom.Text = "0";
                textBoxTo.Text = "100";
            }
        }

        private void comboBoxIncDecSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIncDecSec.Text == "Decrement")
            {
                textBoxFromSec.Text = "100";
                textBoxToSec.Text = "0";
            }
            else
            {
                textBoxFromSec.Text = "0";
                textBoxToSec.Text = "100";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxOutput.Clear();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxOutput.Text);
            }
            catch(Exception ex)
            {
                labelMessage.ForeColor = System.Drawing.Color.Red;
                labelMessage.Text = "Output box is empty. Press \"Generate\" button first";
            }
            
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            ///TODO-Complete main functionality this button
            labelMessage.ForeColor = System.Drawing.Color.SeaGreen;
            labelMessage.Text="hiiiii";
        }
    }
}
