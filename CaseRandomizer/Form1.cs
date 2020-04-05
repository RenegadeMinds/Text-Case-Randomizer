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
            // Initialize the dictionary with all the values we are using. 
            InitializeHomoglyphs();
        }

        // Keep this global. More random that way. 
        Random r = new Random();

        // Stuff in here should properly be spun out on a thread, but whatever. 
        // It won't make any difference unless people do HUGE chunks of text. 
        private void btnRandomizeCase_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length < 1 || (!chkHomoglyphs.Checked && !chkRandomizeCase.Checked))
                return;

            char[] array = txtInput.Text.ToCharArray();
            StringBuilder sb = new StringBuilder();

            // For stats. Not actually accurate because not examining if it's a number, etc., which has no case. For fun.
            decimal upper = 0;
            decimal lower = 0;

            foreach (char c in array)
            {
                string s = c.ToString();
                int rand = r.Next(0, 2);

                // Check if we're doing case randomization.
                if (chkRandomizeCase.Checked)
                {
                    if (rand == 0)
                    {
                        s = s.ToUpper();
                        upper++;
                    }
                    else
                    {
                        s = s.ToLower();
                        lower++;
                    }
                }

                // Check if we're doing homoglyphs. 
                if (chkHomoglyphs.Checked)
                    s = GetHomoglyph(s);

                sb.Append(s);
            }

            txtOutput.Text = sb.ToString();
            if (chkRandomizeCase.Checked)
            {
                decimal d = (lower / (upper + lower)) * 100;
                decimal u = (upper / (upper + lower)) * 100;
                lblCounts.Text = "Upper = " + upper.ToString() + ", Lower = " + lower.ToString() + ", " + d.ToString("#0") + "% lower, " + u.ToString("#0") + "% upper";
            }
            else
            {
                lblCounts.Text = string.Empty;
            }
        }


        // Would be nice to have fewer long consecutive runs of a case. 
        // Should build a new method to make it more likely or less likely for a case
        // depending upon the previous 1 or more cases.
        // Maybe +/-10% per consecutive previous case, e.g. 4 consecutive previous
        // lower case would then be 90% chance of upper case next. 
        // This would make 5 consecutive impossible
        // 2020-04-04

        // This holds our dictionary of homoglyphs.
        Dictionary<string, string[]> homoglyphs = new Dictionary<string, string[]>();

        /// <summary>
        /// Get a homoglyph for a single character passed as a string.
        /// </summary>
        /// <param name="glyph">A single character passed as a string.</param>
        /// <returns>A random homoglyph for a character passed as a string.</returns>
        private string GetHomoglyph(string glyph)
        {
            string result = string.Empty;

           // Testing code to output glyphs - uncomment then run to see them all.
           //StringBuilder sb = new StringBuilder();
           // foreach (var v in dic)
           // {
           //     sb.Append(v.Key + "\t");
           //     foreach (var w in v.Value)
           //     {
           //         sb.Append(w + ", ");
           //     }
           //     sb.Append(Environment.NewLine);
           // }
           // txtInput.Text = sb.ToString();

            #region Choose glyph
            switch (glyph)
            {
                case "-":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case ".":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "0":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "1":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "2":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "3":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "4":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "5":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "6":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "7":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "8":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "9":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "A":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "B":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "C":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "D":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "E":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "F":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "G":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "H":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "I":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "J":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "K":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "L":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "M":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "N":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "O":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "P":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "Q":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "R":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "S":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "T":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "U":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "V":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "W":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "X":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "Y":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "Z":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "a":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "b":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "c":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "d":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "e":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "f":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "g":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "h":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "i":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "j":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "k":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "l":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "m":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "n":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "o":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "p":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "q":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "r":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "s":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "t":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "u":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "v":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "w":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "x":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "y":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                case "z":
                    if (homoglyphs.ContainsKey(glyph))
                    {
                        int idx = r.Next(0, homoglyphs[glyph].Length);
                        result = homoglyphs[glyph][idx];
                    }
                    break;

                default:
                    result = glyph;
                    break;
            }
            #endregion

            return result;
        }

        /// <summary>
        /// Initializes our dictionary of homoglyphs as a Dictionary<string, string[]>. 
        /// If you add more characters to this list, you must then also update the "Choose glyph" region in the GetHomoglyph method.
        /// TODO: Add in ascii characters as options, i.e. a character may not change then.
        /// </summary>
        private void InitializeHomoglyphs()
        {
            #region Add homoglyphs

            homoglyphs.Add("-", new string[] { "\u2cba", "\ufe58", "\u2043", "\u2212", "\u2011", "\u2012", "\u2796", "\u2013", "\u02d7", "\u06d4", "\u2010" });
            homoglyphs.Add(".", new string[] { "\ua4f8", "\u06f0", "\u2024", "\uff0e", "\u0702", "\u0701", "\ua60e", "\u0660" });
            homoglyphs.Add("0", new string[] { "\u2c9f", "\ufba6", "\ua4f3", "\u0555", "\u10ff", "\u0665", "\u0966", "\u041e", "\uff2f", "\u0b66", "\u0585", "\u0647", "\u0d20", "\u0ed0", "\u0c66", "\u3007", "\u09e6", "\u1d11", "\u0b20", "\uab3d", "\u03bf", "\u0d66", "\u2134", "\uff4f", "\u1d0f", "\u043e", "\uff10", "\u0ce6", "\u2c9e", "\u2d54", "\u1040", "\u0be6", "\u101d", "\u0ae6", "\u006f", "\u039f", "\u0a66", "\u03c3", "\u12d0" });
            homoglyphs.Add("1", new string[] { "\u0406", "\uff4c", "\u05c0", "\u217c", "\u05df", "\u01c0", "\ufe8d", "\u2110", "\ua4f2", "\u07ca", "\u0627", "\u2d4f", "\u2160", "\uffe8", "\u2111", "\u2223", "\u04c0", "\u0049", "\u0196", "\u16c1", "\uff29", "\u2113", "\u2c92", "\u0399", "\ufe8e", "\uff11", "\u06f1", "\u007c", "\u05d5", "\u006c", "\u0661", });
            homoglyphs.Add("2", new string[] { "\ua644", "\u14bf", "\uff12", "\u03e8", "\u01a7", });
            homoglyphs.Add("3", new string[] { "\u04e0", "\u021c", "\u0417", "\u01b7", "\uff13", "\ua76a", "\ua7ab", "\u2ccc", });
            homoglyphs.Add("4", new string[] { "\uff14", "\u13ce" });
            homoglyphs.Add("5", new string[] { "\uff15", "\u01bc", });
            homoglyphs.Add("6", new string[] { "\u2cd2", "\u0431", "\u13ee", "\uff16", });
            homoglyphs.Add("7", new string[] { "\uff17", });
            homoglyphs.Add("8", new string[] { "\u0223", "\u0a6a", "\u0222", "\uff18", "\u09ea", });
            homoglyphs.Add("9", new string[] { "\ua76e", "\u09ed", "\u0b68", "\uff19", "\u2cca", "\u0a67", "\u0d6d", });
            homoglyphs.Add("A", new string[] { "\u0410", "\ua4ee", "\u15c5", "\uff21", "\u1d00", "\u0391", "\u13aa", "\uab7a" });
            homoglyphs.Add("B", new string[] { "\u0412", "\u13fc", "\u212c", "\u16d2", "\ua4d0", "\ua7b4", "\u15f7", "\u13f4", "\u0392", "\u0299", "\u0432", "\uff22", });
            homoglyphs.Add("C", new string[] { "\u0421", "\u03f9", "\ua4da", "\uff23", "\u2ca4", "\u216d", "\u13df", "\u2102", "\u212d" });
            homoglyphs.Add("D", new string[] { "\u13a0", "\uab70", "\u216e", "\u2145", "\u15ea", "\u15de", "\ua4d3", "\u1d05", "\uff24", });
            homoglyphs.Add("E", new string[] { "\u22ff", "\u0415", "\u2d39", "\u0395", "\uab7c", "\ua4f0", "\u2130", "\u13ac", "\u1d07", "\uff25" });
            homoglyphs.Add("F", new string[] { "\u15b4", "\u2131", "\uff26", "\u03dc", "\ua4dd", "\ua798", });
            homoglyphs.Add("G", new string[] { "\u13c0", "\u13fb", "\u0262", "\uab90", "\u050c", "\u13f3", "\u050d", "\ua4d6", "\uff27", });
            homoglyphs.Add("H", new string[] { "\uff28", "\u210d", "\u13bb", "\u2c8e", "\ua4e7", "\u0397", "\u157c", "\u210b", "\u029c", "\u041d", "\uab8b", "\u210c", "\u043d", });
            homoglyphs.Add("I", new string[] { "\u0406", "\uff4c", "\u05c0", "\u217c", "\u05df", "\u01c0", "\ufe8d", "\u2110", "\ua4f2", "\u07ca", "\u0627", "\u2d4f", "\u2160", "\uffe8", "\u0031", "\u2111", "\u2223", "\u04c0", "\u0196", "\u16c1", "\uff29", "\u2113", "\u2c92", "\u0399", "\ufe8e", "\uff11", "\u06f1", "\u007c", "\u05d5", "\u006c", "\u0661", });
            homoglyphs.Add("J", new string[] { "\ua4d9", "\ua7b2", "\u1d0a", "\uab7b", "\u13ab", "\uff2a", "\u037f", "\u148d", "\u0408", });
            homoglyphs.Add("K", new string[] { "\u039a", "\u2c94", "\u041a", "\uff2b", "\ua4d7", "\u16d5", "\u212a", "\u13e6" });
            homoglyphs.Add("L", new string[] { "\u029f", "\uabae", "\u2cd0", "\u216c", "\u14aa", "\uff2c", "\ua4e1", "\u2112", "\u2cd1", "\u13de" });
            homoglyphs.Add("M", new string[] { "\u16d6", "\u2c98", "\u041c", "\u15f0", "\u03fa", "\u039c", "\uff2d", "\u216f", "\u2133", "\u13b7", "\ua4df" });
            homoglyphs.Add("N", new string[] { "\uff2e", "\u2115", "\ua4e0", "\u0274", "\u2c9a", "\u039d", });
            homoglyphs.Add("O", new string[] { "\u2c9f", "\ufba6", "\ua4f3", "\u0555", "\u10ff", "\u0665", "\u0966", "\u041e", "\uff2f", "\u0b66", "\u0585", "\u0647", "\u0d20", "\u0ed0", "\u0c66", "\u3007", "\u09e6", "\u1d11", "\u0b20", "\uab3d", "\u03bf", "\u0d66", "\u2134", "\uff4f", "\u1d0f", "\u043e", "\uff10", "\u0ce6", "\u2c9e", "\u2d54", "\u1040", "\u0be6", "\u101d", "\u0ae6", "\u006f", "\u039f", "\u0a66", "\u03c3", "\u12d0" });
            homoglyphs.Add("P", new string[] { "\u03a1", "\ua4d1", "\u1d29", "\u146d", "\u0420", "\uabb2", "\u13e2", "\u1d18", "\u2ca2", "\u2119", "\uff30", });
            homoglyphs.Add("Q", new string[] { "\uff31", "\u2d55", "\u211a", });
            homoglyphs.Add("R", new string[] { "\u0280", "\u13d2", "\u16b1", "\uab71", "\uaba2", "\u1587", "\u211c", "\u01a6", "\u211b", "\ua4e3", "\u211d", "\u13a1", "\uff32" });
            homoglyphs.Add("S", new string[] { "\u13da", "\u13d5", "\uff33", "\u054f", "\u0405", "\ua4e2", });
            homoglyphs.Add("T", new string[] { "\u22a4", "\u2ca6", "\u13a2", "\u03c4", "\uab72", "\u1d1b", "\u0442", "\u27d9", "\u03a4", "\uff34", "\u0422", "\ua4d4", });
            homoglyphs.Add("U", new string[] { "\u054d", "\u222a", "\ua4f4", "\u144c", "\u1200", "\u22c3", "\uff35" });
            homoglyphs.Add("V", new string[] { "\u2d38", "\ua4e6", "\u142f", "\u0474", "\u13d9", "\uff36", "\u2164", "\u0667", "\u06f7", });
            homoglyphs.Add("W", new string[] { "\u13b3", "\u13d4", "\ua4ea", "\uff37", "\u051c", });
            homoglyphs.Add("X", new string[] { "\u166d", "\u2573", "\uff38", "\u2169", "\u2d5d", "\u2cac", "\ua4eb", "\u0425", "\u16b7", "\u03a7", "\ua7b3", });
            homoglyphs.Add("Y", new string[] { "\ua4ec", "\u13bd", "\u0423", "\u04ae", "\u2ca8", "\u03d2", "\u13a9", "\uff39", "\u03a5", });
            homoglyphs.Add("Z", new string[] { "\ua4dc", "\u0396", "\u13c3", "\u2124", "\uff3a", "\u2128" });
            homoglyphs.Add("a", new string[] { "\u237a", "\u03b1", "\u0430", "\u0251", "\uff41", });
            homoglyphs.Add("b", new string[] { "\u15af", "\u0184", "\u1472", "\u13cf", "\uff42", "\u042c", });
            homoglyphs.Add("c", new string[] { "\u2ca5", "\uabaf", "\u1d04", "\u217d", "\u0441", "\uff43", "\u03f2", });
            homoglyphs.Add("d", new string[] { "\uff44", "\u13e7", "\ua4d2", "\u0501", "\u2146", "\u146f", "\u217e", });
            homoglyphs.Add("e", new string[] { "\u04bd", "\u2147", "\u212e", "\u0435", "\uab32", "\u212f", "\uff45", });
            homoglyphs.Add("f", new string[] { "\ua799", "\u0584", "\u017f", "\u03dd", "\uff46", "\u1e9d", "\uab35" });
            homoglyphs.Add("g", new string[] { "\u0261", "\u1d83", "\u0581", "\u210a", "\uff47", "\u018d", });
            homoglyphs.Add("h", new string[] { "\u0570", "\u210e", "\uff48", "\u04bb", "\u13c2", });
            homoglyphs.Add("i", new string[] { "\u2148", "\u0131", "\uff49", "\u0456", "\u2170", "\u0269", "\u04cf", "\ua647", "\u2373", "\uab75", "\u13a5", "\u026a", "\u03b9" });
            homoglyphs.Add("j", new string[] { "\u03f3", "\uff4a", "\u0458", "\u2149", });
            homoglyphs.Add("k", new string[] { "\uff4b", });
            homoglyphs.Add("l", new string[] { "\u0406", "\uff4c", "\u05c0", "\u217c", "\u05df", "\u01c0", "\ufe8d", "\u2110", "\ua4f2", "\u07ca", "\u0627", "\u2d4f", "\u2160", "\uffe8", "\u0031", "\u2111", "\u2223", "\u04c0", "\u0049", "\u0196", "\u16c1", "\uff29", "\u2113", "\u2c92", "\u0399", "\ufe8e", "\uff11", "\u06f1", "\u007c", "\u05d5", "\u0661", });
            homoglyphs.Add("m", new string[] { "\uff4d" });
            homoglyphs.Add("n", new string[] { "\uff4e", "\u057c", "\u0578", });
            homoglyphs.Add("o", new string[] { "\u2c9f", "\ufba6", "\ua4f3", "\u0555", "\u10ff", "\u0665", "\u0966", "\u041e", "\uff2f", "\u0b66", "\u0585", "\u0647", "\u0d20", "\u0ed0", "\u0c66", "\u3007", "\u09e6", "\u1d11", "\u0b20", "\uab3d", "\u03bf", "\u0d66", "\u2134", "\uff4f", "\u1d0f", "\u043e", "\uff10", "\u0ce6", "\u2c9e", "\u2d54", "\u1040", "\u0be6", "\u101d", "\u0ae6", "\u006f", "\u039f", "\u0a66", "\u03c3", "\u12d0" });
            homoglyphs.Add("p", new string[] { "\u03c1", "\u0440", "\u2374", "\u03f1", "\uff50", "\u2ca3", });
            homoglyphs.Add("q", new string[] { "\u0566", "\u051b", "\u0563", "\uff51" });
            homoglyphs.Add("r", new string[] { "\uab47", "\u1d26", "\uab48", "\u0433", "\u2c85", "\uab81", "\uff52", });
            homoglyphs.Add("s", new string[] { "\u0455", "\uff53", "\u01bd", "\ua731", "\uabaa", });
            homoglyphs.Add("t", new string[] { "\uff54", });
            homoglyphs.Add("u", new string[] { "\uab52", "\u1d1c", "\u028b", "\ua79f", "\uab4e", "\uff55", "\u057d", "\u03c5", });
            homoglyphs.Add("v", new string[] { "\u05d8", "\uaba9", "\u03bd", "\u0475", "\u22c1", "\uff56", "\u2174", "\u2228", "\u1d20", });
            homoglyphs.Add("w", new string[] { "\u0461", "\u026f", "\u0561", "\uab83", "\uff57", "\u1d21", "\u051d", });
            homoglyphs.Add("x", new string[] { "\u157d", "\u166e", "\uff58", "\u2a2f", "\u0445", "\u292c", "\u00d7", "\u1541", "\u2179", "\u292b", });
            homoglyphs.Add("y", new string[] { "\u0443", "\u0263", "\u213d", "\u04af", "\u1d8c", "\uab5a", "\u028f", "\u03b3", "\uff59", "\u1eff", "\u10e7", });
            homoglyphs.Add("z", new string[] { "\u1d22", "\uab93", "\uff5a", });
            #endregion
        }

    }
}
