using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Models;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(120);
            car.Move();

            Express express = new Express(135);
            express.Move();

            Train train = new Train(110);
            train.Move();

            Console.ReadKey();
        }
    }
}
