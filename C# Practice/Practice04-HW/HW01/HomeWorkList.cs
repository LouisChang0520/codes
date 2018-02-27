using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW01
{
    public partial class HomeWorkList : Form
    {
        private HWresult currentHWresult;

        public HomeWorkList()
        {
            InitializeComponent();
            this.currentHWresult = new HWresult(1);
            this.currentHWresult.HWbutton1 = this.HWbutton1;
            this.currentHWresult.HWbutton2 = this.HWbutton2;
            this.currentHWresult.HWpictureBox = this.HWpictureBox;
            this.currentHWresult.Render();
            this.currentHWresult.RUNresult = this.RUNresult;
            this.currentHWresult.ShowLabel();
        }

        #region 選擇場景

        private void MakeChoose(int choose)
        {
            if (currentHWresult.Id == 1)
            {
                if (choose == 2)
                {
                    currentHWresult.ChangeTo(2);
                }
            }
            else if (currentHWresult.Id == 2)
            {
                if (choose == 1)
                {
                    currentHWresult.ChangeTo(1);
                }
            }
        }

        #endregion 選擇場景

        private void Button1_Click(object sender, EventArgs e)
        {
            this.MakeChoose(1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.MakeChoose(2);
        }
    }
}