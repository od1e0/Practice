using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine($"Свойство C объекта класса A: {a.C}");

            B b1 = new B();
            Console.WriteLine($"Свойство C2 объекта класса B (с конструктором по умолчанию): {b1.C2}");

            B b2 = new B(10);
            Console.WriteLine($"Свойство C2 объекта класса B (с пользовательским конструктором): {b2.C2}");

            Console.ReadLine();
        }
    }
}
