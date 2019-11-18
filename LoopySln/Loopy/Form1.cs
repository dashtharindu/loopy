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
    }
}
