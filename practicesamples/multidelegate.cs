using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    public delegate void multidelegatemethod(int a, int b);
    class multidelegate
    {
        public void addition(int a,int b)
        {
            Console.WriteLine("a+b:{0}",a+b);
        }
        public void subtraction(int a,int b)
        {
            Console.WriteLine("a-b:{0}",a-b);
        }
        public void multiplication(int a,int b)
        {
            Console.WriteLine("a*b:{0}",a*b);
        }
    }
}
