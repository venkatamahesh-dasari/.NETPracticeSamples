using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    class dictionary
    {
        public void dictionary1()
        {
            IDictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Hello");
            d.Add(2, "Hii");
            d.Add(3, "Welcome");
            foreach (KeyValuePair<int,string> b in d)
            {
                Console.WriteLine("S.no:{0},\tName:{1}",b.Key,b.Value);
            }
            Console.WriteLine(d[1]);
        }
        public void dictionary2()
        {
            var cities = new Dictionary<string, string>()
            {
                {"uk","London, Manchester, Birmingham" },
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };
            foreach(var ci in cities)
            {
                Console.WriteLine("country:{0},\tcities:{1}",ci.Key,ci.Value);
            }
        }
    }
}
