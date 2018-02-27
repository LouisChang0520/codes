namespace HW01
{
    partial class HomeWorkList
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
            this.HWbutton1 = new System.Windows.Forms.Button();
            this.HWbutton2 = new System.Windows.Forms.Button();
            this.HWpictureBox = new System.Windows.Forms.PictureBox();
            this.RUNresult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HWpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HWbutton1
            // 
            this.HWbutton1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HWbutton1.Location = new System.Drawing.Point(584, 45);
            this.HWbutton1.Name = "HWbutton1";
            this.HWbutton1.Size = new System.Drawing.Size(305, 101);
            this.HWbutton1.TabIndex = 1;
            this.HWbutton1.Text = "作業01";
            this.HWbutton1.UseVisualStyleBackColor = true;
            this.HWbutton1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // HWbutton2
            // 
            this.HWbutton2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HWbutton2.Location = new System.Drawing.Point(584, 182);
            this.HWbutton2.Name = "HWbutton2";
            this.HWbutton2.Size = new System.Drawing.Size(305, 107);
            this.HWbutton2.TabIndex = 2;
            this.HWbutton2.Text = "作業02";
            this.HWbutton2.UseVisualStyleBackColor = true;
            this.HWbutton2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // HWpictureBox
            // 
            this.HWpictureBox.Image = global::HW01.Properties.Resources._01;
            this.HWpictureBox.Location = new System.Drawing.Point(14, 12);
            this.HWpictureBox.Name = "HWpictureBox";
            this.HWpictureBox.Size = new System.Drawing.Size(484, 297);
            this.HWpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HWpictureBox.TabIndex = 4;
            this.HWpictureBox.TabStop = false;
            // 
            // RUNresult
            // 
            this.RUNresult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RUNresult.Location = new System.Drawing.Point(14, 330);
            this.RUNresult.Name = "RUNresult";
            this.RUNresult.Size = new System.Drawing.Size(935, 298);
            this.RUNresult.TabIndex = 5;
            // 
            // HomeWorkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 637);
            this.Controls.Add(this.RUNresult);
            this.Controls.Add(this.HWpictureBox);
            this.Controls.Add(this.HWbutton2);
            this.Controls.Add(this.HWbutton1);
            this.Name = "HomeWorkList";
            this.Text = "HomeWorkList";
            ((System.ComponentModel.ISupportInitialize)(this.HWpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button HWbutton1;
        private System.Windows.Forms.Button HWbutton2;
        private System.Windows.Forms.PictureBox HWpictureBox;
        private System.Windows.Forms.Label RUNresult;
    }
}

