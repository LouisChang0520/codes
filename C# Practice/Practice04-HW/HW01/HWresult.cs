using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace HW01
{
    public class HWresult
    {
        #region 初始化場景

        public HWresult(int id)
        {
            this.Id = id;
        }

        #endregion 初始化場景

        #region HWresult欄位定義

        public int Id;
        public Button HWbutton1;
        public Button HWbutton2;
        public PictureBox HWpictureBox;
        public Label RUNresult;

        #endregion HWresult欄位定義

        #region HWresult公用方法

        public Image GetImage()
        {
            if (this.Id == 1)
            {
                return global::HW01.Properties.Resources._01;
            }
            else
            {
                return global::HW01.Properties.Resources._02;
            }
        }

        #region 結果更換方法

        public void ChangeTo(int id)
        {
            this.Id = id;
            this.Render();
            this.ShowLabel();
        }

        #endregion 結果更換方法

        #region 照片更換方式

        public void Render()
        {
            HWbutton1.Text = "作業01";

            HWbutton2.Text = "作業02";

            this.HWpictureBox.Image = this.GetImage();
        }

        #endregion 照片更換方式

        #region Label結果運算

        public void ShowLabel()
        {
            if (this.Id == 1)
            {
                String a = "";
                Char[] aend = { '+' };
                int sum = 0;
                for (int i = 1; i <= 100; ++i)
                {
                    sum += i;
                    a += i + "+";
                }
                String Newa = a.TrimEnd(aend);
                RUNresult.Text = (Newa + "=" + sum);
            }
            else
            {
                String b = "";
                Char[] bEnd = { '+' };

                for (int j = 0, c = 0; j <= 1000; j = j + 3)
                {
                    if (j > 50)
                    {
                        j = j - 50;
                    }
                    if ((j % 7) == 0)
                    {
                        if (j > 0)
                        {
                            j = j + 1;
                        }
                    }
                    c++;
                    if (c > 50)
                    {
                        break;
                    }
                    b += j + "+";
                    String Newb = b.TrimEnd(bEnd);
                    RUNresult.Text = Newb + "\n" + "數字數量總共為" + "=" + c.ToString();
                }
            }
        }

        #endregion Label結果運算
    }

    #endregion HWresult公用方法
}