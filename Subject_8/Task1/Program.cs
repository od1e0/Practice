using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Spectre.Console.AnsiConsole;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Marsh[] marshes = new Marsh[8];
            Random random = new Random();

            string[] points = { "Точка A", "Точка B", "Точка C", "Точка D", "Точка E", "Точка F", "Точка G", "Точка H" };

            for (int i = 0; i < 8; i++)
            {
                marshes[i].StartPoint = points[random.Next(points.Length)];
                marshes[i].EndPoint = points[random.Next(points.Length)];
                marshes[i].RouteNumber = i + 1;
            }

            marshes = marshes.OrderBy(m => m.RouteNumber).ToArray();

            string point = Ask<string>("Введите название пункта:");

            var matchedRoutes = marshes.Where(m => m.StartPoint == point || m.EndPoint == point).ToArray();

            if (matchedRoutes.Length == 0)
            {
                MarkupLine("[red]Маршрутов, которые начинаются или заканчиваются в данном пункте, не найдено.[/]");
            }
            else
            {
                foreach (var route in matchedRoutes)
                {
                    MarkupLine($"Номер маршрута: [green]{route.RouteNumber}[/], Начальный пункт: [green]{route.StartPoint}[/], Конечный пункт: [green]{route.EndPoint}[/]");
                }
            }

            Ask<string>("");
        }
    }
}
