using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Делегат для выполнения операций над строками.
        /// </summary>
        public delegate string StringDelegate(string s);

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main(string[] args)
        {
            StringDelegate SD;

            SD = ToUpper;
            Console.WriteLine(SD("hello"));

            SD = ToLower;
            Console.WriteLine(SD("WORLD"));

            SD = Reverse;
            Console.WriteLine(SD("12345"));

            Console.ReadLine();
        }

        /// <summary>
        /// Метод для преобразования строки в верхний регистр.
        /// </summary>
        /// <param name="s">Входная строка.</param>
        /// <returns>Возвращает строку в верхнем регистре.</returns>
        public static string ToUpper(string s)
        {
            return s.ToUpper();
        }

        /// <summary>
        /// Метод для преобразования строки в нижний регистр.
        /// </summary>
        /// <param name="s">Входная строка.</param>
        /// <returns>Возвращает строку в нижнем регистре.</returns>
        public static string ToLower(string s)
        {
            return s.ToLower();
        }

        /// <summary>
        /// Метод для обращения строки.
        /// </summary>
        /// <param name="s">Входная строка.</param>
        /// <returns>Возвращает обратную строку.</returns>
        public static string Reverse(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
