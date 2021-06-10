using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    class methods
    {
        public void method1()
        {
            Console.WriteLine("No arguments & No return values");
        }
        public void method2(int a,int b)
        {
            Console.WriteLine("With arguments & No return values");
            Console.WriteLine(a+b);
        }
        public int method3(int a,int b)
        {
            Console.WriteLine("With arguments & With return values");
            int sum = a + b;
            return sum;
        }
        public int method4()
        {
            Console.WriteLine("No arguments & With return values");
            return 2;
        }
    }
}
