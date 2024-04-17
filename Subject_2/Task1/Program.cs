using System;
using Task1.Models;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите а: ");
            int numA = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int numB = int.Parse(Console.ReadLine());

            A a = new A(numA, numB);

            Console.WriteLine($"вызов метода вычисления значения выражения: {a.СalculatExpressionValues()}");
            Console.WriteLine($"вызов метода возведения в куб частного a и b: {a.CalculateCube()}");

            Console.ReadKey();
        }
    }
}
