using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    class nullabletypes
    {
        public void nullablemethod1()
        {
            int? x = null;
            if (x.HasValue)
                Console.WriteLine(x);
            else
                Console.WriteLine("No Value");
            Console.WriteLine("X value is:{0}",x.GetValueOrDefault());
        }
        public void nullablemethod2()
        {
            Nullable<int> a = 10;
            if(a!=null)
                Console.WriteLine("a value:{0}",a.Value);
            else
                Console.WriteLine("No Value");
        }
        public void nullablemethod3()
        {
            int? x = null;
            int y = x ?? 100;
            Console.WriteLine("X Value:{0}\nY Value:{1}",x.GetValueOrDefault(),y);
        }
    }
}
