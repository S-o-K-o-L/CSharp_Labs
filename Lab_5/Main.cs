using Lab_5_BusStation;
using Lab_5_BusStation.Passenger;

namespace Lab_5
{
    public partial class Main : Form
    {
        string[] names = { "Âàñÿ", "Ïåòÿ", "Ñàøà" };
        const int MAX_COUNT_PASSANGERS = 10;
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
            AddBusToolStripMenuItem.Enabled = true;
            AddPassangerToolStripMenuItem.Enabled = true;
            AddOld.Enabled = true;
            AddAdult.Enabled = true;
            AddYoung.Enabled = true;
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
        private void AddPassanger(Passenger pass,Image image)
        {
            Random random = new Random();
            pass.Name = names[random.Next(names.Length)];
            passengers.Add(pass);
            lock (viewModelsLocker)
            {
                viewModels.Add(new ViewModel(pass, image, pass.posX, pass.posY));
            }
            Task.Run(pass.Start);
            if(passengers.Count >= MAX_COUNT_PASSANGERS)
            {
                AddOld.Enabled = false;
                AddAdult.Enabled = false;
                AddYoung.Enabled = false;
                AddPassangerToolStripMenuItem.Enabled = false;
            }
        }
        private void AddYongPassanger_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double x = random.Next(100, 1000), y = 250;
            Image image = new Bitmap(Properties.Resources.YoungPassenger, 100, 30);
            YoungPassenger pass = new YoungPassenger(station,Message, x, y);
            AddPassanger(pass, image);       
        }
        private void AddAdultPassanger_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double x = random.Next(100, 1000), y = 250;
            Image image = new Bitmap(Properties.Resources.AdultPassenger, 200, 75);
            AdultPassenger pass = new AdultPassenger(station,Message, x, y);
            AddPassanger(pass, image);
        }
        private void AddOldPassanger_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double x = random.Next(100, 1000), y = 250;
            Image image = new Bitmap(Properties.Resources.OldPassenger, 120, 50);
            OldPassenger pass = new OldPassenger(station,Message, x, y);
            AddPassanger(pass, image);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            drawer.Stop();

            foreach (Passenger pass in passengers)
            {
                pass.IsCanceled = true;
            }

            foreach (ViewModel mo in viewModels)
            {
                if (mo is ViewModel)
                {
                    mo.Model.IsCanceled = true;
                }
            }
        }
    }
}