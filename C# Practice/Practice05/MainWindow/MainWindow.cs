using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindow
{
    public partial class MainWindow : Form
    {
        // 定義一個變數儲存 現在的場景
        private Scene currentScene;

        public MainWindow()
        {
            InitializeComponent();
            this.currentScene = new Scene(1, this.YESButton, this.NObutton, this.scenePictureBox);
        }

        private void MakeDecision(int decision)
        {
            switch (currentScene.Id)
            {
                case 1:
                    if (decision == 1)
                        currentScene.ChangeTo(2);
                    break;

                case 2:
                    if (decision == 1)
                        currentScene.ChangeTo(3);
                    else
                        currentScene.ChangeTo(4);
                    break;

                case 3:
                    if (decision == 1)
                        currentScene.ChangeTo(4);
                    else
                        currentScene.ChangeTo(5);
                    break;

                case 4:
                    currentScene.ChangeTo(1);
                    break;

                case 5:
                    currentScene.ChangeTo(6);
                    break;
            }
        }

        private void YESButton_Click(object sender, EventArgs e)
        {
            this.MakeDecision(1);
        }

        private void NObutton_Click(object sender, EventArgs e)
        {
            this.MakeDecision(2);
        }
    }
}