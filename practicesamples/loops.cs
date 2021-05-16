using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    class loops
    {
        public void loop1()
        {
            Console.WriteLine("For Loop");
            for(int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void loop2()
        {
            Console.WriteLine("While Loop");
            int n = 1;
            while (n <= 4)
            {
                Console.WriteLine(n);
                n++;
            }
        }
        public void loop3()
        {
            Console.WriteLine("DoWhile Loop");
            int n =1;
            do
            {
                Console.WriteLine(n);
                n++;
            } while (n<4);
        }
    }
}
