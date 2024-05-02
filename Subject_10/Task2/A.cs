using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class A
    {
        private int a = 11;
        private int b = 26;

        public int AValue
        {
            get { return a; }
            set { a = value; }
        }

        public int BValue
        {
            get { return b; }
            set { b = value; }
        }

        public int C
        {
            get
            {
                return a + b; 
            }
        }
    }

}
