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
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

            myDictionary.Add("one", 1);
            myDictionary.Add("two", 2);
            myDictionary.Add("three", 3);

            Console.WriteLine($"Значение для 'one': {myDictionary["one"]}");
            Console.WriteLine($"Значение для 'two': {myDictionary["two"]}");
            Console.WriteLine($"Значение для 'three': {myDictionary["three"]}");

            Console.WriteLine($"Общее количество пар элементов: {myDictionary.Count}");

            Console.ReadLine();
        }
    }
}
