using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    public delegate int division(int a, int b);
    public delegate string message(string s);
    public delegate int add(int a, int b);
    class lambdaexpressions
    {
        static void Main(string[] args)
        {
            //Anonymous method
            division dv = delegate (int a, int b)
              {
                  return a / b;
              };
            int d=dv.Invoke(10, 2);
            Console.WriteLine(d);
            message m = (s) =>
            {
                return "Hello\t"+ s +  "\tWelcome to visual Studio";
            };
            string a=m.Invoke("Mahesh");
            Console.WriteLine(a);
            add ad = (a, b) =>
            {
                return a+b;
            };
            int c=ad.Invoke(10, 200);
            Console.WriteLine(c);
        }
    }
}
