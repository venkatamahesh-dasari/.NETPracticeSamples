using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace samplespractice
{
    class multithreadinglocking
    {
        public void method1()
        {
            lock (this)
            {
                Console.Write("[C sharp is ");
                Thread.Sleep(5000);
                Console.WriteLine("object oriented language]");
            }
        }
        static void Main(string[] args)
        {
            multithreadinglocking mtc = new multithreadinglocking();
            Thread t1 = new Thread(mtc.method1);
            Thread t2 = new Thread(mtc.method1);
            Thread t3 = new Thread(mtc.method1);
            t1.Start();t2.Start();t3.Start();
        }
    }
}
