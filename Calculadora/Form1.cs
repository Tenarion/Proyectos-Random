using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public static string op;
        public static double N1;
        public static double N2;
        public static double res;
        public Form1()
        {
            InitializeComponent();
        }
        //Función básica de los botones
        private void onClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (output.Text)
            {
                case "ERROR":
                case "NaN":
                    output.Text = "0";
                    break;
                case "0":
                    output.Text = btn.Text;
                    break;
                default:
                    output.Text += btn.Text;
                    break;
            }

           
        }
        //Operadores
        private void onClickOp(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            op = btn.Text;
            bool Try = double.TryParse(output.Text, out N1);
            if (sender == bres)
            {
                if (output.Text == "0")
                {
                    output.Text = "-";
                }
                else
                {
                    output.Text = "";
                }
            }
            else
            {
                output.Text = "";
            }
            if (Try == false)
            {
                output.Text = "ERROR";
                N1 = N2 = res = 0;
            }
        }
        //Dar el resultado de los números dados
        private void onClickEqual(object sender, EventArgs e)
        {
            bool Try = double.TryParse(output.Text, out  N2);
            if (Try == false)
            {
                output.Text = "ERROR";
                N1 = N2 = res = 0;
            }
            else
            {
                switch (op)
                {
                    case "+":
                        output.Text = Convert.ToString(N1 + N2);
                        res = N1 + N2;
                        break;
                    case "-":
                        output.Text = Convert.ToString(N1 - N2);
                        res = N1 - N2;
                        break;
                    case "/":
                        output.Text = Convert.ToString(N1 / N2);
                        res = N1 / N2;
                        break;
                    case "x":
                        output.Text = Convert.ToString(N1 * N2);
                        res = N1 * N2;
                        break;
                }
            }
        }
        //De aquí a abajo son los botones especiales
        private void bsumres_Click(object sender, EventArgs e)
        {

            res *= -1;
            output.Text = Convert.ToString(res);
        }

        private void beraseE_Click(object sender, EventArgs e)
        {
            output.Text = "0";
            N1 = N2 = res = 0;           
        }

        private void berase_Click(object sender, EventArgs e)
        {
            output.Text = "0";
        }

        private void beraseO_Click(object sender, EventArgs e)
        {
            if (output.Text != "0")
            {
                output.Text = output.Text.Remove(output.Text.Length - 1);
            }
            if (output.Text == "")
            {
                output.Text = "0";
            }
        }

        private void onClickColor(object sender, EventArgs e)
        {
        }
        }
    }                                
                      
                      