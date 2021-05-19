using System;

namespace practicesamples
{
    class Program
    {
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
        }
    }
}
