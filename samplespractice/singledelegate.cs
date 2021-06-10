using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    public delegate void delegatemethod(int a, int b);
    class singledelegate
    {
        public void addition(int x,int y)
        {
            Console.WriteLine("x+y:{0}",x+y);
        }
        public void multiplication(int x,int y)
        {
            Console.WriteLine("x*y:{0}",x*y);
        }
    }
}
