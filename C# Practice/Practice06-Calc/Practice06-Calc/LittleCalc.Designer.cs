namespace Practice06_Calc
{
    partial class LittleCalc
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
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.button03 = new System.Windows.Forms.Button();
            this.button06 = new System.Windows.Forms.Button();
            this.button08 = new System.Windows.Forms.Button();
            this.button05 = new System.Windows.Forms.Button();
            this.button02 = new System.Windows.Forms.Button();
            this.Dotbutton = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button01 = new System.Windows.Forms.Button();
            this.button04 = new System.Windows.Forms.Button();
            this.button07 = new System.Windows.Forms.Button();
            this.button09 = new System.Windows.Forms.Button();
            this.Divbutton = new System.Windows.Forms.Button();
            this.Multibutton = new System.Windows.Forms.Button();
            this.Subbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Equalbutton = new System.Windows.Forms.Button();
            this.Translate = new System.Windows.Forms.Button();
            this.Root = new System.Windows.Forms.Button();
            this.Bkspace = new System.Windows.Forms.Button();
            this.ViewBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ResultBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ResultBox.Location = new System.Drawing.Point(-7, 63);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.Size = new System.Drawing.Size(360, 65);
            this.ResultBox.TabIndex = 0;
            this.ResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Clear
            // 
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Clear.Location = new System.Drawing.Point(14, 134);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(69, 46);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "AC";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button03
            // 
            this.button03.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button03.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button03.Location = new System.Drawing.Point(176, 336);
            this.button03.Name = "button03";
            this.button03.Size = new System.Drawing.Size(70, 60);
            this.button03.TabIndex = 2;
            this.button03.Text = "3";
            this.button03.UseVisualStyleBackColor = true;
            this.button03.Click += new System.EventHandler(this.button0_Click);
            // 
            // button06
            // 
            this.button06.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button06.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button06.Location = new System.Drawing.Point(176, 264);
            this.button06.Name = "button06";
            this.button06.Size = new System.Drawing.Size(70, 60);
            this.button06.TabIndex = 3;
            this.button06.Text = "6";
            this.button06.UseVisualStyleBackColor = true;
            this.button06.Click += new System.EventHandler(this.button0_Click);
            // 
            // button08
            // 
            this.button08.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button08.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button08.Location = new System.Drawing.Point(95, 192);
            this.button08.Name = "button08";
            this.button08.Size = new System.Drawing.Size(70, 60);
            this.button08.TabIndex = 4;
            this.button08.Text = "8";
            this.button08.UseVisualStyleBackColor = true;
            this.button08.Click += new System.EventHandler(this.button0_Click);
            // 
            // button05
            // 
            this.button05.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button05.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button05.Location = new System.Drawing.Point(95, 264);
            this.button05.Name = "button05";
            this.button05.Size = new System.Drawing.Size(70, 60);
            this.button05.TabIndex = 5;
            this.button05.Text = "5";
            this.button05.UseVisualStyleBackColor = true;
            this.button05.Click += new System.EventHandler(this.button0_Click);
            // 
            // button02
            // 
            this.button02.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button02.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button02.Location = new System.Drawing.Point(95, 336);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(70, 60);
            this.button02.TabIndex = 6;
            this.button02.Text = "2";
            this.button02.UseVisualStyleBackColor = true;
            this.button02.Click += new System.EventHandler(this.button0_Click);
            // 
            // Dotbutton
            // 
            this.Dotbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dotbutton.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Dotbutton.Location = new System.Drawing.Point(176, 407);
            this.Dotbutton.Name = "Dotbutton";
            this.Dotbutton.Size = new System.Drawing.Size(70, 64);
            this.Dotbutton.TabIndex = 7;
            this.Dotbutton.Text = ".";
            this.Dotbutton.UseVisualStyleBackColor = true;
            this.Dotbutton.Click += new System.EventHandler(this.button7_Click);
            // 
            // button0
            // 
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button0.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button0.Location = new System.Drawing.Point(95, 407);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(70, 65);
            this.button0.TabIndex = 8;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button01
            // 
            this.button01.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button01.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button01.Location = new System.Drawing.Point(14, 336);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(70, 60);
            this.button01.TabIndex = 9;
            this.button01.Text = "1";
            this.button01.UseVisualStyleBackColor = true;
            this.button01.Click += new System.EventHandler(this.button0_Click);
            // 
            // button04
            // 
            this.button04.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button04.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button04.Location = new System.Drawing.Point(14, 264);
            this.button04.Name = "button04";
            this.button04.Size = new System.Drawing.Size(70, 60);
            this.button04.TabIndex = 10;
            this.button04.Text = "4";
            this.button04.UseVisualStyleBackColor = true;
            this.button04.Click += new System.EventHandler(this.button0_Click);
            // 
            // button07
            // 
            this.button07.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button07.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button07.Location = new System.Drawing.Point(14, 192);
            this.button07.Name = "button07";
            this.button07.Size = new System.Drawing.Size(70, 60);
            this.button07.TabIndex = 11;
            this.button07.Text = "7";
            this.button07.UseVisualStyleBackColor = true;
            this.button07.Click += new System.EventHandler(this.button0_Click);
            // 
            // button09
            // 
            this.button09.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button09.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button09.Location = new System.Drawing.Point(176, 192);
            this.button09.Name = "button09";
            this.button09.Size = new System.Drawing.Size(70, 60);
            this.button09.TabIndex = 12;
            this.button09.Text = "9";
            this.button09.UseVisualStyleBackColor = true;
            this.button09.Click += new System.EventHandler(this.button0_Click);
            // 
            // Divbutton
            // 
            this.Divbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Divbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Divbutton.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Divbutton.Location = new System.Drawing.Point(260, 134);
            this.Divbutton.Name = "Divbutton";
            this.Divbutton.Size = new System.Drawing.Size(80, 46);
            this.Divbutton.TabIndex = 13;
            this.Divbutton.Tag = "÷";
            this.Divbutton.Text = "÷";
            this.Divbutton.UseVisualStyleBackColor = false;
            this.Divbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Multibutton
            // 
            this.Multibutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Multibutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Multibutton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Multibutton.Location = new System.Drawing.Point(260, 192);
            this.Multibutton.Name = "Multibutton";
            this.Multibutton.Size = new System.Drawing.Size(80, 60);
            this.Multibutton.TabIndex = 14;
            this.Multibutton.Tag = "X";
            this.Multibutton.Text = "X";
            this.Multibutton.UseVisualStyleBackColor = false;
            this.Multibutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Subbutton
            // 
            this.Subbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Subbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Subbutton.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Subbutton.Location = new System.Drawing.Point(260, 263);
            this.Subbutton.Name = "Subbutton";
            this.Subbutton.Size = new System.Drawing.Size(80, 61);
            this.Subbutton.TabIndex = 15;
            this.Subbutton.Tag = "-";
            this.Subbutton.Text = "-";
            this.Subbutton.UseVisualStyleBackColor = false;
            this.Subbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Addbutton.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Addbutton.Location = new System.Drawing.Point(258, 336);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(80, 60);
            this.Addbutton.TabIndex = 16;
            this.Addbutton.Tag = "+";
            this.Addbutton.Text = "+";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Equalbutton
            // 
            this.Equalbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Equalbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Equalbutton.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Equalbutton.Location = new System.Drawing.Point(258, 407);
            this.Equalbutton.Name = "Equalbutton";
            this.Equalbutton.Size = new System.Drawing.Size(80, 64);
            this.Equalbutton.TabIndex = 17;
            this.Equalbutton.Tag = "=";
            this.Equalbutton.Text = "=";
            this.Equalbutton.UseVisualStyleBackColor = false;
            this.Equalbutton.Click += new System.EventHandler(this.Equalbutton_Click);
            // 
            // Translate
            // 
            this.Translate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Translate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Translate.Location = new System.Drawing.Point(15, 407);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(69, 64);
            this.Translate.TabIndex = 18;
            this.Translate.Text = "+/-";
            this.Translate.UseVisualStyleBackColor = true;
            this.Translate.Click += new System.EventHandler(this.Translate_Click);
            // 
            // Root
            // 
            this.Root.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Root.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Root.Location = new System.Drawing.Point(95, 134);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(70, 46);
            this.Root.TabIndex = 19;
            this.Root.Tag = "√";
            this.Root.Text = "√";
            this.Root.UseVisualStyleBackColor = true;
            this.Root.Click += new System.EventHandler(this.Root_Click);
            // 
            // Bkspace
            // 
            this.Bkspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bkspace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bkspace.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bkspace.Location = new System.Drawing.Point(176, 134);
            this.Bkspace.Name = "Bkspace";
            this.Bkspace.Size = new System.Drawing.Size(70, 46);
            this.Bkspace.TabIndex = 20;
            this.Bkspace.Text = "←";
            this.Bkspace.UseVisualStyleBackColor = false;
            this.Bkspace.Click += new System.EventHandler(this.Bkspace_Click);
            // 
            // ViewBox
            // 
            this.ViewBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ViewBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ViewBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ViewBox.Location = new System.Drawing.Point(-7, 1);
            this.ViewBox.Multiline = true;
            this.ViewBox.Name = "ViewBox";
            this.ViewBox.ReadOnly = true;
            this.ViewBox.Size = new System.Drawing.Size(360, 65);
            this.ViewBox.TabIndex = 21;
            this.ViewBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LittleCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(352, 484);
            this.Controls.Add(this.ViewBox);
            this.Controls.Add(this.Bkspace);
            this.Controls.Add(this.Root);
            this.Controls.Add(this.Translate);
            this.Controls.Add(this.Equalbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Subbutton);
            this.Controls.Add(this.Multibutton);
            this.Controls.Add(this.Divbutton);
            this.Controls.Add(this.button09);
            this.Controls.Add(this.button07);
            this.Controls.Add(this.button04);
            this.Controls.Add(this.button01);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.Dotbutton);
            this.Controls.Add(this.button02);
            this.Controls.Add(this.button05);
            this.Controls.Add(this.button08);
            this.Controls.Add(this.button06);
            this.Controls.Add(this.button03);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ResultBox);
            this.Name = "LittleCalc";
            this.Text = "小算盤";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button03;
        private System.Windows.Forms.Button button06;
        private System.Windows.Forms.Button button08;
        private System.Windows.Forms.Button button05;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Button Dotbutton;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button01;
        private System.Windows.Forms.Button button04;
        private System.Windows.Forms.Button button07;
        private System.Windows.Forms.Button button09;
        private System.Windows.Forms.Button Divbutton;
        private System.Windows.Forms.Button Multibutton;
        private System.Windows.Forms.Button Subbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Equalbutton;
        private System.Windows.Forms.Button Translate;
        private System.Windows.Forms.Button Root;
        private System.Windows.Forms.Button Bkspace;
        private System.Windows.Forms.TextBox ViewBox;
    }
}

