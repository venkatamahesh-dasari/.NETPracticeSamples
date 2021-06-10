using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    class dynamics
    {
        static void details(dynamic a)
        {
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            dynamic a = 10;
            dynamic b = "Hello";  
            dynamic c = true;
            dynamic d = 30.22;
            Console.WriteLine("Value:{0},\ttype:{1}",a,a.GetType());
            Console.WriteLine("Value:{0},\ttype:{1}", b, b.GetType());
            Console.WriteLine("Value:{0},\ttype:{1}", c, c.GetType());
            Console.WriteLine("Value:{0},\ttype:{1}", d, d.GetType());
            details(10);
            details("Hello");
            details(true);
            details(30.22);
        }
    }
}
