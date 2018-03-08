using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Practice06_Calc
{
    public partial class LittleCalc : Form
    {
        public LittleCalc()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            //if (ResultBox.Text == "0")
            //{
            //    ResultBox.Text = "";
            //}
            //ResultBox.Text += ((Button)sender).Text;
            Button Num = (Button)sender;
            ResultBox.Text += Num.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text.IndexOf(".") < 0)
            {
                ResultBox.Text = ResultBox.Text + ".";
            }
        }

        private void Translate_Click(object sender, EventArgs e)
        {
            if (double.Parse(ResultBox.Text) != 0)
            {
                int a = ResultBox.Text.IndexOf("-");
                if (ResultBox.Text.IndexOf("-") >= 0)
                {
                    ResultBox.Text = ResultBox.Text.Replace("-", "");
                }
                else
                {
                    ResultBox.Text = "-" + ResultBox.Text;
                }
            }
        }

        public double A;
        private string I;
        private string i;

        private void Addbutton_Click(object sender, EventArgs e)
        {
            //a = double.Parse(ResultBox.Text);
            //ResultBox.Text = a.ToString();
            //i = ((Button)sender).Tag.ToString();
            Button CC = sender as Button;
            if (!(ResultBox.Text == ""))
            {
                i = CC.Text;
                I = ResultBox.Text;
            }
        }

        private void Equalbutton_Click(object sender, EventArgs e)
        {
            double a = double.Parse(I);
            double b = double.Parse(ResultBox.Text);
            double c = 0;
            switch (i)
            {
                case "+":
                    c = a + b;
                    break;

                case "-":
                    c = a - b;
                    break;

                case "X":
                    c = a * b;
                    break;

                case "÷":
                    c = a / b;
                    break;
            }
            ResultBox.Text = c.ToString();
            //a = c;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
            A = 0;
            i = "";
        }

        private void Bkspace_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text.Length > 1)
            {
                ResultBox.Text = ResultBox.Text.Substring(0, ResultBox.Text.Length - 1);
            }
            else
            {
                ResultBox.Text = "0";
            }
        }

        private void Root_Click(object sender, EventArgs e)
        {
            A = double.Parse(ResultBox.Text);
            if (((Button)sender).Text == "√")
            {
                double Sqrt = Math.Sqrt(A);
                ResultBox.Text = Sqrt.ToString();
            }
        }
    }
}