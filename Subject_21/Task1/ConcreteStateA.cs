using System;

namespace Task1
{
    public class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Handling in State A");
            context.State = new ConcreteStateB();
        }
    }
}
