using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace samplespractice
{
    class orderby
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 10, 3, 5, 2, 6, 8, 9 ,1,4,7};
            var methodsyntax1 = list1.OrderBy(x=>x);
            foreach(var i in methodsyntax1)
                Console.WriteLine(i);
            Console.WriteLine("************************");
            var querysyntax1 = (from li in list1
                                orderby li
                                select li).ToList();
            foreach(var i in querysyntax1)
                Console.WriteLine(i);
            Console.WriteLine("************************");
            List<string> list2 = new List<string>() { "Mahesh","Hello","Welcome","Action"};
            var methodsyntax2 = list2.OrderBy(x => x);
            foreach (var i in methodsyntax2)
                Console.WriteLine(i);
            Console.WriteLine("************************");
            var querysyntax2 = (from li in list2
                                orderby li ascending
                                select li).ToList();
            foreach (var i in querysyntax2)
                Console.WriteLine(i);
            Console.WriteLine("************************");
            var methodsyntax3 = list1.OrderByDescending(x => x);
            foreach (var i in methodsyntax3)
                Console.WriteLine(i);
            Console.WriteLine("************************");
            var querysyntax3 = (from li in list1
                                orderby li descending
                                select li).ToList();
            foreach (var i in querysyntax3)
                Console.WriteLine(i);
            Console.WriteLine("************************");
            var methodsyntax4 = list2.OrderByDescending(x => x);
            foreach (var i in methodsyntax4)
                Console.WriteLine(i);
            Console.WriteLine("************************");
            var querysyntax4 = (from li in list2
                                orderby li descending
                                select li).ToList();
            foreach (var i in querysyntax4)
                Console.WriteLine(i);
        }
    }
}
