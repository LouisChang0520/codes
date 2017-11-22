namespace Practice001
{
    partial class Form1
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
            this.buttom1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.TextBox();
            this.box2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttom1
            // 
            this.buttom1.AutoSize = true;
            this.buttom1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttom1.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttom1.Location = new System.Drawing.Point(384, 341);
            this.buttom1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttom1.Name = "buttom1";
            this.buttom1.Size = new System.Drawing.Size(221, 159);
            this.buttom1.TabIndex = 0;
            this.buttom1.Text = "比較";
            this.buttom1.UseVisualStyleBackColor = false;
            this.buttom1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(428, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "數值";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.box1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.box1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.box1.Location = new System.Drawing.Point(212, 220);
            this.box1.Multiline = true;
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(116, 100);
            this.box1.TabIndex = 2;
            this.box1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.box2.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.box2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.box2.Location = new System.Drawing.Point(641, 220);
            this.box2.Multiline = true;
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(123, 100);
            this.box2.TabIndex = 3;
            this.box2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 663);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttom1);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttom1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.TextBox box2;
    }
}

