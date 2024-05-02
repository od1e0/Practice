using System;

namespace Task1
{
    internal class Program : Ix, Iy, Iz
    {
            private int w; 

            public void IxF0(int parameter)
            {
                Console.WriteLine($"Ix.IxF0 вызван с параметром: {parameter}");
            }

            public void IxF1()
            {
                Console.WriteLine("Ix.IxF1 вызван");
            }

            public void F0(int parameter)
            {
                Console.WriteLine($"Iy.F0 вызван с параметром: {parameter}");
                w = parameter;
            }

            public void F1()
            {
                Console.WriteLine("Iy.F1 вызван");
                w = 10;

              
                ((Iz)this).F0(w);
                ((Iz)this).F1();

                Iz izReference = this;
                izReference.F0(w);
                izReference.F1();
            }

            void Iz.F0(int parameter)
            {
                Console.WriteLine($"Явно реализованный Iz.F0 вызван с параметром: {parameter}");
                w = 10 * parameter;
            }

        void Iz.F1()
        {
            Console.WriteLine("Явно реализованный Iz.F1 вызван");
            w = 10 / 2;
        }
        

        static void Main(string[] args)
        {

            Program test = new Program();

            test.IxF0(10);
            test.IxF1();

            test.F0(20);
            test.F1();

            ((Iz)test).F0(30);
            ((Iz)test).F1();

            Console.ReadLine();
        }
    }
}
