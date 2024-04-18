using System;
using Task5.Models;
using static Spectre.Console.AnsiConsole;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train("Moscow", "123A", DateTime.Now);

            MarkupLine($"Направление: [green]{train.Destination}[/]");
            MarkupLine($"Номер поезда: [green]{train.TrainNumber}[/]");
            MarkupLine($"Время отправления: [green]{train.DepartureTime}[/]");

            System.Console.ReadKey();
        }
    }
}
