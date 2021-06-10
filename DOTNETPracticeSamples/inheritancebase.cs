using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    public class inheritancebase
    {
        public string name;
        private string location;
        public inheritancebase()
        {
            Console.WriteLine("This is Base Class constructor");
        }
        public void getlocation(string a)
        {
            location = a;
            Console.WriteLine("Name:{0}\nlocation:{1}",name,location);
        }
    }
   public class derived: inheritancebase
    {
        public int age;
        public derived()
        {
            Console.WriteLine("This is Derived Class constructor");
        }
        public void getage()
        {
            Console.WriteLine("age:"+age);
        }
    }
}
