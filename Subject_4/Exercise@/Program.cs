﻿using System;

namespace Exercise2
{
    internal class Program
    {
        static void Main()
        {
            byte n = 1; byte i;
            try
            {
                checked
                {
                    n = 1;
                    for (i = 1; i < 10; i++) n *= i;
                    Console.WriteLine("1: {0}", n);
                }
                unchecked
                {
                    n = 1;
                    for (i = 1; i < 10; i++) n *= i;
                    Console.WriteLine("2: {0}", n);
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("возникло переполнение");
            }

            Console.ReadKey();
        }

    }
}
