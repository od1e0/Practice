using System;

namespace Task4
{
    class Program
    {
        public delegate int RandomDelegate();

        static void Main(string[] args)
        {
            Random random = new Random();

            RandomDelegate[] delegates = new RandomDelegate[3];
            delegates[0] = () => random.Next(1, 100);
            delegates[1] = () => random.Next(1, 100);
            delegates[2] = () => random.Next(1, 100);

            Func<RandomDelegate[], double> Average = (delArray) =>
            {
                double sum = 0;
                foreach (var del in delArray)
                {
                    sum += del();
                }
                return sum / delArray.Length;
            };

            Console.WriteLine($"Среднее арифметическое: {Average(delegates)}");

            Console.ReadLine();
        }
    }
}
