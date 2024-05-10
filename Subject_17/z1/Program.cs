using System;
using AcademicPerformanceLibrary;
using MyLib;

namespace z1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Triangle triangle = new Triangle(1, 3, 2);
            //Rectangle rectangle = new Rectangle(5, 4);

            //Console.WriteLine($"Периметр прямоугольника: {rectangle.CalculatePerimeter()}");
            //Console.WriteLine($"Площадь прямоугольника: {rectangle.CalculateArea()}");
            //Console.WriteLine($"Периметр треугольника: {triangle.CalculatePerimeter()}");
            //Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
            //Console.WriteLine($"Тип треугольника: {triangle.DetermineType()}");

            //Console.ReadLine();


            IGradeBookRepository repository = new GradeBookRepository();
            GradeBookService gradeBookService = new GradeBookService(repository);

            gradeBookService.AddStudent("Вова", 1);
            gradeBookService.AddStudent("Ангелина", 2);
            gradeBookService.AddGrade(1, 85);
            gradeBookService.AddGrade(1, 90);
            gradeBookService.AddGrade(2, 25);
            gradeBookService.AddGrade(2, 35);

            double averageGrade = gradeBookService.CalculateAverageGrade(1);
            double averageGrade1 = gradeBookService.CalculateAverageGrade(2);
            Console.WriteLine($"Средняя оценка Вовы: {averageGrade}");
            Console.WriteLine($"Средняя оценка Ангелины: {averageGrade1}");

            Console.ReadLine();

        }
    }
}