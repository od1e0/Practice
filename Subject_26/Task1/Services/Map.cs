using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Task1.Models;

namespace Task1.Services
{
    public class Map
    {
        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
        }

        public Map(string filePath)
        {
            _filePath = filePath;
        }

        public List<Country> LoadCountries()
        {
            List<Country> countries = new List<Country>();

            try
            {
                if (File.Exists(_filePath))
                {
                    XDocument doc = XDocument.Load(_filePath);
                    foreach (XElement element in doc.Root.Elements("Country"))
                    {
                        string name = element.Element("Name").Value;
                        double area = double.Parse(element.Element("Area").Value);
                        int population = int.Parse(element.Element("Population").Value);
                        countries.Add(new Country(name, area, population));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading countries: " + ex.Message);
            }

            return countries;
        }

        public void SaveCountry(Country country)
        {
            try
            {
                XDocument doc;
                if (File.Exists(_filePath))
                {
                    doc = XDocument.Load(_filePath);
                }
                else
                {
                    doc = new XDocument(new XElement("Map"));
                }

                XElement countryElement = country.ToXElement();
                doc.Root.Add(countryElement);
                doc.Save(_filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving country: " + ex.Message);
            }
        }
    }
}
