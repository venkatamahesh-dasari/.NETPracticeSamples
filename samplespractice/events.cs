using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    class publish
    {
        public delegate void delegatemethod();
        public event delegatemethod ev;
        public void add()
        {
            int result;
            result = 5 + 4;
            Console.WriteLine(result);
            if (result % 2 != 0 && ev != null)
            {
                ev();
            }
        }
    }
    class events
    {
        static void Main(string[] args)
        {
            publish p = new publish();
            p.ev += new publish.delegatemethod(eventmethod);
            p.add();
            static void eventmethod()
            {
                Console.WriteLine("Event Executed : This is ood number");
            }
        }
    }
}
