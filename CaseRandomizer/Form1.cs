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

        Random r = new Random();

        private void btnRandomizeCase_Click(object sender, EventArgs e)
        {
            char[] array = txtInput.Text.ToCharArray();
            StringBuilder sb = new StringBuilder();
            foreach (char c in array)
            {
                if (r.Next(0, 2) == 0)
                {
                    sb.Append(c.ToString().ToUpper());
                }
                else {
                    sb.Append(c.ToString().ToLower());
                }

            }
            txtOutput.Text = sb.ToString();
        }
    }
}
