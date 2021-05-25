using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    public delegate void parameterdelegatemethod(int a, int b);
    class parameterdelegate
    {
        public void add(int a,int b)
        {
            Console.WriteLine("a+b:{0}",a+b);
        }
        public void sub(int a,int b)
        {
            Console.WriteLine("a-b:{0}",a-b);
        }
        public void mul(int a,int b)
        {
            Console.WriteLine("a*b:{0}",a*b);
        }
    }
}
