using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    class jump
    {
        public void statement1()
        {
            Console.WriteLine("Break Statement");
            for(int i = 1; i < 4; i++)
            {
                if (i == 3)
                    break;
                Console.WriteLine(i);
            }
        }
        public void statement2()
        {
            Console.WriteLine("Continue Statement");
            for(int i = 1; i < 5; i++)
            {
                if (i == 2)
                    continue;
                Console.WriteLine(i);
            }
        }
        public void statement3()
        {
            Console.WriteLine("GOTO Statement");
            int i = 1;
        abc:
            Console.WriteLine(i);
            i++;
            if (i < 3)
                goto abc;
        }
    }
}
