using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace practicesamples
{
    class generics
    {
        public void genericmethod<T>(T a,T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1+d2);
        }
    }
    class generics2<T>
    {
        public void add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1+d2);
        }
        public void sub(T a,T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void mul(T a,T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
    }
    class simple
    {
        static void Main(string[] args)
        {
            generics g = new generics();
            g.genericmethod<float>(12.3f,12.3f);
            g.genericmethod(100, 200);
            generics2<int> g2 = new generics2<int>();
            g2.add(12, 22);
            g2.sub(100, 20);
            g2.mul(10, 5);
        }
    }
}
