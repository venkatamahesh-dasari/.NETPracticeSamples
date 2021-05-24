using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    class compiletimepolymorphism
    {
        public void addition(int a,int b)
        {
            Console.WriteLine("a+b:{0}",a+b);
        }
        public void addition(int a,int b,int c)
        {
            Console.WriteLine("a+b+c:{0}",a+b+c);
        }
    }
}
