using System;

namespace Task2.Models
{
    public class Express : Train
    {
        public Express(int speed) : base(speed)
        {
            Speed = speed;
        }

        public void Move() 
        {
            Console.WriteLine($"Экспресс мчит со скоростью - {Speed}!");
        }
    }
}
