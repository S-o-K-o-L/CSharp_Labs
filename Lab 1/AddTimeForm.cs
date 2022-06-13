using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class AddTimeForm : Form
    {
        public AddTimeForm()
        {
            InitializeComponent();
        }
        public int getHour() { return string.IsNullOrEmpty(textBox1.Text) ? 0 : int.Parse(textBox1.Text); }
        public int getMinute() { return string.IsNullOrEmpty(textBox2.Text)?0:int.Parse(textBox2.Text); }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) < 24 && int.Parse(textBox1.Text) >= 0
                && int.Parse(textBox2.Text) < 60 && int.Parse(textBox2.Text) >= 0)
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Неверные данные");
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void TextBoxHour_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = int.TryParse(textBox1.Text, out int value) && int.TryParse(textBox2.Text, out int value1);
        }

        private void TextBoxMinute_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = int.TryParse(textBox2.Text, out int value) && int.TryParse(textBox1.Text, out int value1);
        }
    }
}
