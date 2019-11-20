using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading;
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
            comboBoxIncDec.SelectedIndex = 0; //increment
            labelIncDecSec.Text = "Decrement"; //Decrement
            groupBoxSec.Visible = false; //hide the 2nd variable
        }

        private void comboBoxIncDec_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change the variable's default values according to the dropdown menu text
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
            //clearing the output and labelMessage
            textBoxOutput.Clear();
            ClearMessage();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //-- restarts the entire application --
            //maybe useful when user needs to restore default values or for some unknown errors
            Application.Restart();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            //copy entire output at once
            try
            {
                ClearMessage();
                textBoxOutput.SelectAll();
                textBoxOutput.Copy();
                textBoxOutput.DeselectAll();
                SuccessMessage("Output copied to the clipboard \nUse Ctrl+V or Select \"Paste\" from the right click menu to paste it");
            }
            catch(Exception ex)
            {
                ErrorMessage(ex);
            }
            
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //-- Main Functionality of this application --
            //gets all inputs to the variables and use them to generate the output
            //if user input large integer (more than 6chars) this software may tend to be unresponsive (if they use low end mechines less than 1gb memory) 
            //so I did limited textbox length property to "6" for textBoxFrom , textBoxTo and textBoxToSec as well.

            ///TODO-Looking forward more reliable and fast way of doing this
            ///TODO-Add "progressBarMain" for loading using Async method and Using.System.Threading

            try
            {
                ClearMessage();
                DisplayMessage("Please Wait");

                string getVarName = textBoxVarName.Text;
                int getFrom = Convert.ToInt32(textBoxFrom.Text);
                int getTo = Convert.ToInt32(textBoxTo.Text);
                bool getCheckbox = checkBoxSec.Checked;

                //get Second variable
                string getVarNameSec = textBoxVarNameSec.Text;
                int getFromSec = Convert.ToInt32(textBoxFromSec.Text);

                string getInput = textBoxInput.Text;
                if (getInput!="")
                {
                    textBoxOutput.Text = GenerateOutput();
                    SuccessMessage("Done!");
                }

                //Input text is blank
                else
                {
                    DisplayMessage("Please Insert Your Text");
                }

                string GenerateOutput()
                {
                    StringBuilder sbOut = new StringBuilder();

                    while (getFrom <= getTo )
                    {
                        string strOut = getInput.Replace(getVarName, getFrom.ToString());
                        if (getCheckbox)
                        {
                            strOut = strOut.Replace(getVarNameSec, getFromSec.ToString());
                        }
                        sbOut.Append(strOut);
                        sbOut.Append(Environment.NewLine);

                        getFrom++;
                        if (getCheckbox)
                        {
                            getFromSec--;
                        }
                        

                    }

                    while (getFrom >= getTo)
                    {
                        string strOut = getInput.Replace(getVarName, getFrom.ToString());
                        if (getCheckbox)
                        {
                            strOut = strOut.Replace(getVarNameSec, getFromSec.ToString());
                        }
                        sbOut.Append(strOut);
                        sbOut.Append(Environment.NewLine);

                        getFrom--;
                        if (getCheckbox)
                        {
                            getFromSec++;
                        }
                    }

                    return sbOut.ToString();
                }

            }

            //display when user type any other data type such as "string" rather than "Int" in textBoxFrom or textBoxTo
            catch (FormatException)
            {
                ErrorMessage("Incorrect text. Please check all text fields again");
            }
            //Display common error
            catch(Exception ex)
            {
                ErrorMessage(ex);
            }

        }

        private void checkBoxSec_CheckedChanged(object sender, EventArgs e)
        {
            //Show or Hide 2nd variable according to the checkbox status
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
            //Display About form
            new About().Show();
        }

        private void textBoxFromSec_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClearMessage();
                //when user try to change 2nd "textBoxFromSec" text, This will auto trigger and fill "textBoxToSec" value automatically
                int intFromTemp = Convert.ToInt32(textBoxFrom.Text);
                int intToTemp = Convert.ToInt32(textBoxTo.Text);

                int intFromSecTemp = Convert.ToInt32(textBoxFromSec.Text);
                int intToSecTemp = Convert.ToInt32(textBoxToSec.Text);

                //calculate the difference of 1st variables's "From" to "To"
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
            ///TODO-improve dark theme
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///TODO-create help guide
        }


        /// <summary>
        /// Display Error message as "Error \n{err.Message}" format
        /// Text color will be in red
        /// </summary>
        /// <param name="err">Use to pass the exception (data type should be "Exception")</param>
        private void ErrorMessage(Exception err)
        {
            labelMessage.ForeColor = Color.Red;
            labelMessage.Text = $"Error \n{err.Message}";
        }

        /// <summary>
        /// Display Custome Error message without displaying "Exception" as "Error \n{ErrMessage}" format
        /// Text color will be in red
        /// </summary>
        /// <param name="ErrMessage">Use to pass the Custom Error Message (data type should be "String")</param>
        private void ErrorMessage(string ErrMessage)
        {
            labelMessage.ForeColor = Color.Red;
            labelMessage.Text = $"Error \n{ErrMessage}";
        }


        /// <summary>
        /// Display Custom message in black
        /// </summary>
        /// <param name="dmsg">Use to pass any custom message (data type should be "string")</param>
        private void DisplayMessage(string dmsg)
        {
            labelMessage.ForeColor = Color.Black;
            labelMessage.Text = dmsg;
        }


        /// <summary>
        /// Clear the labelMessage (Empty Method)
        /// </summary>
        private void ClearMessage()
        {
            labelMessage.Text = "";
        }


        /// <summary>
        /// Display Success labelMessage in green
        /// </summary>
        /// <param name="msg">Use to pass the success message (data type should be "string")</param>
        private void SuccessMessage(string msg)
        {
            labelMessage.ForeColor = Color.DarkGreen;
            labelMessage.Text = msg;
        }

    }
}
