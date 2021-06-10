using System;
using System.Collections.Generic;
using System.Text;

namespace practicesamples
{
    class array
    {
        public void singledimensionarray()
        {
            Console.WriteLine("Single Dimension Array");
            int[] arr = new int[5] { 100, 200, 300, 400, 500 };
            foreach (int item in arr)
            {
                Console.Write(item+"\t");
            }
            Console.WriteLine();
        }
        public void multidimensionarray()
        {
            Console.WriteLine("Multi Dimension Array");
            int[,] arr = new int[2, 3] { { 1, 2, 3 },{ 4, 5, 6 } };
            for(int i=0; i<2; i++)
            {
                for (int j = 0; j< 3; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();

            }
        }
        public void jaggedarray()
        {
            Console.WriteLine("Jagged Array");
            int[][] arr = new int[3][];
            arr[0] =new int[3] {1,2,3 };
            arr[1] = new int[2] { 20, 30 };
            arr[2] = new int[3] { 100, 200, 300 };
            foreach(int[] arr1 in arr)
            {
                foreach(int item in arr1)
                {
                    Console.Write(item+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
