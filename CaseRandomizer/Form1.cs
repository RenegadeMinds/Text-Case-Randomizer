using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseRandomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Keep this global. More random that way. 
        Random r = new Random();

        private void btnRandomizeCase_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length < 1)
                return;

            char[] array = txtInput.Text.ToCharArray();
            StringBuilder sb = new StringBuilder();
            // For stats. Not actually accurate because not examining if it's a number, etc., which has no case. For fun.
            decimal upper = 0;
            decimal lower = 0;

            foreach (char c in array)
            {
                if (r.Next(0, 2) == 0) {
                    sb.Append(c.ToString().ToUpper());
                    upper++;
                }
                else {
                    sb.Append(c.ToString().ToLower());
                    lower++;
                }
            }

            txtOutput.Text = sb.ToString();
            decimal d = (lower / (upper + lower)) * 100;
            lblCounts.Text = "Upper = " + upper.ToString() + ", Lower = " + lower.ToString() + ", " + d.ToString("#0") + "% lower";
        }
    }
}
