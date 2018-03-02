using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MainWindow
{
    public class Scene
    {
        #region 建構式: 用來初始化場景

        public Scene(int id, Button YESButton, Button NOButton, PictureBox pictureBox)
        {
            this.Id = id;
            this.YesButton = YESButton;
            this.NOButton = NOButton;
            this.ScenePictureBox = pictureBox;
            this.Render();
        }

        #endregion 建構式: 用來初始化場景

        #region Scene的欄位定義

        public int Id;
        public Button YesButton;
        public Button NOButton;
        public PictureBox ScenePictureBox;

        #endregion Scene的欄位定義

        #region Scene的公用方法

        public Image GetImage()
        {
            switch (this.Id)
            {
                case 1:
                    return global::MainWindow.Properties.Resources._1;
                    break;

                case 2:
                    return global::MainWindow.Properties.Resources._2;
                    break;

                case 3:
                    return global::MainWindow.Properties.Resources._3;
                    break;

                case 4:
                    return global::MainWindow.Properties.Resources._4;
                    break;

                case 5:
                    return global::MainWindow.Properties.Resources._5;
                    break;

                default:
                    return global::MainWindow.Properties.Resources._6;
                    break;
            }
            //if (this.Id == 1)
            //{
            //    return global::MainWindow.Properties.Resources._1;
            //}
            //else if (this.Id == 2)
            //{
            //    return global::MainWindow.Properties.Resources._2;
            //}
            //else if (this.Id == 3)
            //{
            //    return global::MainWindow.Properties.Resources._3;
            //}
            //else if (this.Id == 4)
            //{
            //    return global::MainWindow.Properties.Resources._4;
            //}
            //else if (this.Id == 5)
            //{
            //    return global::MainWindow.Properties.Resources._5;
            //}
            //else
            //{
            //    return global::MainWindow.Properties.Resources._6;
            //}
        }

        public void ChangeTo(int id)
        {
            this.Id = id;
            this.Render();
        }

        public void Render()
        {
            switch (this.Id)
            {
                case 1:
                    YesButton.Text = "試試看";
                    NOButton.Hide();
                    break;

                case 4:
                    YesButton.Text = "重新來一次";
                    NOButton.Hide();
                    break;

                default:
                    YesButton.Text = "Yes";
                    NOButton.Text = "No";
                    YesButton.Show();
                    NOButton.Show();
                    break;
            }
            //if (this.Id == 1)
            //{
            //    YesButton.Text = "試試看";
            //    NOButton.Hide();
            //}
            //else if (this.Id == 4)
            //{
            //    YesButton.Text = "重新來一次";
            //    NOButton.Hide();
            //}
            //else
            //{
            //    YesButton.Text = "Yes";
            //    NOButton.Text = "No";
            //    YesButton.Show();
            //    NOButton.Show();
            //}
            this.ScenePictureBox.Image = this.GetImage();
        }

        #endregion Scene的公用方法
    }
}