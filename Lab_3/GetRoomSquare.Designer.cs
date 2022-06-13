namespace Lab_3
{
    partial class GetRoomSquare
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
            this.ButtonOK = new System.Windows.Forms.Button();
            this.TextBoxSquare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(55, 105);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(209, 57);
            this.ButtonOK.TabIndex = 0;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // TextBoxSquare
            // 
            this.TextBoxSquare.Location = new System.Drawing.Point(55, 50);
            this.TextBoxSquare.Name = "TextBoxSquare";
            this.TextBoxSquare.Size = new System.Drawing.Size(209, 27);
            this.TextBoxSquare.TabIndex = 1;
            this.TextBoxSquare.TextChanged += new System.EventHandler(this.TextBoxSquare_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Площадь";
            // 
            // GetRoomSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 179);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxSquare);
            this.Controls.Add(this.ButtonOK);
            this.Name = "GetRoomSquare";
            this.Text = "GetRoomSquare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonOK;
        private TextBox TextBoxSquare;
        private Label label1;
    }
}