using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Observer1
    {
        public void OnMyEvent(string message)
        {
            Console.WriteLine($"Observer1 received: {message}");
        }
    }
}
