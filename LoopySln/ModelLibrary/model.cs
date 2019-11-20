using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelLibrary
{
    public class Model
    {
        public string getInput { get; set; }
        public string getVarName { get; set; }
        public string getBehavior { get; set; }
        public int getFrom { get; set; }
        public int getTo { get; set; }
        public bool getCheckbox { get; set; }
        public string getVarNameSec { get; set; }
        public int getFromSec { get; set; }

        public string GenerateOutput()
        {
            StringBuilder sbOut = new StringBuilder();

            while (this.getFrom <= this.getTo)
            {
                string strOut = this.getInput.Replace(this.getVarName, this.getFrom.ToString());
                if (getCheckbox)
                {
                    strOut = strOut.Replace(this.getVarNameSec, this.getFromSec.ToString());
                }
                sbOut.Append(strOut);
                sbOut.Append(Environment.NewLine);

                if (getBehavior == "Increment")
                {
                    this.getFrom++;
                    if (getCheckbox)
                    {
                        this.getFromSec--;
                    }  
                }
                else
                {
                    this.getFrom--;
                    if (getCheckbox)
                    {
                        this.getFromSec++;
                    }  
                }

            }

            return sbOut.ToString();
        }

    }
}
