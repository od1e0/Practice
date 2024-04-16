using System;
using System.Collections.Generic;
using Spectre.Console;


namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var k = AnsiConsole.Ask<int>("Введите номер карты: ");

            var cardNames = new Dictionary<int, string>
            {
                {14, "Туз"}, {13, "Король"}, {12, "Дама"},
                {11, "Валет"}, {10, "Десятка"}, {9, "Девятка"},
                {8, "Восьмерка"}, {7, "Семерка"}, {6, "Шестерка"}
            };
            if (cardNames.ContainsKey(k))
                Console.WriteLine($"Ваша карта - {cardNames[k]}");
            else
                Console.WriteLine("Номер карты не входит в допустимый диапазон");

            Console.ReadKey();
        }

    }
}
