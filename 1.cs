using System;
using System.Collections.Generic;

namespace methods
{
    class Program
    {
        static int[] SortArray(int[] array)
        {
            bool sorted = false;
            int temp;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        sorted = false;
                    }
                }
            }

            return array;
        }

        static int[] RemoveNegative(int [] array)
        {
            List<int> arr = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    arr.Add(array[i]);
                }
            }

            array = arr.ToArray();

            return array;
        }

        static int[] RemoveMin(int[] array, int min)
        {
            List<int> arr = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= min)
                {
                    arr.Add(array[i]);
                }
            }

            array = arr.ToArray();

            return array;
        }

        static void Main(string[] args)
        {
            // 1
            foreach (var item in SortArray(new int[] { 4, 63, 123, 62, 51, 6, 4, 2, 1, 10, 25 }))
            {
                Console.WriteLine(item);
            }
        }
    }
}
