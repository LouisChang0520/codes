namespace MainWindow
{
    partial class MainWindow
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.YESButton = new System.Windows.Forms.Button();
            this.NObutton = new System.Windows.Forms.Button();
            this.scenePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // YESButton
            // 
            this.YESButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YESButton.Location = new System.Drawing.Point(12, 435);
            this.YESButton.Name = "YESButton";
            this.YESButton.Size = new System.Drawing.Size(412, 112);
            this.YESButton.TabIndex = 1;
            this.YESButton.Text = "YES";
            this.YESButton.UseVisualStyleBackColor = true;
            this.YESButton.Click += new System.EventHandler(this.YESButton_Click);
            // 
            // NObutton
            // 
            this.NObutton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NObutton.Location = new System.Drawing.Point(514, 435);
            this.NObutton.Name = "NObutton";
            this.NObutton.Size = new System.Drawing.Size(435, 112);
            this.NObutton.TabIndex = 2;
            this.NObutton.Text = "NO";
            this.NObutton.UseVisualStyleBackColor = true;
            this.NObutton.Click += new System.EventHandler(this.NObutton_Click);
            // 
            // scenePictureBox
            // 
            this.scenePictureBox.Image = global::MainWindow.Properties.Resources._1;
            this.scenePictureBox.Location = new System.Drawing.Point(13, 13);
            this.scenePictureBox.Name = "scenePictureBox";
            this.scenePictureBox.Size = new System.Drawing.Size(936, 395);
            this.scenePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scenePictureBox.TabIndex = 0;
            this.scenePictureBox.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 555);
            this.Controls.Add(this.NObutton);
            this.Controls.Add(this.YESButton);
            this.Controls.Add(this.scenePictureBox);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox scenePictureBox;
        private System.Windows.Forms.Button YESButton;
        private System.Windows.Forms.Button NObutton;
    }
}

