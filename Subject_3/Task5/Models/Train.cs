using System;

namespace Task5.Models
{
    public class Train
    {
        private string destination;
        private string trainNumber;
        private DateTime departureTime;

        public Train()
        {
        }

        public Train(string destination, string trainNumber, DateTime departureTime)
        {
            this.destination = destination;
            this.trainNumber = trainNumber;
            this.departureTime = departureTime;
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public string TrainNumber
        {
            get { return trainNumber; }
            set { trainNumber = value; }
        }

        public DateTime DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; }
        }
    }
}
