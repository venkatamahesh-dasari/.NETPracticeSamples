using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    interface IName
    {
        void name(string a);
    }
    interface Ilocation
    {
        void location(string a);
    }
    interface Iage
    {
        void age(int a);
    }
    class multipleinheritance:IName,Ilocation,Iage
    {
        public void name(string a)
        {
            Console.WriteLine("Name:{0}",a);
        }
        public void location(string a)
        {
            Console.WriteLine("Location:{0}",a);
        }
        public void age(int a)
        {
            Console.WriteLine("Age:{0}",a);
        }
    }
}
