using System;

    namespace Task1_2
    {
        public class Program
        {
            public delegate string ColorDelegate();

            public static void Main()
            {
                try
                {
                    ColorDelegate color1 = new ColorDelegate(ReturnRed);
                    ColorDelegate color2 = new ColorDelegate(ReturnGreen);
                    ColorDelegate color3 = new ColorDelegate(ReturnBlue);

                    Console.WriteLine(color1());
                    Console.WriteLine(color2());
                    Console.WriteLine(color3());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                }

                Console.ReadLine();
            }

            public static string ReturnRed()
            {
                return "Красный";
            }

            public static string ReturnGreen()
            {
                return "Зеленый";
            }

            public static string ReturnBlue()
            {
                return "Синий";
            }
        }
    }
