using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    class projectclass
    {
        public void display1()
        {
            Console.WriteLine("Dispaly1 Method");
        }
        public void display2()
        {
            Console.WriteLine("Display Method2");
        }
        static void Main(string[] args)
        {
            projectclass pc = new projectclass();
            pc.display1();
            pc.display2();
            int a=pc.display3(2, 5);
            Console.WriteLine(a);
            pc.display4();
        }
    }
}
