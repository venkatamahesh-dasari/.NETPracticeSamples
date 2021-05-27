using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace practicesamples
{
    class filessystem
    {
        public void binarywriter()
        {
            string fpath = @"D:\Test.txt";
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }
            using(BinaryWriter bw=new BinaryWriter(File.Open(fpath, FileMode.Create))) 
            {
                bw.Write(1.25);
                bw.Write("Hello");
                bw.Write(10);
                bw.Write(true);
                bw.Write("test");
            }
        }
        public void binaryreader()
        {
            string fpath = @"D:\Test.txt";
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }
            using (BinaryWriter bw = new BinaryWriter(File.Open(fpath, FileMode.Create)))
            {
                bw.Write(1.25);
                bw.Write("Hello");
                bw.Write(10);
                bw.Write(true);
                bw.Write("test");
            }
            using (BinaryReader br = new BinaryReader(File.Open(fpath, FileMode.Open)))
            {
                Console.WriteLine(br.ReadDouble());
                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadBoolean());
                Console.WriteLine(br.ReadString());
            }
        }
    }
    
}
