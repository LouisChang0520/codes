﻿using System;
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
        private double u;
        private double c;
        private int n;
        private int N;
        private int m;
        private string I;
        private string i;

        private void button0_Click(object sender, EventArgs e)
        {
            Button Num = (Button)sender;
            ResultBox.Text += Num.Text;
            l = Convert.ToDouble(ResultBox.Text);

            N++;
            if (n > 0)
            {
                l = Convert.ToDouble(Num.Text);
                c = Convert.ToDouble(Num.Text);
                ViewBox.Text += "";
                ResultBox.Text = c.ToString();
                n--;
                if (n < 1)
                {
                    ResultBox.Text = l.ToString();
                }
            }
            else
            {
                if (m > 1)
                {
                    l = Convert.ToDouble(Num.Text);
                    ResultBox.Text = l.ToString();
                }
                else
                    ResultBox.Text = l.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (l.ToString().IndexOf(".") < 0)
            {
                ResultBox.Text = l.ToString() + ".";
            }
        }

        private void Translate_Click(object sender, EventArgs e)
        {
            if (double.Parse(ResultBox.Text) != 0)
            {
                int A = ResultBox.Text.IndexOf("-");
                if (A >= 0)
                {
                    ResultBox.Text = l.ToString().Replace("-", "");
                }
                else
                {
                    ResultBox.Text = "-" + l.ToString();
                }
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            Button CC = sender as Button;
            m++;
            if (ResultBox.Text == "")
            {
                ResultBox.Text = "";
            }
            else
            {
                u = Convert.ToDouble(ResultBox.Text);
                i = CC.Text;

                //Convert.ToDouble(I);

                //c = Convert.ToDouble(I);

                ResultBox.Text = "";
                if (m > 1)
                {
                    addCalc();
                    ResultBox.Text = C.ToString();
                }

                if (n > 0)
                {
                    ViewBox.Text += u + i;
                    n = 0;
                }
                else { ViewBox.Text += u + i; }
                I = u.ToString();
            }
        }

        private void addCalc()
        {
            a = Convert.ToDouble(I);
            b = Convert.ToDouble(u);
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
            ResultBox.Text = C.ToString();
            a = C;
        }

        private void mathCalc()
        {
            //a = Convert.ToDouble(I);
            b = Convert.ToDouble(ResultBox.Text);
            //b = Convert.ToDouble(u);
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

            ResultBox.Text = C.ToString();
            a = C;
        }

        private void Equalbutton_Click(object sender, EventArgs e)
        {
            u = Convert.ToDouble(ResultBox.Text);
            this.mathCalc();
            ResultBox.Text = C.ToString();
            m = 0;
            n++;
            if (u >= 0)
            {
                ViewBox.Text = "";
                ResultBox.Text = C.ToString();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ViewBox.Text = "";
            ResultBox.Text = "";
            i = "";
        }

        private void Bkspace_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text.Length > 0)
            {
                ResultBox.Text = ResultBox.Text.Substring(0, ResultBox.Text.Length - 1);
                if (ViewBox.Text.Length > 0 && ResultBox.Text.Length == 0)

                    ViewBox.Text = ViewBox.Text.Substring(0, ViewBox.Text.Length - 1);
            }
            else
            {
                ViewBox.Text = "";
                ResultBox.Text = "";
            }
        }

        private void Root_Click(object sender, EventArgs e)
        {
            a = double.Parse(ResultBox.Text);
            if (((Button)sender).Text == "√")
            {
                double Sqrt = Math.Sqrt(a);
                ResultBox.Text = Sqrt.ToString();
            }
        }
    }
}