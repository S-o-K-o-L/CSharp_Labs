namespace Lab_3
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
            this.InputInfo = new System.Windows.Forms.Button();
            this.RecordListBox = new System.Windows.Forms.ListBox();
            this.DeleteRecord = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнитьМетодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LightningRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TurnOnLampToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QualityLampToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThiefLampToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputInfo
            // 
            this.InputInfo.Location = new System.Drawing.Point(35, 354);
            this.InputInfo.Name = "InputInfo";
            this.InputInfo.Size = new System.Drawing.Size(220, 72);
            this.InputInfo.TabIndex = 0;
            this.InputInfo.Text = "Добавить запись";
            this.InputInfo.UseVisualStyleBackColor = true;
            this.InputInfo.Click += new System.EventHandler(this.InputInfo_Click);
            // 
            // RecordListBox
            // 
            this.RecordListBox.FormattingEnabled = true;
            this.RecordListBox.ItemHeight = 20;
            this.RecordListBox.Location = new System.Drawing.Point(35, 67);
            this.RecordListBox.Name = "RecordListBox";
            this.RecordListBox.Size = new System.Drawing.Size(718, 264);
            this.RecordListBox.TabIndex = 1;
            this.RecordListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RecordListBox_MouseDoubleClick);
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.Location = new System.Drawing.Point(541, 354);
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(212, 72);
            this.DeleteRecord.TabIndex = 2;
            this.DeleteRecord.Text = "Удалить запись";
            this.DeleteRecord.UseVisualStyleBackColor = true;
            this.DeleteRecord.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.выполнитьМетодToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.InputInfo_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // выполнитьМетодToolStripMenuItem
            // 
            this.выполнитьМетодToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoToolStripMenuItem,
            this.LightningRoomToolStripMenuItem,
            this.TurnOnLampToolStripMenuItem,
            this.QualityLampToolStripMenuItem,
            this.ThiefLampToolStripMenuItem});
            this.выполнитьМетодToolStripMenuItem.Name = "выполнитьМетодToolStripMenuItem";
            this.выполнитьМетодToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.выполнитьМетодToolStripMenuItem.Text = "Выполнить метод";
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(334, 26);
            this.InfoToolStripMenuItem.Text = "Информация о лампе";
            this.InfoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // LightningRoomToolStripMenuItem
            // 
            this.LightningRoomToolStripMenuItem.Name = "LightningRoomToolStripMenuItem";
            this.LightningRoomToolStripMenuItem.Size = new System.Drawing.Size(334, 26);
            this.LightningRoomToolStripMenuItem.Text = "Возможность освещения комнаты";
            this.LightningRoomToolStripMenuItem.Click += new System.EventHandler(this.LightningRoomToolStripMenuItem_Click);
            // 
            // TurnOnLampToolStripMenuItem
            // 
            this.TurnOnLampToolStripMenuItem.Name = "TurnOnLampToolStripMenuItem";
            this.TurnOnLampToolStripMenuItem.Size = new System.Drawing.Size(334, 26);
            this.TurnOnLampToolStripMenuItem.Text = "Включить лампу";
            this.TurnOnLampToolStripMenuItem.Click += new System.EventHandler(this.TurnOnLampToolStripMenuItem_Click);
            // 
            // QualityLampToolStripMenuItem
            // 
            this.QualityLampToolStripMenuItem.Name = "QualityLampToolStripMenuItem";
            this.QualityLampToolStripMenuItem.Size = new System.Drawing.Size(334, 26);
            this.QualityLampToolStripMenuItem.Text = "Определить качество лампы";
            this.QualityLampToolStripMenuItem.Click += new System.EventHandler(this.QualityLampToolStripMenuItem_Click);
            // 
            // ThiefLampToolStripMenuItem
            // 
            this.ThiefLampToolStripMenuItem.Name = "ThiefLampToolStripMenuItem";
            this.ThiefLampToolStripMenuItem.Size = new System.Drawing.Size(334, 26);
            this.ThiefLampToolStripMenuItem.Text = "Украсть лампу";
            this.ThiefLampToolStripMenuItem.Click += new System.EventHandler(this.ThiefLampToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteRecord);
            this.Controls.Add(this.RecordListBox);
            this.Controls.Add(this.InputInfo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button InputInfo;
        private ListBox RecordListBox;
        private Button DeleteRecord;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem выполнитьМетодToolStripMenuItem;
        private ToolStripMenuItem InfoToolStripMenuItem;
        private ToolStripMenuItem LightningRoomToolStripMenuItem;
        private ToolStripMenuItem TurnOnLampToolStripMenuItem;
        private ToolStripMenuItem QualityLampToolStripMenuItem;
        private ToolStripMenuItem ThiefLampToolStripMenuItem;
    }
}