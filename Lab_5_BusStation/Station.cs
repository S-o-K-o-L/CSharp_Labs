using Pass = Lab_5_BusStation.Passenger.Passenger;

namespace Lab_5_BusStation
{
    public class Station : Model
    {
        private readonly List<Bus> buses;
        private readonly object busLocker;
        private readonly List<Pass> passengers;
        private readonly object passengerLocker;

        Pass currentPassenger;
        Bus currentBus;
        public string Name { get; set; }    
        public Station(Action<string> message, List<Bus> buses, List<Pass> passengers, object busLocker, object passengerLocker, double x,double y):base(message)
        {
            this.buses = buses;
            this.passengers = passengers;
            this.busLocker = busLocker;
            this.passengerLocker = passengerLocker;
            currentBus = null;
            currentPassenger = null;
            posX = x;
            posY = y;
        }
        public override void Start()
        {
            while(!IsCanceled)
            {
                Message("Начало работы остановки " + Name);
                Task.Delay(5000).Wait();

                if (!StartGettingOnBus())
                {
                    Message("Автобус не приехал на остановку, пассажиры растроены");
                }
                else
                {
                    WaitBus();
                    if (currentBus.RandomFull())
                    {
                        currentBus.IsLocked = false;
                        Task.Delay(300).Wait();
                        Message("В автобусе " + currentBus.Name + " нет мест, пассажиры не довольны!");
                        buses.Remove(currentBus);
                        currentBus = null;
                    }
                    else
                    {
                        
                        PassengersSittingOnBus();
                        currentBus.IsLocked = false;
                        currentBus.IsFull = true;
                        buses.Remove(currentBus);
                        currentBus = null;
                    }
                }              
                Message("Конец работы остановки " + Name);
                Task.Delay(3000).Wait();
            }
        }
        bool StartPassengerSittingOnBus()
        {
            bool isSitting = false;
            lock (passengerLocker)
            {
                for (int i = 0; i < passengers.Count && !isSitting; i++)
                {
                    if (!passengers[i].IsLocked)
                    {
                        currentPassenger = passengers[i];
                        currentPassenger.MoveToX = currentBus.posX;
                        currentPassenger.MoveToY = currentBus.posY + 50;
                        currentPassenger.IsLocked = true;
                        Message(currentPassenger.Name + " садится в автобус "+ currentBus.Name);
                        isSitting = true;
                    }
                }
                
            }
            return isSitting;
        }
        void EndPassengerSittingOnBus()
        {
            if(currentPassenger.IsArrived())
            {
                Task.Delay(1000).Wait();
                currentPassenger.IsLocked = false;
                Message(currentPassenger.Name + " сел на автобус " + currentBus.Name);
                passengers.Remove(currentPassenger);
                currentPassenger = null;
            }
        }
        void PassengersSittingOnBus()
        {
            int countSittingPassangers = 0;
            while(countSittingPassangers<currentBus.Capacity)
            {
                Task.Delay(1000).Wait();
                if(!StartPassengerSittingOnBus())
                {
                    Message("Пассажиры отсутсвуют!");
                    return;
                }
                else
                {                   
                    WaitPassenger();
                    EndPassengerSittingOnBus();
                }
                countSittingPassangers++;
            }
        }

        void WaitPassenger()
        {
            bool isArrived = false;
            while (!isArrived)
            {
                Task.Delay(1000).Wait();
                lock (passengerLocker) { isArrived = currentPassenger.IsArrived(); }
            }
        }
        bool WaitBus()
        {
            bool isArrived = false;
            while(!isArrived)
            {
                Task.Delay(100).Wait();
                lock (busLocker) { isArrived = currentBus.IsArrived(); }
            }
            return isArrived;
        }

        bool StartGettingOnBus()
        {
            bool isGetting = false;
            lock (busLocker)
            {
                for (int i = 0; i < buses.Count && !isGetting; i++)
                {
                    if (!buses[i].IsLocked)
                    {
                        currentBus = buses[i];
                        currentBus.MoveToX = posX;
                        currentBus.MoveToY = posY;
                        currentBus.IsLocked = true;
                        Message(currentBus.Name + " едет на остановку!");
                        isGetting = true;
                    }
                }
            }
            return isGetting;
        }
    }
}