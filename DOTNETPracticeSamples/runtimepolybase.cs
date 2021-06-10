using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    class runtimepolybase
    {
        public virtual void message()
        {
            Console.WriteLine("This is Base class");
        }
    }
    class derivedclass : runtimepolybase
    {
        public override void message()
        {
            Console.WriteLine("This is Derived class");
        }
    }
}
