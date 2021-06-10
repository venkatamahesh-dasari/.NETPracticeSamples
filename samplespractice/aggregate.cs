using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace samplespractice
{
    class aggregate
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> numbers1 = new List<int>() { 10, 15, 20 };
            int sum = numbers.Sum(x =>
            {
                if (x > 5)
                    return x;
                else
                    return 0;
            });
            Console.WriteLine("Sum:"+sum);
            int max = numbers.Max(x =>
            {
                if (x < 5)
                    return x;
                else
                    return 0;
            });
            Console.WriteLine("max:" + max);
            int min = numbers1.Min(x =>
            {
                if (x > 5)
                    return x;
                else
                    return 0;
            });
            Console.WriteLine("min:" + min);
        }
    }
}
