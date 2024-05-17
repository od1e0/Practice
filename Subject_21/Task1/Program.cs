using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new Context(new ConcreteStateA());
            c.Request();
            c.Request();

            Console.ReadLine();
        }
    }
}
