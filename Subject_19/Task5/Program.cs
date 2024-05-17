using System;
using Task5.Models;
using static Spectre.Console.AnsiConsole;

namespace Task5
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main(string[] args)
        {
            // Создание нового объекта поезда
            Train train = new Train("Moscow", "123A", DateTime.Now);

            // Вывод информации о поезде
            MarkupLine($"Направление: [green]{train.Destination}[/]");
            MarkupLine($"Номер поезда: [green]{train.TrainNumber}[/]");
            MarkupLine($"Время отправления: [green]{train.DepartureTime}[/]");

            System.Console.ReadKey();
        }
    }
}
