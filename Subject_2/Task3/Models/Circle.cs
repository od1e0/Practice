using System;

namespace Task3.Models
{
    public class Circle
    {
        private double _x, _y, _radius;

        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }
        public double Radius { get => _radius; set => _radius = value; }


        public Circle(double x, double y, double radius)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public double Circumference()
        {
            return 2 * Math.PI * _radius;
        }

        public bool IsPointInside(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x - _x, 2) + Math.Pow(y - _y, 2));
            return distance <= _radius;
        }

        public override string ToString()
        {
            return $"Круг с центром в ({_x}, {_y}) и радиусом {_radius}";
        }
    }
}
