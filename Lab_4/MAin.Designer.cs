namespace Lab_4
{
    partial class Form1
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
            this.Methods = new System.Windows.Forms.ComboBox();
            this.Info = new System.Windows.Forms.ListBox();
            this.Parametrs = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.СlassComboBox = new System.Windows.Forms.ComboBox();
            this.ExecuteMethod = new System.Windows.Forms.Button();
            this.InputParametrs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Methods
            // 
            this.Methods.Enabled = false;
            this.Methods.FormattingEnabled = true;
            this.Methods.Location = new System.Drawing.Point(566, 40);
            this.Methods.Name = "Methods";
            this.Methods.Size = new System.Drawing.Size(185, 28);
            this.Methods.TabIndex = 0;
            this.Methods.Text = "Методы";
            this.Methods.SelectedIndexChanged += new System.EventHandler(this.Methods_SelectedIndexChanged);
            // 
            // Info
            // 
            this.Info.FormattingEnabled = true;
            this.Info.ItemHeight = 20;
            this.Info.Location = new System.Drawing.Point(22, 134);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(322, 304);
            this.Info.TabIndex = 1;
            // 
            // Parametrs
            // 
            this.Parametrs.FormattingEnabled = true;
            this.Parametrs.ItemHeight = 20;
            this.Parametrs.Location = new System.Drawing.Point(404, 134);
            this.Parametrs.Name = "Parametrs";
            this.Parametrs.Size = new System.Drawing.Size(253, 304);
            this.Parametrs.TabIndex = 2;
            this.Parametrs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Parametrs_MouseClick);
            // 
            // Add
            // 
            this.Add.Enabled = false;
            this.Add.Location = new System.Drawing.Point(196, 40);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(148, 56);
            this.Add.TabIndex = 3;
            this.Add.Text = "Создать";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // СlassComboBox
            // 
            this.СlassComboBox.FormattingEnabled = true;
            this.СlassComboBox.Location = new System.Drawing.Point(22, 40);
            this.СlassComboBox.Name = "СlassComboBox";
            this.СlassComboBox.Size = new System.Drawing.Size(153, 28);
            this.СlassComboBox.TabIndex = 4;
            this.СlassComboBox.Text = "Классы";
            this.СlassComboBox.SelectedIndexChanged += new System.EventHandler(this.СlassComboBox_SelectedIndexChanged);
            // 
            // ExecuteMethod
            // 
            this.ExecuteMethod.Enabled = false;
            this.ExecuteMethod.Location = new System.Drawing.Point(404, 40);
            this.ExecuteMethod.Name = "ExecuteMethod";
            this.ExecuteMethod.Size = new System.Drawing.Size(141, 60);
            this.ExecuteMethod.TabIndex = 5;
            this.ExecuteMethod.Text = "Выполнить метод";
            this.ExecuteMethod.UseVisualStyleBackColor = true;
            this.ExecuteMethod.Click += new System.EventHandler(this.ExecuteMethod_Click);
            // 
            // InputParametrs
            // 
            this.InputParametrs.Enabled = false;
            this.InputParametrs.Location = new System.Drawing.Point(689, 134);
            this.InputParametrs.Name = "InputParametrs";
            this.InputParametrs.Size = new System.Drawing.Size(88, 304);
            this.InputParametrs.TabIndex = 6;
            this.InputParametrs.Text = "Ввести параметр";
            this.InputParametrs.UseVisualStyleBackColor = true;
            this.InputParametrs.Click += new System.EventHandler(this.InputParametrs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите класс:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Выберите метод:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Информация об объекте:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Параметры метода:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputParametrs);
            this.Controls.Add(this.ExecuteMethod);
            this.Controls.Add(this.СlassComboBox);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Parametrs);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Methods);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox Methods;
        private ListBox Info;
        private ListBox Parametrs;
        private Button Add;
        private ComboBox СlassComboBox;
        private Button ExecuteMethod;
        private Button InputParametrs;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}