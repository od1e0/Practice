using System;

namespace Task2.Models
{
    public class Car : Vehicle
    {
        public Car(int speed) : base(speed)
        {
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"Машина едет со скоростью - {Speed}");
        }
    }
}
