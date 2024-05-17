using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main(string[] args)
        {
            // Определение делегатов для выполнения математических операций
            Func<double, double, double> Add = (a, b) => a + b;
            Func<double, double, double> Sub = (a, b) => a - b;
            Func<double, double, double> Mul = (a, b) => a * b;
            Func<double, double, double> Div = (a, b) => b != 0 ? a / b : throw new DivideByZeroException();

            Console.WriteLine("Введите два числа:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию (Add, Sub, Mul, Div):");
            string operation = Console.ReadLine();

            double result = 0;
            switch (operation)
            {
                case "Add":
                    result = Add(num1, num2);
                    break;
                case "Sub":
                    result = Sub(num1, num2);
                    break;
                case "Mul":
                    result = Mul(num1, num2);
                    break;
                case "Div":
                    try
                    {
                        result = Div(num1, num2);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    return;
            }

            Console.WriteLine($"Результат: {result}");

            Console.ReadLine();
        }
    }
}
