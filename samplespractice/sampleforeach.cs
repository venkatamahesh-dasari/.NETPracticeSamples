using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace samplespractice
{
    class sampleforeach
    {
        public static void maheshforeach<T>(T data)
        {
            //Generic type that will be converted into specific type at compiletime

            var d = data;

            //IEnumerator is an interface it will iterate the data
            //For this IEnumerator i will convert variable(d) into the IEnumerable
            //After that IEnumerable have GetEnumerator() method which will return the IEnumerator

            IEnumerator ie = ((IEnumerable)d).GetEnumerator();

            //In IEnumerator MoveNext() is a method which will move to next position and return true
            //otherwise it returns false
            //for looping purpose for loop is used
            for (; ie.MoveNext();)
            {
                //print the current position of IEnumerator
                Console.WriteLine(ie.Current);
            }
        }
        static void Main(string[] args)
        {
            //creating string
            string st = "mahesh";

            //creating stack
            Stack<int> sta = new Stack<int>();
            sta.Push(100);
            sta.Push(200);

            //creating queue
            Queue<string> qu = new Queue<string>();
            qu.Enqueue("Queue");
            qu.Enqueue("data");

            //creating list
            List<string> li = new List<string>() { "list","data","visualstudio"};

            //creating integer Array
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            //creating ArrayList
            ArrayList ai = new ArrayList();
            ai.Add(10);
            ai.Add("Visualstudio");

            //calling maheshforeach loop
            maheshforeach<string>(st);
            maheshforeach<Stack<int>>(sta);
            maheshforeach<Queue<string>>(qu);
            maheshforeach<List<string>>(li);
            maheshforeach<int[]>(arr);
            maheshforeach<ArrayList>(ai);
        }
    }
}
