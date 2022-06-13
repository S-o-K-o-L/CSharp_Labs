using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LightSource;

namespace Lab_3
{
    public partial class AddRecord : Form
    {
        TableLamp tableLamp = new TableLamp();
        public AddRecord(ILightSource item)
        {
            InitializeComponent();
            if(item is TableLamp)
            {
                tableLamp = item as TableLamp;
                TextBoxBrand.Text = tableLamp.Brand;
                TextBoxColor.Text = tableLamp.Color;
                TextBoxPower.Text = tableLamp.Power.ToString();
                TextBoxPrice.Text = tableLamp.Price.ToString();
                TextBoxWeight.Text = tableLamp.Weight.ToString();    
            }
        }
        private void ChangeButtonOK()
        {
            ButtonOk.Enabled = int.TryParse(TextBoxPower.Text, out int value1)
                && int.TryParse(TextBoxPrice.Text, out int value2)
                && int.TryParse(TextBoxWeight.Text, out int value3)
                && TextBoxBrand.Text != "" && TextBoxColor.Text != "" 
                && TextBoxPower.Text != "0" && TextBoxPrice.Text !=  "0" && TextBoxWeight.Text != "0";
        }
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            tableLamp.Weight = int.Parse(TextBoxWeight.Text);
            tableLamp.Power = int.Parse(TextBoxPower.Text);
            tableLamp.Price = int.Parse(TextBoxPrice.Text);
            tableLamp.Brand = TextBoxBrand.Text;
            tableLamp.Color = TextBoxColor.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void TextBoxPrice_TextChanged(object sender, EventArgs e)
        {
            ChangeButtonOK();
        }

        private void TextBoxPower_TextChanged(object sender, EventArgs e)
        {
            ChangeButtonOK();
        }

        private void TextBoxBrand_TextChanged(object sender, EventArgs e)
        {
            ChangeButtonOK();
        }

        private void TextBoxColor_TextChanged(object sender, EventArgs e)
        {
            ChangeButtonOK();
        }

        private void TextBoxWeight_TextChanged(object sender, EventArgs e)
        {
            ChangeButtonOK();
        }
    }
}
