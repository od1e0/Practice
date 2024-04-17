using System;
using Task3.Models;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(4, 5, 4);
            Console.WriteLine(circle.ToString());
            Console.WriteLine($"Длина окружности: {circle.Circumference()}");
            Console.WriteLine($"Площадь: {circle.Area()}");
            Console.WriteLine(circle.IsPointInside(3,3) ? "Точка попадает в окружность" : "Точка не попадает в окружность");

            Console.ReadKey();
        }
    }
}
