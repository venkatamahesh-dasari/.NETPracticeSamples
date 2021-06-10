using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    class operators
    {
        public void Arithmetic(int a,int b)
        {
            Console.WriteLine("Arithmetic Operator");
            Console.WriteLine(a+b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
        }
        public void Relational(int a,int b)
        {
            Console.WriteLine("Relational Operator");
            Console.WriteLine(a==b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
        }
        public void Logical()
        {
            Console.WriteLine("Logical Operator");
            Console.WriteLine("AND");
            Console.WriteLine(true&&true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);
            Console.WriteLine("OR");
            Console.WriteLine(true||true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);
        }
    }
}
