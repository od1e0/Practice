using System;
using System.Linq;
using static Spectre.Console.AnsiConsole;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = Ask<string>("Введите фамилию, имя и отчество: ");

            int sum = 0;

            foreach (char c in fullName.ToUpper())
            {
                if (Char.IsLetter(c))
                {
                    sum += c - 'А' + 1;
                }
            }

            while (sum > 9)
            {
                sum = sum.ToString().Select(digit => int.Parse(digit.ToString())).Sum();
            }

            WriteLine("Код личности: " + sum);

            System.Console.ReadLine();
        }
    }
}
