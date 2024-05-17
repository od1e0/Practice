using System;

namespace Task5.Models
{
    /// <summary>
    /// Класс, представляющий поезд.
    /// </summary>
    public class Train
    {
        private string destination;
        private string trainNumber;
        private DateTime departureTime;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Train()
        {
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="destination">Пункт назначения.</param>
        /// <param name="trainNumber">Номер поезда.</param>
        /// <param name="departureTime">Время отправления.</param>
        public Train(string destination, string trainNumber, DateTime departureTime)
        {
            this.destination = destination;
            this.trainNumber = trainNumber;
            this.departureTime = departureTime;
        }

        /// <summary>
        /// Пункт назначения поезда.
        /// </summary>
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        /// <summary>
        /// Номер поезда.
        /// </summary>
        public string TrainNumber
        {
            get { return trainNumber; }
            set { trainNumber = value; }
        }

        /// <summary>
        /// Время отправления поезда.
        /// </summary>
        public DateTime DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; }
        }
    }
}
