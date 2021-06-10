using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace practicesamples
{
    class genericcollections
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Remove(50);

            Console.WriteLine("list Elements are:");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);
            stack.Pop();
            int peek=stack.Peek();
            Console.WriteLine("Peek value:"+peek);
            Console.WriteLine("Stack Elements are:");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Hello");
            queue.Enqueue("Welcome");
            queue.Enqueue("To");
            queue.Enqueue("Visualstudio");
            queue.Dequeue();
            string s=queue.Peek();
            Console.WriteLine("Peek:"+s);
            Console.WriteLine("Queue Values:");
            foreach(string item in queue)
            {
                Console.WriteLine(item);
            }
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Welcome");
            dictionary.Add(3, "Visualstudio");
            dictionary.Add(2, "To");
            dictionary.Add(4, "Hello");
            dictionary.Remove(4);
            foreach(KeyValuePair<int,string> item in dictionary)
            {
                Console.WriteLine(item.Key+":"+item.Value);
            }
            SortedDictionary<int, string> sorteddictionary = new SortedDictionary<int, string>();
            sorteddictionary.Add(3, "Visualstudio");
            sorteddictionary.Add(2, "To");
            sorteddictionary.Add(1, "Welcome");
            sorteddictionary.Add(4, "Hello");
            sorteddictionary.Remove(4);
            foreach (KeyValuePair<int, string> item in sorteddictionary)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
        }
        
    }
}
