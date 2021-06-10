using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace samplespractice
{
    class asyncawait
    {
        private static async void method1()
        {
            int value = await method2();
            Console.WriteLine("The Value is:"+value);
        }
        private static Task<int> method2()
        {
            return Task.Run(()=>
            {
                Thread.Sleep(5000);
                return 1;
            });
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method started");
            method1();
            for(int i = 1; i < 5; i++)
            {
                Console.WriteLine("Forloop value:"+i);
            }
        }
    }
}
