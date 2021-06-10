using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace samplespractice
{
    class concatenationoperator
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 2, 10,11, 4, 5 };
            List<int> list2 = new List<int>() { 2,  4,6,8,10 };
            var concatenation = list1.Concat(list2);
            foreach(var i in concatenation)
                Console.WriteLine(i);
            Console.WriteLine("***************************");
            var concat = list1.Union(list2);
            foreach (var i in concat)
                Console.WriteLine(i);
        }
    }
}
