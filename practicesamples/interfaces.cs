using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    interface Iname
    {
        void getname(string a);
    }
    class interfaces:Iname
    {
        public void getname(string a)
        {
            Console.WriteLine("Name:{0}",a);
        }
    }
}
