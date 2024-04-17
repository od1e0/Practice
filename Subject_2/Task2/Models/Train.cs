using System;

namespace Task2.Models
{
    public class Train : Vehicle
    {
        public Train(int speed) : base(speed)
        {
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"Поезд начал движение со скоростью - {Speed}");
        }
    }
}

