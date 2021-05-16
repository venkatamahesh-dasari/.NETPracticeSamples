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
            jump jm = new jump();
            jm.statement1();
            jm.statement2();
            jm.statement3();

        }
    }
}
