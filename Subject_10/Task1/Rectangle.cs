using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Rectangle : Square
    {
        private double sideDifference;

        public Rectangle(string name, double side, double sideDifference)
            : base(name, side)
        {
            this.sideDifference = sideDifference;
        }

        public double SideDifference
        {
            get { return sideDifference; }
            set { sideDifference = value; }
        }

        public override double Area()
        {
            return Side * (Side + sideDifference);
        }

        public override string ToString()
        {
            return $"Rectangle: {Name}, Side: {Side}, Side Difference: {sideDifference}, Area: {Area()}";
        }
    }
}
