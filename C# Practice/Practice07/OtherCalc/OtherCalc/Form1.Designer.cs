namespace OtherCalc
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.Transbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InputBox.Location = new System.Drawing.Point(41, 31);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(321, 97);
            this.InputBox.TabIndex = 0;
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Result.Location = new System.Drawing.Point(41, 200);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(321, 111);
            this.Result.TabIndex = 1;
            // 
            // Transbutton
            // 
            this.Transbutton.Location = new System.Drawing.Point(395, 31);
            this.Transbutton.Name = "Transbutton";
            this.Transbutton.Size = new System.Drawing.Size(119, 280);
            this.Transbutton.TabIndex = 2;
            this.Transbutton.Text = "Calc";
            this.Transbutton.UseVisualStyleBackColor = true;
            this.Transbutton.Click += new System.EventHandler(this.Transbutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 341);
            this.Controls.Add(this.Transbutton);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.InputBox);
            this.Name = "MainForm";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Transbutton;
    }
}

