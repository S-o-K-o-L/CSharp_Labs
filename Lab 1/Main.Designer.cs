namespace Lab_1
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ввести время";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonInput_Click_1);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(272, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Вывести текущее время";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonOutput_Click_1);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(510, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "Вывести время дня";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonCalculateTimeOfDay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Текущее время:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(97, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Время дня:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(295, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(194, 47);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "-";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(295, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(194, 47);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "-";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 271);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}