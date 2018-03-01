namespace HWcalc03
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
            this.InputBox1 = new System.Windows.Forms.TextBox();
            this.InputBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Subbutton = new System.Windows.Forms.Button();
            this.Multibutton = new System.Windows.Forms.Button();
            this.Divbutton = new System.Windows.Forms.Button();
            this.ResultBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputBox1
            // 
            this.InputBox1.CausesValidation = false;
            this.InputBox1.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InputBox1.Location = new System.Drawing.Point(98, 71);
            this.InputBox1.Multiline = true;
            this.InputBox1.Name = "InputBox1";
            this.InputBox1.Size = new System.Drawing.Size(171, 156);
            this.InputBox1.TabIndex = 0;
            this.InputBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputBox1_KeyPress);
            // 
            // InputBox2
            // 
            this.InputBox2.CausesValidation = false;
            this.InputBox2.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InputBox2.Location = new System.Drawing.Point(487, 71);
            this.InputBox2.Multiline = true;
            this.InputBox2.Name = "InputBox2";
            this.InputBox2.Size = new System.Drawing.Size(171, 156);
            this.InputBox2.TabIndex = 1;
            this.InputBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputBox1_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(98, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(560, 33);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "四則運算,請輸入數字";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Addbutton
            // 
            this.Addbutton.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Addbutton.Location = new System.Drawing.Point(275, 71);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(100, 72);
            this.Addbutton.TabIndex = 3;
            this.Addbutton.Text = "+";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Subbutton
            // 
            this.Subbutton.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Subbutton.Location = new System.Drawing.Point(382, 71);
            this.Subbutton.Name = "Subbutton";
            this.Subbutton.Size = new System.Drawing.Size(100, 72);
            this.Subbutton.TabIndex = 4;
            this.Subbutton.Text = "-";
            this.Subbutton.UseVisualStyleBackColor = true;
            this.Subbutton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Multibutton
            // 
            this.Multibutton.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Multibutton.Location = new System.Drawing.Point(275, 155);
            this.Multibutton.Name = "Multibutton";
            this.Multibutton.Size = new System.Drawing.Size(100, 72);
            this.Multibutton.TabIndex = 5;
            this.Multibutton.Text = "x";
            this.Multibutton.UseVisualStyleBackColor = true;
            this.Multibutton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Divbutton
            // 
            this.Divbutton.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Divbutton.Location = new System.Drawing.Point(382, 155);
            this.Divbutton.Name = "Divbutton";
            this.Divbutton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Divbutton.Size = new System.Drawing.Size(100, 72);
            this.Divbutton.TabIndex = 6;
            this.Divbutton.Text = "/";
            this.Divbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Divbutton.UseVisualStyleBackColor = true;
            this.Divbutton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ResultBox3
            // 
            this.ResultBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ResultBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultBox3.Font = new System.Drawing.Font("微軟正黑體", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ResultBox3.Location = new System.Drawing.Point(98, 252);
            this.ResultBox3.Multiline = true;
            this.ResultBox3.Name = "ResultBox3";
            this.ResultBox3.Size = new System.Drawing.Size(560, 313);
            this.ResultBox3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 608);
            this.Controls.Add(this.ResultBox3);
            this.Controls.Add(this.Divbutton);
            this.Controls.Add(this.Multibutton);
            this.Controls.Add(this.Subbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.InputBox2);
            this.Controls.Add(this.InputBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox1;
        private System.Windows.Forms.TextBox InputBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Subbutton;
        private System.Windows.Forms.Button Multibutton;
        private System.Windows.Forms.Button Divbutton;
        private System.Windows.Forms.TextBox ResultBox3;
    }
}

