using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    class enumerated
    {
        public enum days { Monday, Tuesday, Wednesday, Thursday, Friday }
        public void enum1()
        {
            foreach(int i in Enum.GetValues(typeof(days)))
            {
                Console.Write(i+":"+(days)i+"\t");
            }
            Console.WriteLine( );
            foreach(string s in Enum.GetNames(typeof(days)))
            {
                Console.Write(s+"\t");
            }
        }
    }

}
