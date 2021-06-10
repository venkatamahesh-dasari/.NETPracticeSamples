using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    public class multilevelInheritanceA
    {
        public string name;
        public void Name()
        {
            Console.WriteLine("Name:{0}",name);
        }
    }
    public class B : multilevelInheritanceA
    {
        public void Location(string location)
        {
            Console.WriteLine("Location:{0}",location);
        }
    }
    public class C : B
    {
        public void Age(int age)
        {
            Console.WriteLine("Age:{0}",age);
        }
    }
}
