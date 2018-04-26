using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtherCalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int Fn;
        private long i;

        private void Transbutton_Click(object sender, EventArgs e)
        {
            Fn = Convert.ToInt32(InputBox.Text);
            long[] Fs = new long[Fn];
            Fs[0] = 1;
            Fs[1] = 1;
            if (Fn < 3)
            {
                Result.Text = 1.ToString();
            }
            else
            {
                for (i = 2; i < Fn; i++)
                {
                    Fs[i] = Fs[i - 1] + Fs[i - 2];
                }
                Result.Text = Fs[Fn - 1].ToString();
            }
        }
    }
}