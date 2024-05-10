using System;

namespace MyLib
{
    public class Triangle
    {
        private double firstParty;
        private double secondParty;
        private double thirdParty;

        public double FirstSide
        {
            get => firstParty;
            set => firstParty = value > 0 ? value : throw new ArgumentException("Сторона должна быть больше нуля.");
        }

        public double SecondSide
        {
            get => secondParty;
            set => secondParty = value > 0 ? value : throw new ArgumentException("Сторона должна быть больше нуля.");
        }

        public double ThirdSide
        {
            get => thirdParty;
            set => thirdParty = value > 0 ? value : throw new ArgumentException("Сторона должна быть больше нуля.");
        }

        public Triangle(double firstParty, double secondParty, double thirdParty)
        {
            FirstSide = firstParty;
            SecondSide = secondParty;
            ThirdSide = thirdParty;
        }
        
        public double CalculatePerimeter() => FirstSide + SecondSide + ThirdSide;
        
        public double CalculateArea()
        {
            double semiPerimeter = CalculatePerimeter() / 2;
            return Math.Sqrt(semiPerimeter * 
                             (semiPerimeter - FirstSide) * 
                             (semiPerimeter - SecondSide) * 
                             (semiPerimeter - ThirdSide));
        }
        
        public string DetermineType()
        {
            if (FirstSide == SecondSide && SecondSide == ThirdSide) 
            {
                return "Равносторонний треугольник";
            }
            else if (FirstSide == SecondSide || SecondSide == ThirdSide || FirstSide == ThirdSide)
            {
                return "Равнобедренный треугольник";
            }
            else
            {
                return "Разносторонний треугольник";
            }
        }
    }
}