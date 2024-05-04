using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class EventPublisher
    {
        public delegate void MyEventDelegate(string message);
        public event MyEventDelegate MyEvent;

        public void TriggerEvent(string message)
        {
            MyEvent?.Invoke(message);
        }
    }
}
