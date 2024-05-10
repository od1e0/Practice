using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Journey
    {
        public string Destination { get; set; }
        public DateTime? StartDate { get; set; } 
        public DateTime? EndDate { get; set; } 

        public Journey(string destination, DateTime? startDate = null, DateTime? endDate = null)
        {
            Destination = destination;
            StartDate = startDate;
            EndDate = endDate;
        }

        public Journey Clone()
        {
            return new Journey(Destination, StartDate, EndDate);
        }
    }
}
