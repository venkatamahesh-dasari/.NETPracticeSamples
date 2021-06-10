using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace samplespractice
{
    class foreachmahesh
    {
        public static void maheshforeach<T>(T a)
        {
            dynamic x = a;
            IEnumerator ie = ((IEnumerable)x).GetEnumerator();
            for (; ie != null;)
            {
                ie.MoveNext();
                Console.WriteLine(ie.Current.ToString());
            }
            static void Main(string[] args)
            {
                Stack<int> st = new Stack<int>();
                st.Push(10);
                st.Push(20);
                maheshforeach<Stack<int>>(st);
            }
        }
    }
}
