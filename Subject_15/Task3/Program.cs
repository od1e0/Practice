﻿using System;
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
            MyList<int> myList = new MyList<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            int[] array = myList.GetArray();

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
