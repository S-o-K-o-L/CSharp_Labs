using Lab_2_Party;

namespace Lab_2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        FirstParty firstParty = new FirstParty();
        SecondParty secondParty = new SecondParty();
        private void ButtonInput_Click(object sender, EventArgs e)
        {
            AddParty form = new AddParty();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.GetLastYearSize() == "")
                {
                    firstParty = new FirstParty(form.GetName(), int.Parse(form.GetSize()), int.Parse(form.GetPercentage()));
                    secondParty = new SecondParty();
                }
                else
                {
                    secondParty = new SecondParty(form.GetName(), int.Parse(form.GetSize()), int.Parse(form.GetPercentage()), int.Parse(form.GetLastYearSize()));
                    firstParty = new FirstParty();
                }
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void ButtonOutput_Click(object sender, EventArgs e)
        {
            if (firstParty.Name != "")
                textBox1.Text = firstParty.ToString();
            if (secondParty.Name != "")
                textBox1.Text = secondParty.ToString();
        }

        private void ButtonCalculateQuality_Click(object sender, EventArgs e)
        {
            if (firstParty.Name != "")
                textBox2.Text = $"{firstParty.Quality():f2}";
            if (secondParty.Name != "")
                textBox2.Text = $"{secondParty.Quality():f2}";
        }
    }
}