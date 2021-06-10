using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    class constructors
    {
        public int a;
        public string name;
        public constructors()
        {
            a = 10;
            name = "Hello";
        }
        public constructors(int n, string s)
            {
               a = n;
               name = s;
            }
    }
}
