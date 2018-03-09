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

namespace Practice06_Calc
{
    public partial class LittleCalc : Form
    {
        public LittleCalc()
        {
            InitializeComponent();
        }

        private double a;
        private double b;
        private double C;
        private double l;
        private int n;
        private string I;
        private string i;

        private void button0_Click(object sender, EventArgs e)
        {
            Button Num = (Button)sender;
            l = Convert.ToDouble(Num.Text);
            if (n > 0)
            {
                ViewBox.Text = "";
                n--;
                if (n < 1)
                {
                    ViewBox.Text += Num.Text;
                }
            }
            else
            {
                ViewBox.Text += Num.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ViewBox.Text.IndexOf(".") < 0)
            {
                ViewBox.Text = ViewBox.Text + ".";
            }
        }

        private void Translate_Click(object sender, EventArgs e)
        {
            if (double.Parse(ViewBox.Text) != 0)
            {
                int a = ViewBox.Text.IndexOf("-");
                if (ViewBox.Text.IndexOf("-") >= 0)
                {
                    ViewBox.Text = ViewBox.Text.Replace("-", "");
                }
                else
                {
                    ViewBox.Text = "-" + ViewBox.Text;
                }
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            Button CC = sender as Button;
            i = CC.Text;
            I = l.ToString();
            ViewBox.Text += CC.Text;
        }

        private void mathCalc()
        {
            a = Convert.ToDouble(I);
            b = Convert.ToDouble(l);

            switch (i)
            {
                case "+":
                    C = a + b;
                    break;

                case "-":
                    C = a - b;
                    break;

                case "X":
                    C = a * b;
                    break;

                case "÷":
                    C = a / b;
                    break;
            }
        }

        private void Equalbutton_Click(object sender, EventArgs e)
        {
            this.mathCalc();
            ResultBox.Text = C.ToString();
            n++;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ViewBox.Text = "";
            ResultBox.Text = "";
            i = "";
        }

        private void Bkspace_Click(object sender, EventArgs e)
        {
            if (ViewBox.Text.Length > 1)
            {
                if (ResultBox.Text.Length > 1)

                    ResultBox.Text = ResultBox.Text.Substring(0, ResultBox.Text.Length - 1);
                else
                    ViewBox.Text = ViewBox.Text.Substring(0, ViewBox.Text.Length - 1);
            }
            else
            {
                ViewBox.Text = "0";
                ResultBox.Text = "";
            }
        }

        private void Root_Click(object sender, EventArgs e)
        {
            a = double.Parse(ViewBox.Text);
            if (((Button)sender).Text == "√")
            {
                double Sqrt = Math.Sqrt(a);
                ResultBox.Text = Sqrt.ToString();
            }
        }
    }
}