using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            AddButton.Enabled = false;
        }
        public string Information { get; set; }
        private void AddButton_Click(object sender, EventArgs e)
        {
            Information = textBox1.Text;
            this.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
                AddButton.Enabled = true;
        }
    }
}
