﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("New_folder");
            Console.WriteLine("Папка создана");
            Console.ReadLine();
        }
    }
}
