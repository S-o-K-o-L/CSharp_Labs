namespace Lab_5
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
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьОстановкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPassangerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddYoung = new System.Windows.Forms.ToolStripMenuItem();
            this.AddOld = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAdult = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureBackground = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Location = new System.Drawing.Point(23, 72);
            this.TextBoxMessage.Multiline = true;
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.ReadOnly = true;
            this.TextBoxMessage.Size = new System.Drawing.Size(243, 564);
            this.TextBoxMessage.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьОстановкуToolStripMenuItem,
            this.AddBusToolStripMenuItem,
            this.AddPassangerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1346, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // создатьОстановкуToolStripMenuItem
            // 
            this.создатьОстановкуToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.создатьОстановкуToolStripMenuItem.Name = "создатьОстановкуToolStripMenuItem";
            this.создатьОстановкуToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.создатьОстановкуToolStripMenuItem.Text = "Создать остановку";
            this.создатьОстановкуToolStripMenuItem.Click += new System.EventHandler(this.создатьОстановкуToolStripMenuItem_Click);
            // 
            // AddBusToolStripMenuItem
            // 
            this.AddBusToolStripMenuItem.Enabled = false;
            this.AddBusToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBusToolStripMenuItem.Name = "AddBusToolStripMenuItem";
            this.AddBusToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.AddBusToolStripMenuItem.Text = "Добавить автобус";
            this.AddBusToolStripMenuItem.Click += new System.EventHandler(this.добавитьАвтобусToolStripMenuItem_Click);
            // 
            // AddPassangerToolStripMenuItem
            // 
            this.AddPassangerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddYoung,
            this.AddOld,
            this.AddAdult});
            this.AddPassangerToolStripMenuItem.Enabled = false;
            this.AddPassangerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddPassangerToolStripMenuItem.Name = "AddPassangerToolStripMenuItem";
            this.AddPassangerToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.AddPassangerToolStripMenuItem.Text = "Добавить пассажира";
            // 
            // AddYoung
            // 
            this.AddYoung.Enabled = false;
            this.AddYoung.Name = "AddYoung";
            this.AddYoung.Size = new System.Drawing.Size(195, 32);
            this.AddYoung.Text = "Молодого";
            this.AddYoung.Click += new System.EventHandler(this.AddYongPassanger_Click);
            // 
            // AddOld
            // 
            this.AddOld.Enabled = false;
            this.AddOld.Name = "AddOld";
            this.AddOld.Size = new System.Drawing.Size(195, 32);
            this.AddOld.Text = "Старого";
            this.AddOld.Click += new System.EventHandler(this.AddOldPassanger_Click);
            // 
            // AddAdult
            // 
            this.AddAdult.Enabled = false;
            this.AddAdult.Name = "AddAdult";
            this.AddAdult.Size = new System.Drawing.Size(195, 32);
            this.AddAdult.Text = "Взрослого";
            this.AddAdult.Click += new System.EventHandler(this.AddAdultPassanger_Click);
            // 
            // PictureBackground
            // 
            this.PictureBackground.ErrorImage = global::Lab_5.Properties.Resources.YoungPassenger;
            this.PictureBackground.InitialImage = global::Lab_5.Properties.Resources.YoungPassenger;
            this.PictureBackground.Location = new System.Drawing.Point(292, 72);
            this.PictureBackground.Name = "PictureBackground";
            this.PictureBackground.Size = new System.Drawing.Size(1029, 564);
            this.PictureBackground.TabIndex = 2;
            this.PictureBackground.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cобытия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(292, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Визуализация";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 648);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBackground);
            this.Controls.Add(this.TextBoxMessage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBoxMessage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem создатьОстановкуToolStripMenuItem;
        private ToolStripMenuItem AddPassangerToolStripMenuItem;
        private PictureBox PictureBackground;
        private Label label1;
        private Label label2;
        private ToolStripMenuItem AddBusToolStripMenuItem;
        private ToolStripMenuItem AddYoung;
        private ToolStripMenuItem AddOld;
        private ToolStripMenuItem AddAdult;
    }
}