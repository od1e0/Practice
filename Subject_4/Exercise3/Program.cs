using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f = 1.0000001; // пример
            try
            {
                if (Math.Abs(f - 1) < 0.000001)
                {
                    throw new DivideByZeroException();
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }

            Console.ReadLine();
        }
    }
}
