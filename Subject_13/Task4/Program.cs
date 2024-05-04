using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventPublisher publisher = new EventPublisher();
            Observer1 observer1 = new Observer1();
            Observer2 observer2 = new Observer2();

            publisher.MyEvent += observer1.OnMyEvent;
            publisher.MyEvent += observer1.OnMyEvent;
            publisher.MyEvent += observer2.OnMyEvent;

            publisher.TriggerEvent("Привет, наблюдатель");

            publisher.MyEvent -= observer1.OnMyEvent;

            publisher.TriggerEvent("Снова привет, наблюдатель");

            Console.ReadLine();
        }
    }
}
