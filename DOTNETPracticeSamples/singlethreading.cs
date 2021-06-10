using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace samplespractice
{
    class singlethreading
    {
        public static void testing1()
        {
            long count1=0;
            for (long i = 1; i <= 1000000000; i++)
                count1 += 1;
            Console.WriteLine("testing1:"+count1);
        }
        public static void testing2()
        {
            long count2 = 0;
            for (long i = 1; i <= 1000000000; i++)
                count2 += 1;
            Console.WriteLine("testing2:"+count2);
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(testing1);
            Thread t2 = new Thread(testing2);
            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();
            s1.Start();
            testing1();
            testing2();
            s1.Stop();
            s2.Start();
            t1.Start();
            t2.Start();
            s2.Stop();
            t1.Join();
            t2.Join();
            Console.WriteLine("Single Threading:"+s1.ElapsedMilliseconds);
            Console.WriteLine("Multi Threading:"+s2.ElapsedMilliseconds);
        }
    }
}
