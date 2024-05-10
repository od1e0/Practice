using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class MyTask
    {
        private Queue<char> nonDigitQueue = new Queue<char>();
        private Queue<char> digitQueue = new Queue<char>();

        public void ReadFile(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                int c;
                while ((c = sr.Read()) != -1)
                {
                    FillQueues((char)c);
                }
            }
        }

        private void FillQueues(char character)
        {
            if (Char.IsDigit(character))
            {
                digitQueue.Enqueue(character);
            }
            else
            {
                nonDigitQueue.Enqueue(character);
            }
        }

        public void PrintElements()
        {
            while (nonDigitQueue.Count > 0)
            {
                Console.Write(nonDigitQueue.Dequeue());
            }

            while (digitQueue.Count > 0)
            {
                Console.Write(digitQueue.Dequeue());
            }
        }
    }
}
