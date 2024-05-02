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
            Square square = new Square("Square1", 5);
            Console.WriteLine(square);

            Rectangle rectangle = new Rectangle("Rectangle1", 5, 2);
            Console.WriteLine(rectangle);

            Console.ReadLine();
        }
    }
}
