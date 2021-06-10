using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    static class extendmethods
    {
        public static int display3(this projectclass pc,int a,int b)
        {
            return a * b;
        }
        public static void display4(this projectclass pcc)
        {
            Console.WriteLine(pcc);
        }
        public static string perfectnumber(this Int32 a)
        {
            int sum = 1;
            for(int i = 2; i < a; i++) 
            {
                if (a % i == 0)
                    sum  += i;
            }
            if (sum == a)
                return a + "\tis Perfectnumber";
            else
                return a+ "\tis Not Perfect number";
        }
        static void Main(string[] args)
        {
            int i =28;
            string s=i.perfectnumber();
            Console.WriteLine(s);
        }
    }
}
