using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace practicesamples
{
    class loops
    {
        public void loop1()
        {
            Console.WriteLine("For Loop");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for(int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            sw.Stop();
            Console.WriteLine("Time Taken:"+sw.ElapsedMilliseconds);
        }
        public void loop2()
        {
            Console.WriteLine("While Loop");
            int n = 1;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (n <= 4)
            {
                Console.WriteLine(n);
                n++;
            }
            sw.Stop();
            Console.WriteLine("The Taken:"+sw.ElapsedMilliseconds);
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
        public void loop4()
        {
            Console.WriteLine("FOREACH Loop");
            int[] arr = new int[5] { 10, 20, 30, 40, 50 };
            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
