using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    class properties
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void propertie1()
        {
            properties pr = new properties();
            pr.name = "Hello";
            Console.WriteLine(pr.name);
        }
        int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public void propertie2()
        {
            properties pr = new properties();
            pr.number = 100;
            Console.WriteLine(pr.number);
        }
    }
}
