using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace samplespractice
{
    class multithreading
    {
        public static void test1()
        {
            Console.WriteLine("Thread1 Started.");
            for (int i=0;i<=50;i++)
                Console.WriteLine("test1:"+i);
            Thread.Sleep(15000);
            Console.WriteLine("Thread1 exited.");
        }
        public static void test2()
        {
            Console.WriteLine("Thread2 Started.");
            for (int i = 0; i <=50; i++) 
                Console.WriteLine("test2:" + i);
            Console.WriteLine("Thread2 exited");
        }
        
        public static void test3()
        {
            Console.WriteLine("Thread3 Started.");
            for (int i = 0; i <= 50; i++)
                Console.WriteLine("test3:" + i);
            Console.WriteLine("Thread3 exited");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Mainthread Started.");
            Thread t1 = new Thread(test1);
            Thread t2 = new Thread(test2);
            Thread t3 = new Thread(test3);
            t1.Start(); t2.Start(); t3.Start();
            t2.Priority = ThreadPriority.Highest;
            t3.Priority = ThreadPriority.Lowest;
            t1.Join(3000);t2.Join();t3.Join();
            Console.WriteLine("Mainthread Exited.");
        }
    }

}
