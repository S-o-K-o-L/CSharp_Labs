namespace Lab_3
{
    partial class AddRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.TextBoxPower = new System.Windows.Forms.TextBox();
            this.TextBoxBrand = new System.Windows.Forms.TextBox();
            this.TextBoxColor = new System.Windows.Forms.TextBox();
            this.TextBoxWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Location = new System.Drawing.Point(147, 62);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(193, 27);
            this.TextBoxPrice.TabIndex = 0;
            this.TextBoxPrice.TextChanged += new System.EventHandler(this.TextBoxPrice_TextChanged);
            // 
            // TextBoxPower
            // 
            this.TextBoxPower.Location = new System.Drawing.Point(147, 117);
            this.TextBoxPower.Name = "TextBoxPower";
            this.TextBoxPower.Size = new System.Drawing.Size(193, 27);
            this.TextBoxPower.TabIndex = 1;
            this.TextBoxPower.TextChanged += new System.EventHandler(this.TextBoxPower_TextChanged);
            // 
            // TextBoxBrand
            // 
            this.TextBoxBrand.Location = new System.Drawing.Point(147, 171);
            this.TextBoxBrand.Name = "TextBoxBrand";
            this.TextBoxBrand.Size = new System.Drawing.Size(193, 27);
            this.TextBoxBrand.TabIndex = 2;
            this.TextBoxBrand.TextChanged += new System.EventHandler(this.TextBoxBrand_TextChanged);
            // 
            // TextBoxColor
            // 
            this.TextBoxColor.Location = new System.Drawing.Point(147, 224);
            this.TextBoxColor.Name = "TextBoxColor";
            this.TextBoxColor.Size = new System.Drawing.Size(193, 27);
            this.TextBoxColor.TabIndex = 3;
            this.TextBoxColor.TextChanged += new System.EventHandler(this.TextBoxColor_TextChanged);
            // 
            // TextBoxWeight
            // 
            this.TextBoxWeight.Location = new System.Drawing.Point(147, 271);
            this.TextBoxWeight.Name = "TextBoxWeight";
            this.TextBoxWeight.Size = new System.Drawing.Size(193, 27);
            this.TextBoxWeight.TabIndex = 4;
            this.TextBoxWeight.TextChanged += new System.EventHandler(this.TextBoxWeight_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Стоимость:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Модель:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Мощность:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цвет:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Вес:";
            // 
            // ButtonOk
            // 
            this.ButtonOk.Enabled = false;
            this.ButtonOk.Location = new System.Drawing.Point(147, 328);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(193, 56);
            this.ButtonOk.TabIndex = 10;
            this.ButtonOk.Text = "Ok";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 420);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxWeight);
            this.Controls.Add(this.TextBoxColor);
            this.Controls.Add(this.TextBoxBrand);
            this.Controls.Add(this.TextBoxPower);
            this.Controls.Add(this.TextBoxPrice);
            this.Name = "AddRecord";
            this.Text = "AddRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBoxPrice;
        private TextBox TextBoxPower;
        private TextBox TextBoxBrand;
        private TextBox TextBoxColor;
        private TextBox TextBoxWeight;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button ButtonOk;
    }
}