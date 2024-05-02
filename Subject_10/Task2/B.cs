using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class B: A
    {
        private int d;

        public B() : base()
        {
            this.d = 0;
        }

        public B(int dValue) : base()
        {
            this.d = dValue;
        }

        public int C2
        {
            get
            {
                int result = 0;
                do
                {
                    if (d > 5)
                    {
                        result = AValue + BValue + d;
                    }
                    else
                    {
                        result = AValue * BValue * d;
                    }
                    d--;
                } while (d > 0);

                return result;
            }
        }
    }
}
