using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyTask myTask = new MyTask();
            myTask.ReadFile("C:\\Users\\Вова\\Desktop\\Practice\\Subject_18\\Task2\\input.txt");
            myTask.PrintElements();

            Console.ReadLine();
        }
    }
}
