using System;
using static Spectre.Console.AnsiConsole;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double A = Ask<double>("Введите значение A: ");
                double B = Ask<double>("Введите значение B: ");
                double C = Ask<double>("Введите значение C: ");
                double D = Ask<double>("Введите значение D: ");

                if (A < -100 || A > 100 || B < -100 || B > 100 || C < -100 || C > 100 || D < -100 || D > 100)
                {
                    throw new Exception("Введенное значение выходит за допустимый диапазон (-100, 100).");
                }

                Minmax(ref A, ref B);
                Minmax(ref A, ref C);
                Minmax(ref A, ref D);
                Minmax(ref B, ref C);
                Minmax(ref B, ref D);
                Minmax(ref C, ref D);

                WriteLine("Минимальное значение: " + A);
                WriteLine("Максимальное значение: " + D);
            }
            catch (FormatException)
            {
                WriteLine("Ошибка формата. Пожалуйста, введите число.");
            }
            catch (Exception ex)
            {
                WriteLine("Произошла ошибка: " + ex.Message);
            }

            System.Console.ReadKey();
        }

        static void Minmax(ref double X, ref double Y)
        {
            if (X > Y)
            {
                double temp = X;
                X = Y;
                Y = temp;
            }
        }
        
    }
}
