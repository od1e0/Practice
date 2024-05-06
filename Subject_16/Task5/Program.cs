using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalNumbers = { 20, 10, 4, -1, -2, 0, 0, 0, -10, 41, 62 };
            File.WriteAllLines("original.txt", originalNumbers.Select(n => n.ToString()));

            int[] numbers = File.ReadAllLines("original.txt").Select(int.Parse).ToArray();

            using (StreamWriter writer = new StreamWriter("result.txt"))
            {
                int sum = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if ((numbers[i] >= 0 && sum >= 0) || (numbers[i] <= 0 && sum <= 0))
                    {
                        sum += numbers[i];
                    }
                    else
                    {
                        writer.WriteLine(sum);
                        sum = numbers[i];
                    }
                }
                writer.WriteLine(sum);
            }

            Console.ReadLine();
        }
    }
}
