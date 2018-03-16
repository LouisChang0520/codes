namespace PhoneDBTest
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
            this.S_NO = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.Label();
            this.ADDRESS = new System.Windows.Forms.Label();
            this.BIRTHDAY = new System.Windows.Forms.Label();
            this.PHONE = new System.Windows.Forms.Label();
            this.SEX = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.NumBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SexBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.BirthBox = new System.Windows.Forms.TextBox();
            this.AdsBox = new System.Windows.Forms.TextBox();
            this.SLTcomboBox = new System.Windows.Forms.ComboBox();
            this.SHButton = new System.Windows.Forms.Button();
            this.SLTlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // S_NO
            // 
            this.S_NO.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.S_NO.Location = new System.Drawing.Point(32, 100);
            this.S_NO.Name = "S_NO";
            this.S_NO.Size = new System.Drawing.Size(74, 35);
            this.S_NO.TabIndex = 0;
            this.S_NO.Text = "工號";
            this.S_NO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NAME
            // 
            this.NAME.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NAME.Location = new System.Drawing.Point(32, 144);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(74, 35);
            this.NAME.TabIndex = 1;
            this.NAME.Text = "姓名";
            this.NAME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ADDRESS
            // 
            this.ADDRESS.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ADDRESS.Location = new System.Drawing.Point(32, 320);
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.Size = new System.Drawing.Size(74, 35);
            this.ADDRESS.TabIndex = 6;
            this.ADDRESS.Text = "地址";
            this.ADDRESS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BIRTHDAY
            // 
            this.BIRTHDAY.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BIRTHDAY.Location = new System.Drawing.Point(32, 276);
            this.BIRTHDAY.Name = "BIRTHDAY";
            this.BIRTHDAY.Size = new System.Drawing.Size(74, 35);
            this.BIRTHDAY.TabIndex = 7;
            this.BIRTHDAY.Text = "生日";
            this.BIRTHDAY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PHONE
            // 
            this.PHONE.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PHONE.Location = new System.Drawing.Point(32, 232);
            this.PHONE.Name = "PHONE";
            this.PHONE.Size = new System.Drawing.Size(74, 35);
            this.PHONE.TabIndex = 8;
            this.PHONE.Text = "電話";
            this.PHONE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SEX
            // 
            this.SEX.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SEX.Location = new System.Drawing.Point(32, 188);
            this.SEX.Name = "SEX";
            this.SEX.Size = new System.Drawing.Size(74, 35);
            this.SEX.TabIndex = 9;
            this.SEX.Text = "性別";
            this.SEX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Addbutton
            // 
            this.Addbutton.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Addbutton.Location = new System.Drawing.Point(14, 54);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(117, 34);
            this.Addbutton.TabIndex = 10;
            this.Addbutton.Text = "新增";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DelButton.Location = new System.Drawing.Point(268, 54);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(117, 34);
            this.DelButton.TabIndex = 12;
            this.DelButton.Text = "刪除";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EditButton.Location = new System.Drawing.Point(141, 54);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(117, 34);
            this.EditButton.TabIndex = 13;
            this.EditButton.Text = "編輯";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // NumBox
            // 
            this.NumBox.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumBox.Location = new System.Drawing.Point(137, 103);
            this.NumBox.Name = "NumBox";
            this.NumBox.Size = new System.Drawing.Size(129, 30);
            this.NumBox.TabIndex = 14;
            this.NumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameBox.Location = new System.Drawing.Point(137, 146);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(129, 30);
            this.NameBox.TabIndex = 15;
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SexBox
            // 
            this.SexBox.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SexBox.Location = new System.Drawing.Point(137, 189);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(38, 30);
            this.SexBox.TabIndex = 16;
            this.SexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PhoneBox.Location = new System.Drawing.Point(137, 232);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(163, 30);
            this.PhoneBox.TabIndex = 17;
            this.PhoneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BirthBox
            // 
            this.BirthBox.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BirthBox.Location = new System.Drawing.Point(137, 275);
            this.BirthBox.Name = "BirthBox";
            this.BirthBox.Size = new System.Drawing.Size(129, 30);
            this.BirthBox.TabIndex = 18;
            this.BirthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AdsBox
            // 
            this.AdsBox.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AdsBox.Location = new System.Drawing.Point(137, 318);
            this.AdsBox.Name = "AdsBox";
            this.AdsBox.Size = new System.Drawing.Size(328, 30);
            this.AdsBox.TabIndex = 19;
            this.AdsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SLTcomboBox
            // 
            this.SLTcomboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SLTcomboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SLTcomboBox.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SLTcomboBox.FormattingEnabled = true;
            this.SLTcomboBox.ItemHeight = 27;
            this.SLTcomboBox.Location = new System.Drawing.Point(126, 13);
            this.SLTcomboBox.Name = "SLTcomboBox";
            this.SLTcomboBox.Size = new System.Drawing.Size(140, 35);
            this.SLTcomboBox.TabIndex = 22;
            // 
            // SHButton
            // 
            this.SHButton.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SHButton.Location = new System.Drawing.Point(395, 54);
            this.SHButton.Name = "SHButton";
            this.SHButton.Size = new System.Drawing.Size(117, 34);
            this.SHButton.TabIndex = 23;
            this.SHButton.Text = "查詢";
            this.SHButton.UseVisualStyleBackColor = true;
            this.SHButton.Click += new System.EventHandler(this.SHButton_Click);
            // 
            // SLTlabel
            // 
            this.SLTlabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SLTlabel.Location = new System.Drawing.Point(32, 12);
            this.SLTlabel.Name = "SLTlabel";
            this.SLTlabel.Size = new System.Drawing.Size(74, 35);
            this.SLTlabel.TabIndex = 24;
            this.SLTlabel.Text = "Select";
            this.SLTlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 378);
            this.Controls.Add(this.SLTlabel);
            this.Controls.Add(this.SHButton);
            this.Controls.Add(this.SLTcomboBox);
            this.Controls.Add(this.AdsBox);
            this.Controls.Add(this.BirthBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.SexBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NumBox);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.SEX);
            this.Controls.Add(this.PHONE);
            this.Controls.Add(this.BIRTHDAY);
            this.Controls.Add(this.ADDRESS);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.S_NO);
            this.Name = "MainForm";
            this.Text = "通訊錄";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label S_NO;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Label ADDRESS;
        private System.Windows.Forms.Label BIRTHDAY;
        private System.Windows.Forms.Label PHONE;
        private System.Windows.Forms.Label SEX;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox NumBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SexBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox BirthBox;
        private System.Windows.Forms.TextBox AdsBox;
        private System.Windows.Forms.ComboBox SLTcomboBox;
        private System.Windows.Forms.Button SHButton;
        private System.Windows.Forms.Label SLTlabel;
    }
}

