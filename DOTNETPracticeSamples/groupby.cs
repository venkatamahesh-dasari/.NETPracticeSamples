using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace DOTNETPracticeSamples
{
    class groupby
    {
        static void Main(string[] args)
        {
            var method1 = workers.GetWorkers().GroupBy(x => x.wgender);
            foreach(var item in method1)
            {
                Console.WriteLine(item.Key);
                foreach(var z in item)
                    Console.WriteLine(z.wno+" "+z.wname+" "+z.wsalary+" "+z.wjob+" "+z.wgender+" "+z.wage);
                 
            }
        }
        }
    }
