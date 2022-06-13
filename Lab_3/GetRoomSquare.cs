using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class GetRoomSquare : Form
    {
        public GetRoomSquare()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public int GetSquare() => int.Parse(TextBoxSquare.Text);

        private void TextBoxSquare_TextChanged(object sender, EventArgs e)
        {
            ButtonOK.Enabled = int.TryParse(TextBoxSquare.Text, out int square);
        }
    }
}
