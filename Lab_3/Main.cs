using LightSource;

namespace Lab_3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }      
        public List<ILightSource> lamps = new List<ILightSource>();
        private void InputInfo_Click(object sender, EventArgs e)
        {
            ILightSource lamp = new TableLamp();
            AddRecord form = new AddRecord(lamp);
            if(form.ShowDialog() == DialogResult.OK)
            {
                lamps.Add(lamp);
                RecordListBox.Items.Add(lamp);
            }
        } 
        private void RecordListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (RecordListBox.SelectedIndex != -1)
            {
                int index = RecordListBox.SelectedIndex;
                AddRecord form = new AddRecord(lamps[index]);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RecordListBox.Items.RemoveAt(index);
                    RecordListBox.Items.Insert(index, lamps[index]);
                }
            }
        }
        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            if (RecordListBox.SelectedIndex != -1)
            {
                int index = RecordListBox.SelectedIndex;
                lamps.RemoveAt(index);
                RecordListBox.Items.RemoveAt(index);
            }
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RecordListBox.SelectedIndex != -1)
            {
                TableLamp lamp = lamps[RecordListBox.SelectedIndex] as TableLamp;
                MessageBox.Show(lamp.InformationAboutLamp());
            }
        }

        private void LightningRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RecordListBox.SelectedIndex != -1)
            {
                GetRoomSquare form = new GetRoomSquare();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int square = form.GetSquare();
                    TableLamp lamp = lamps[RecordListBox.SelectedIndex] as TableLamp;
                    MessageBox.Show(lamp.LightingRoom(square));
                }
            }
        }

        private void TurnOnLampToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RecordListBox.SelectedIndex != -1)
            {
                TableLamp lamp = lamps[RecordListBox.SelectedIndex] as TableLamp;
                MessageBox.Show(lamp.TurnOnLamp());
            }
        }

        private void QualityLampToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RecordListBox.SelectedIndex != -1)
            {
                TableLamp lamp = lamps[RecordListBox.SelectedIndex] as TableLamp;
                MessageBox.Show(lamp.Quality());
            }
        }

        private void ThiefLampToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RecordListBox.SelectedIndex != -1)
            {
                TableLamp lamp = lamps[RecordListBox.SelectedIndex] as TableLamp;
                MessageBox.Show(lamp.TryThiefLamp());
            }
        }
    }
}