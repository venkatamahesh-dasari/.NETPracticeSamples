using System;
using practice.nestednamespace;

namespace practicesamples
{
    class Program
    {
        static void delegatemethod(parameterdelegatemethod pdm,int a,int b)
        {
            pdm(a, b);
        }
        static void Main(string[] args)
        {
            operators op = new operators();
            op.Arithmetic(10, 20);
            op.Relational(20, 30);
            op.Logical();
            conditional cl = new conditional();
            cl.statement1(23);
            cl.statement2(1);
            loops ls = new loops();
            ls.loop1();
            ls.loop2();
            ls.loop3();
            ls.loop4();
            jump jm = new jump();
            jm.statement1();
            jm.statement2();
            jm.statement3();
            methods md = new methods();
            md.method1();
            md.method2(10,20);
            int sum = md.method3(100, 200);
            Console.WriteLine(sum);
            int a = md.method4();
            Console.WriteLine(a);
           array ar = new array();
           ar.singledimensionarray();
           ar.multidimensionarray();
           ar.jaggedarray();
           lists li = new lists();
           li.list1();
           li.list2();
           li.list3();
           dictionary dr = new dictionary();
           dr.dictionary1();
            dr.dictionary2();
            mystruct m1;
            m1.i = 10;
            m1.display();
            enumerated en = new enumerated();
            en.enum1();
            properties pro= new properties();
            pro.propertie1();
            pro.propertie2();
            Classes cs = new Classes();
            cs.name = "Hello";
            cs.classes1();
            constructors con = new constructors();
            constructors con1 = new constructors(100, "Hi");
            Console.WriteLine(con1.name);
            Console.WriteLine(con1.a);
            namespaces ns = new namespaces();
            ns.namespace1();
            ns.namespace2();
            Iname na = new interfaces();
            na.getname("Mahesh");
            multipleinheritance mi = new multipleinheritance();
            mi.name("Mahesh");
            mi.location("BVRM");
            mi.age(23);
            compiletimepolymorphism cp = new compiletimepolymorphism();
            cp.addition(200, 300);
            cp.addition(100, 200, 300);
            runtimepolybase rb = new runtimepolybase();
            rb.message();
            derivedclass dc = new derivedclass();
            dc.message();
           derived d = new derived();
           d.name = "Mahesh";
           d.age = 23;
           d.getlocation("BVRM");
           d.getage();
           C c = new C();
           c.name = "Mahesh";
           c.Name();
           c.Age(23);
           c.Location("BVRM");
           encapsulation es = new encapsulation();
            es.Productname = "IPhone";
            es.Price = 60000;
            es.Price = 20000;
            es.Price = 70000;
            es.display();
            singledelegate sd = new singledelegate();
            delegatemethod dm= sd.addition;
            dm.Invoke(100, 200);
            dm = sd.multiplication;
            dm.Invoke(10, 5);
            multidelegate mld = new multidelegate();
            multidelegatemethod mdm;
            mdm = mld.addition;
            mdm += mld.subtraction;
            mdm += mld.multiplication;
            mdm -= mld.multiplication;
            mdm(5, 10);
            parameterdelegate pd = new parameterdelegate();
            delegatemethod(pd.add, 200, 200);
            delegatemethod(pd.sub, 200, 700);
            delegatemethod(pd.mul, 10, 10);
        }
    }
}
