using System;

namespace Task1
{
    public class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Handling in State B");
            context.State = new ConcreteStateA();
        }
    }
}
