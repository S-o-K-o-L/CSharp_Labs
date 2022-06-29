using Lab_5_BusStation;
using Lab_5_BusStation.Passenger;

namespace Lab_5
{
    public partial class Main : Form
    {
        string[] names = { "Âàñÿ", "Ïåòÿ", "Ñàøà" };
        public Main()
        {
            InitializeComponent();
        }
        public List<Object> viewObjects;
        public object viewObjectsLocker;
        public List<ViewModel> viewModels;
        public object viewModelsLocker;
        public List<string> messages;
        public ModelDrawer drawer;
        public object busLocker;
        public List<Bus> buses;
        public object passengerLocker;
        public List<Passenger> passengers;
        public Station station;
        private void Main_Load(object sender, EventArgs e)
        {
            viewModels = new List<ViewModel>();
            viewModelsLocker = new object();
            viewObjects = new List<Object>();
            viewObjectsLocker = new object();
            messages = new List<string>();
            busLocker = new object();
            buses = new List<Bus>();
            passengers = new List<Passenger>();
            passengerLocker = new object();
            drawer = new ModelDrawer(PictureBackground, Properties.Resources.Background, viewObjects, viewObjectsLocker, viewModels, viewModelsLocker);
            drawer.Start();
        }
        private void Message(string message)
        {
            TextBoxMessage.Invoke((MethodInvoker)delegate
            {
                messages.Add(message);
                TextBoxMessage.SelectedText += message + "\r\n\r\n";                
            });
        }
        private string InputInfo()
        {
            AddForm form = new AddForm();
            form.ShowDialog();
            return form.Information;
        }
        private void ñîçäàòüÎñòàíîâêóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = 600, y = 230;
            station = new Station(Message, buses, passengers, busLocker, passengerLocker, x, y);
            lock (viewObjectsLocker)
            {
                Image image = new Bitmap(Properties.Resources.BusStop, 200, 200);
                viewObjects.Add(new Object(image, x, y));
            }
            station.Name = InputInfo();
            Task.Run(station.Start);
            ñîçäàòüÎñòàíîâêóToolStripMenuItem.Enabled = false;
            äîáàâèòüÀâòîáóñToolStripMenuItem.Enabled = true;
        }

        private void äîáàâèòüÀâòîáóñToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = 1000, y = 300;
            y += buses.Count * 100;
            Random rnd = new Random();
            Bus bus = new Bus(station, rnd.Next(1, 3), Message, x, y);
            bus.Name = InputInfo();
            lock(busLocker)
            {
                buses.Add(bus);
            }
            lock(viewModelsLocker)
            {
                Image image = new Bitmap(Properties.Resources.Bus, 200, 200);
                viewModels.Add(new ViewModel(bus,image, x, y));
            }
            Task.Run(bus.Start);
        }
        private void GeneratePassangers()
        {

        }
        private void AddPassanger(Passenger pass,Image image)
        {
            Random random = new Random();
            double x = random.Next(100, 1000),y=250;
            pass.Name = names[random.Next(names.Length)];
            passengers.Add(pass);
            lock

        }

    }
}