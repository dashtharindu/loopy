using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading;
using System.Windows.Forms;
using ModelLibrary;

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
            comboBoxIncDec.SelectedIndex = 0; //increment
            labelIncDecSec.Text = "Decrement"; //Decrement
            groupBoxSec.Visible = false;
        }

        private void comboBoxIncDec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIncDec.Text == "Decrement")
            {
                textBoxFrom.Text = "100";
                textBoxTo.Text = "0";
                labelIncDecSec.Text = "Increment" ;
                textBoxFromSec.Text = "0";
            }
            else
            {
                textBoxFrom.Text = "0";
                textBoxTo.Text = "100";
                labelIncDecSec.Text = "Decrement";
                textBoxFromSec.Text = "100";
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
                //labelMessage.Text = "";
                //Thread STAThread = new Thread( 
                //    delegate (){
                //        Clipboard.SetText(textBoxOutput.Text);
                //    });
                //STAThread.SetApartmentState(ApartmentState.STA);
                //STAThread.Start();
                //STAThread.Join();
                textBoxOutput.SelectAll();
                textBoxOutput.Copy();
                textBoxOutput.DeselectAll();
            }
            catch(Exception ex)
            {
                labelMessage.ForeColor = System.Drawing.Color.Red;
                labelMessage.Text = $"Error \n{ex.Message}";
            }
            
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            labelMessage.Text = "";

            Model variable = new Model();
            variable.getInput = textBoxInput.Text;
            variable.getVarName = textBoxVarName.Text;
            variable.getBehavior = comboBoxIncDec.Text;
            variable.getFrom = Convert.ToInt32(textBoxFrom.Text);
            variable.getTo = Convert.ToInt32(textBoxTo.Text);
            variable.getCheckbox = checkBoxSec.Checked;

            variable.getVarNameSec = textBoxVarNameSec.Text;
            variable.getFromSec = Convert.ToInt32(textBoxFromSec.Text);

            textBoxOutput.Text = variable.GenerateOutput();

            //catch(Exception ex)
            //{
            //    labelMessage.ForeColor = System.Drawing.Color.Red;
            //    labelMessage.Text = $"Variable Customization Error\n{ex.Message}";
            //}

            //catch (Exception ex)
            //{
            //    labelMessage.ForeColor = System.Drawing.Color.Red;
            //    labelMessage.Text = $"Input Text or variable name error\n{ex.Message}";
            //}
        }

        private void checkBoxSec_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSec.Checked)
            {
                groupBoxSec.Visible = true;
            }
            else if (!checkBoxSec.Checked)
            {
                groupBoxSec.Visible = false;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void textBoxFromSec_TextChanged(object sender, EventArgs e)
        {
            try
            {
                labelMessage.Text = "";
                int intFromTemp = Convert.ToInt32(textBoxFrom.Text);
                int intToTemp = Convert.ToInt32(textBoxTo.Text);

                int intFromSecTemp = Convert.ToInt32(textBoxFromSec.Text);
                int intToSecTemp = Convert.ToInt32(textBoxToSec.Text);

                intToSecTemp = intFromSecTemp + (intFromTemp - intToTemp);

                textBoxToSec.Text = intToSecTemp.ToString();
            }
            catch(Exception ex)
            {
                labelMessage.ForeColor = Color.Red;
                labelMessage.Text = $"Error\n{ex.Message}";
            }


        }

        private void themeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.BackColor == Color.Black)
            {
                this.BackColor = Color.MistyRose;
                this.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
            }
            
        }
    }
}
