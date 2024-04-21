using System;
using static Spectre.Console.AnsiConsole;

namespace Task4
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int[,] residents = new int[12, 4]; 
            int residentsOnThirdFloor = 0, residentsOnFifthFloor = 0;

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    residents[i, j] = rand.Next(1, 5);

                    if (i == 2) 
                        residentsOnThirdFloor += residents[i, j];
                    if (i == 4) 
                        residentsOnFifthFloor += residents[i, j];
                }
            }

            if (residentsOnThirdFloor > residentsOnFifthFloor)
                MarkupLine("На [green]третьем[/] этаже проживает больше людей.");
            else if (residentsOnThirdFloor < residentsOnFifthFloor)
                MarkupLine("На [green]пятом[/] этаже проживает больше людей.");
            else
                MarkupLine("На [green]третьем[/] и [green]пятом[/] этажах проживает одинаковое количество людей.");

            System.Console.ReadLine();
        }
    }
}
