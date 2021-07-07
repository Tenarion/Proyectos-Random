using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        private static string PASSWORD_ALL = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*1234567890";
        private static string PASSWORD_LOW = "abcdefghijklmnopqrstuvwxyz";
        private static string PASSWORD_UP = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string PASSWORD_SYM = "!@#$%^&*";
        private static string PASSWORD_NUM = "1234567890";
        public Form1()
        {
            InitializeComponent();
        }
        private void checkHide_CheckedChanged(object sender, EventArgs e)
        {
            if (generatedPass.UseSystemPasswordChar != true)
            {
                generatedPass.UseSystemPasswordChar = true;
            }
            else if (generatedPass.UseSystemPasswordChar == true)
            {
                generatedPass.UseSystemPasswordChar = false;
            }
        }

        private void includePass(object sender, EventArgs e)
        {
            if (!check1.Checked)
            {
                PASSWORD_ALL = Regex.Replace(PASSWORD_ALL, @"[0-9]", "");
            }
            if (!check2.Checked)
            {
                PASSWORD_ALL = Regex.Replace(PASSWORD_ALL, @"[^0-9a-zA-Z]+", "");
            }
            if (!check3.Checked)
            {
                PASSWORD_ALL = Regex.Replace(PASSWORD_ALL, @"[a-z]", "");
            }
            if (!check4.Checked)
            {
                PASSWORD_ALL = Regex.Replace(PASSWORD_ALL, @"[A-Z]", "");
            }
            if (!check5.Checked)
            {
                lengthPass.Enabled = true;
            }
            if (check1.Checked)
            {
                PASSWORD_ALL += PASSWORD_NUM;
            }
            if (check2.Checked)
            {
                PASSWORD_ALL += PASSWORD_SYM;
            }
            if (check3.Checked)
            {
                PASSWORD_ALL += PASSWORD_LOW;
            }
            if (check4.Checked)
            {
                PASSWORD_ALL += PASSWORD_UP;
            }
            if (check5.Checked)
            {
                lengthPass.Enabled = false;
            }
        }
        private void PasswordGenerator(object sender, EventArgs e)
        {
            int value = (int)lengthPass.Value;
            StringBuilder gen = new StringBuilder();
            Random rnd = new Random();

            if (lengthPass.Enabled == false)
            {
                Random rndo = new Random();
                int val = rndo.Next(8, 24);
                while (0 < val--)
                {
                    if (!check1.Checked && !check2.Checked && !check3.Checked && !check4.Checked && !check5.Checked || check5.Checked && !check1.Checked && !check2.Checked && !check3.Checked && !check4.Checked)
                    {
                        errorProvider1.SetError(panel1, "You must check at least one box.");
                    }
                    else
                    {
                        gen.Append(PASSWORD_ALL[rnd.Next(PASSWORD_ALL.Length)]);
                    }
                    generatedPass.Text = gen.ToString();
                }
            }
            else
            {
                
                while (0 < value--)
                {
                    if (!check1.Checked && !check2.Checked && !check3.Checked && !check4.Checked && !check5.Checked || check5.Checked && !check1.Checked && !check2.Checked && !check3.Checked && !check4.Checked)
                    {
                        errorProvider1.SetError(panel1, "You must check at least one box.");
                    }
                    else
                    {
                        gen.Append(PASSWORD_ALL[rnd.Next(PASSWORD_ALL.Length)]);
                    }
                    generatedPass.Text = gen.ToString();
                }
                               
            }
        }

        private void copyClipboard(object sender, EventArgs e)
        {
            if (generatedPass.Text != string.Empty)
            {
                Clipboard.SetText(generatedPass.Text);
            }
        }
    }
}
