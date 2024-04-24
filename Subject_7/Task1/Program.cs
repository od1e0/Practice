using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            Regex regex = new Regex(@"(\+?1\s?)?((\(\d{3}\))|\d{3})[\s\-]?\d{1,2}[\s\-]?\d{1,2}[\s\-]?\d{1,2}[\s\-]?\d{1,2}");

            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

            Console.ReadLine();
        }
    }
}
