using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Square
    {
        private string name;
        private double side;

        public Square(string name, double side)
        {
            this.name = name;
            this.side = side;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        public virtual double Area()
        {
            return side * side;
        }

        public override string ToString()
        {
            return $"Square: {name}, Side: {side}, Area: {Area()}";
        }
    }
}
