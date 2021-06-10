using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    class conditional
    {
        public void statement1(int n)
        {
            Console.WriteLine("IF");
            if (n >= 18)
                Console.WriteLine("Eligibile for voting");
            else
                Console.WriteLine("Not eligibile");
        }
        public void statement2(int a)
        {
            Console.WriteLine("Switch");
            switch (a)
            {
                case 1:
                    Console.WriteLine("case 1 is executed");
                    break;
                case 2:
                    Console.WriteLine("case 2 is executed");
                    break;
                default:
                    Console.WriteLine("No case is selected");
                    break;
     
            }
        }
    }
}
