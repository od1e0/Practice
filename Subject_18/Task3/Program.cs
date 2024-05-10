using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Journey> journeyList = new List<Journey>();
            Dictionary<string, Journey> journeyDict = new Dictionary<string, Journey>();

            Journey journey1 = new Journey("Paris", DateTime.Now);
            journeyList.Add(journey1);
            journeyDict.Add(journey1.Destination, journey1);

            Journey journey2 = journey1.Clone();
            journey2.Destination = "London";
            journeyList.Add(journey2);
            journeyDict.Add(journey2.Destination, journey2);

            foreach (var journey in journeyList)
            {
                Console.WriteLine($"Направлнение: {journey.Destination}, StartDate: {journey.StartDate}, EndDate: {journey.EndDate}");
            }

            journeyList.Remove(journey1);
            journeyDict.Remove(journey1.Destination);

            foreach (var journey in journeyList)
            {
                Console.WriteLine($"Направлнение: {journey.Destination}, StartDate: {journey.StartDate}, EndDate: {journey.EndDate}");
            }

            Console.ReadLine();
        }
    }
}
