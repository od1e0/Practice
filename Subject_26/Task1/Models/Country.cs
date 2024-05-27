using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1.Models
{
    public class Country
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public int Population { get; set; }

        public Country(string name, double area, int population)
        {
            Name = name;
            Area = area;
            Population = population;
        }

        public XElement ToXElement()
        {
            return new XElement("Country",
                new XElement("Name", Name),
                new XElement("Area", Area),
                new XElement("Population", Population)
            );
        }
    }
}
