using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Observer2
    {
        public void OnMyEvent(string message)
        {
            Console.WriteLine($"Observer2 received: {message}");
        }
    }
}
