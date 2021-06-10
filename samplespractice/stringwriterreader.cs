using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace practicesamples
{
    class stringwriterreader
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            sw.WriteLine(100);
            sw.WriteLine(2000);
            sw.WriteLine(200000);
            sw.WriteLine("Mahesh");
            sw.WriteLine("Hello");
            sw.Flush();
            sw.Close();
            StringReader sr = new StringReader(sb.ToString());
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}
