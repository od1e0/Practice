using System;

namespace MyLib
{
    public class Rectangle
    {
        private double length;
        private double weight;
        
        public double Length
        {
            get => length;
            set => length = value > 0 ? value : throw new ArgumentException("Длина должна быть больше нуля.");
        }
        
        public double Weight
        {
            get => weight;
            set => weight = value > 0 ? value : throw new ArgumentException("Ширина должна быть больше нуля.");
        }

        public Rectangle(double length, double weight)
        {
            Length = length;
            Weight = weight;
        }
        
        public double CalculatePerimeter() => 2 * (Length + Weight);
        
        public double CalculateArea() => Length * Weight;
    }
}