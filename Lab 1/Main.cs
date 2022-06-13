using Lab_Time;

namespace Lab_1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Lab_Time.Day day = new Lab_Time.Day();
        private void ButtonInput_Click_1(object sender, EventArgs e)
        {
            AddTimeForm form = new AddTimeForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                day = new Lab_Time.Day(form.getHour(), form.getMinute());
                button2.Enabled = true;
                button3.Enabled = true;
                textBox1.Text = "-";
                textBox2.Text = "-";
            }
        }
        private void ButtonOutput_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = day.GetCurrentTime();
        }

        private void ButtonCalculateTimeOfDay_Click(object sender, EventArgs e)
        {
            textBox2.Text = day.GetCurrentTimeOfDay();
        }
    }
}