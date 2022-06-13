using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class AddParty : Form
    {
        public AddParty()
        {
            InitializeComponent();
        }
        private void SetVisible(bool value)
        {
            label4.Visible = value;
            textBox4.Visible = value;
        }
        
        public string GetName() => textBox1.Text;
        public string GetSize() => textBox2.Text;
        public string GetPercentage() => textBox3.Text;
        public string GetLastYearSize() => textBox4.Text;

        private bool ChekTextBox()
        {
            if (checkBox1.Checked)
            {
                return textBox1.Text.Length != 0 && int.TryParse(textBox2.Text, out int value1) && int.TryParse(textBox3.Text, out int value2);
            }
            else
            {
                return textBox1.Text.Length != 0 && int.TryParse(textBox2.Text, out int value1) && int.TryParse(textBox3.Text, out int value2) && int.TryParse(textBox3.Text, out int value3);
            }
        }

        private void CheckBoxFirstLvl_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                SetVisible(false);
            }
            else
            {
                checkBox2.Checked = true;
                SetVisible(true);
            }
        }

        private void CheckBoxSecondLvl_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                SetVisible(true);
                button1.Enabled = false;
            }
            else
            {
                checkBox1.Checked = true;
                SetVisible(false);
            }

        }
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            if (ChekTextBox()) button1.Enabled = true;
        }
        private void TextBoxSize_TextChanged(object sender, EventArgs e)
        {
            if (ChekTextBox()) button1.Enabled = true;
        }
        private void TextBoxPercentage_TextChanged(object sender, EventArgs e)
        {
            if (ChekTextBox()) button1.Enabled = true;
        }
        private void TextBoxLastYearSuze_TextChanged(object sender, EventArgs e)
        {
            if (ChekTextBox()) button1.Enabled = true;
        }
    }
}
