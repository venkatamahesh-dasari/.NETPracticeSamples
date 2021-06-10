using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace practicesamples
{
    class files
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
        public void fileinfomathod1()
        {
            string fpath = @"D:\Test.txt";
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }
            FileInfo fi = new FileInfo(fpath);
            using(StreamWriter sw = fi.CreateText())
            {
                sw.WriteLine("Hello");
                sw.WriteLine("\nFILEDINFO EXAMPLE");
                sw.WriteLine("\nWelcome to C#");
            }
        }
        public void fileinfomethod2()
        {
            string fpath = @"D:\test.txt";
            if (File.Exists(fpath))
            {
                FileInfo fi = new FileInfo(fpath);
                using(StreamReader sr = fi.OpenText())
                {
                    string txt;
                    while ((txt = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(txt);
                    }
                }
            }
        }
        public void directoryinfomethod1()
        {
            string fpath = @"D:\Test";
            DirectoryInfo di = new DirectoryInfo(fpath);
            if (di.Exists)
            {
                Console.WriteLine("Directory already exists");
            }
            else
            {
                di.Create();
                Console.WriteLine("Directory created suceesfully");
            }
        }
        public void filestreammethod1()
        {
            string fpath = @"D:\Text.txt";
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }
            using (FileStream fs = File.Create(fpath))
            {
                addtextfile(fs, "Hello");
                addtextfile(fs, "\nWelcome to visualstudio");
                addtextfile(fs, "\nFilestream Example");
            }
        }
        private static void addtextfile(FileStream fs,string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
        public void filestreammethod2()
        {
            string fpath = @"D:\Text.txt";
            if (File.Exists(fpath))
            {
                using(FileStream fs = File.OpenRead(fpath))
                {
                    byte[] b = new byte[1024];
                    UTF8Encoding encode = new UTF8Encoding(true);
                    while (fs.Read(b, 0, b.Length) > 0)
                    {
                        Console.WriteLine(encode.GetString(b));
                    }
                }
            }
        }
        public void streamwritermethod()
        {
            string fpath = @"D:\Texts.txt";
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }
            FileStream fs = new FileStream(fpath,FileMode.Create);
            using(StreamWriter sw=new StreamWriter(fs))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("\r\nWelcome");
                sw.WriteLine("\r\nStreamwriter Example");
            }
        }
        public void streamreadermethod()
        {
            string fpath = @"D:\Texts.txt";
            if (File.Exists(fpath))
            {
               using(StreamReader sr=new StreamReader(fpath))
                {
                    string txt;
                    while ((txt = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(txt);
                    }
                }
            }
        }
        public void textwritermethod()
        {
            string fpath = @"D:\Text.txt";
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }
            using(TextWriter tw = File.CreateText(fpath))
            {
                tw.WriteLine("Hello");
                tw.WriteLine("\r\nWelcome");
                tw.WriteLine("\r\nTextwriter Example");
            }
        }
        public void textreadermethod()
        {
            string fpath = @"D\Test.txt";
            if (File.Exists(fpath))
            {
                using(TextReader tr = File.OpenText(fpath))
                {
                    Console.WriteLine(tr.ReadToEnd());
                }
            }
        }
    }
    
}
