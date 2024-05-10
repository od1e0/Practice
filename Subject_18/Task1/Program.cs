using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "abc#d##c";
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c != '#')
                {
                    stack.Push(c);
                }
                else if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            char[] arr = stack.ToArray();
            Array.Reverse(arr);
            Console.WriteLine(new string(arr));

            Console.ReadLine();
        }
    }
}
