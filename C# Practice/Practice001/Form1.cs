using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1=Convert.ToInt32(box1.Text);
            int num2=Convert.ToInt32(box2.Text);
            if (num1 > num2)
            {
                label1.Text = "BIG";
            }
            else
            {
                label1.Text="SMALL";
            }
        }
    }
}
