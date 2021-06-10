using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    //Using struct constraint
    class structconstraint<T> where T : struct
    {
        public void compare(T a, T b)
        {
            if (a.Equals(b))
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");
        }
    }
    //using unmanged constraint
    class unmangedconstraint<T> where T:unmanaged
    {
        public void compare(T a, T b)
        {
            if (a.Equals(b))
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");
        }
    }
    //Using class constraint
    class classconstraint<T>where T : class
    {
        public void compare(T a, T b)
        {
            if (a.Equals(b))
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");
        }
    }
    //Using new() constraint
    class firstclass
    {
        public int a;
        public firstclass()
        {
        }
    }
    class secondclass
    {
        public int a;
        public secondclass(int b)
        {
            this.a = b;
        }

    }
    class newconstraint<T>where T : new()
    {
        public void display()
        {
            Console.WriteLine("newconstraint");
        }
    }
    //Using baseclass name constraint
    class parentclass
    {
        public int a;
    }
    class childclass1:parentclass
    {
        public int b;
    }
    class childclass2
    {
        public int a;
    }
    class baseclassnameconstraint<T>where T :parentclass
    {
        public void display()
        {
            Console.WriteLine("baseclass name constraint");
        }
    }
    //Using interface name constraint
    interface profile
    {
       void profiledetails(string name);
    }
    class oneclass : profile
    {
        public void profiledetails(string s)
        {
            Console.WriteLine(s);
        }
    }
    class twoclass
    {
        public string a;
    }
    class interfacenameconstraint<T>where T : profile
    {
        public void display()
        {
            Console.WriteLine("interface name constraint");
        }
    }
    public class genericconstraints
    {
        static void Main(string[] args)
        {
            structconstraint<int> sc = new structconstraint<int>();
            sc.compare(10, 20);
            unmangedconstraint<int> uc = new unmangedconstraint<int>();
            uc.compare(10, 10);
            classconstraint<string> cc = new classconstraint<string>();
            cc.compare("Hello", "Hello");
            newconstraint<firstclass> nc = new newconstraint<firstclass>();
            nc.display();
            baseclassnameconstraint<childclass1> bc = new baseclassnameconstraint<childclass1>();
            bc.display();
            interfacenameconstraint<oneclass> ic = new interfacenameconstraint<oneclass>();
            ic.display();
        }
    }
}
