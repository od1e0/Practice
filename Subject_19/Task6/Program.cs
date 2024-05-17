using System;

namespace Task1
{
    public class Program
    {
        /// <summary>
        /// Делегат для выполнения математических операций над фигурами.
        /// </summary>
        public delegate double CalcFigure(double r);

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        public static void Main()
        {
            CalcFigure CF;

            CF = Get_Length;
            Console.WriteLine($"Длина окружности: {CF(5)}");

            CF = Get_Area;
            Console.WriteLine($"Площадь круга: {CF(5)}");

            CF = Get_Volume;
            Console.WriteLine($"Объем шара: {CF(5)}");

            Console.ReadLine();
        }

        /// <summary>
        /// Вычисляет длину окружности.
        /// </summary>
        /// <param name="R">Радиус окружности.</param>
        /// <returns>Возвращает длину окружности.</returns>
        public static double Get_Length(double R)
        {
            return 2 * Math.PI * R;
        }

        /// <summary>
        /// Вычисляет площадь круга.
        /// </summary>
        /// <param name="R">Радиус круга.</param>
        /// <returns>Возвращает площадь круга.</returns>
        public static double Get_Area(double R)
        {
            return Math.PI * Math.Pow(R, 2);
        }

        /// <summary>
        /// Вычисляет объем шара.
        /// </summary>
        /// <param name="R">Радиус шара.</param>
        /// <returns>Возвращает объем шара.</returns>
        public static double Get_Volume(double R)
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(R, 3);
        }
    }
}
