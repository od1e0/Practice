using System;
using static Spectre.Console.AnsiConsole;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                double x = Ask<double>("Введите значение x: ");

                double f;
                if (-3 < x && x < -1)
                {
                    f = 2 * x;
                }
                else if (-1 < x && x < 3)
                {
                    if (x == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    f = -2 / x;
                }
                else if (x >= 3)
                {
                    f = x;
                }
                else
                {
                    throw new Exception("x выходит за диапазон допустимых значений.");
                }

                WriteLine("f = " + f);
            }
            catch (FormatException)
            {
                WriteLine("Ошибка формата. Пожалуйста, введите число.");
            }
            catch (DivideByZeroException)
            {
                WriteLine("Ошибка деления на ноль. x не должен быть равен 0.");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
