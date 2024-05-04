using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyInfo info = new MyInfo("Владимир");
            info.NameChanged += (oldName, newName) =>
            {
                Console.WriteLine($"Имя изменено с {oldName} на {newName}");
            };

            info.Name = "Егор";
            info.Name = "Саша";

            Console.ReadLine();

        }
    }
}
