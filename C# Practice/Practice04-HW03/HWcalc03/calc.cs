using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWcalc03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((float)e.KeyChar < 48 || (float)e.KeyChar > 57) && (float)e.KeyChar != 8 && (float)e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                foreach (char D in InputBox2.Text)
                {
                    if (D == '.')
                        e.Handled = true;
                }
                foreach (char D in InputBox2.Text)
                {
                    if (D == '.')
                        e.Handled = true;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(InputBox1.Text);
            float b = Convert.ToSingle(InputBox2.Text);

            if (((Button)sender).Text == "+")
            {
                ResultBox3.Text = (a + b).ToString("0.####");
            }
            else if (((Button)sender).Text == "-")
            {
                ResultBox3.Text = (a - b).ToString("0.####");
            }
            else if (((Button)sender).Text == "x")
            {
                ResultBox3.Text = (a * b).ToString("0.####");
            }
            else
            {
                if (b == 0 || a == 0)
                {
                    MessageBox.Show("不可以等於零");
                }
                else
                {
                    ResultBox3.Text = (a / b).ToString("0.####");
                }
            }
        }
    }
}