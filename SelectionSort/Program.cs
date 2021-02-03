using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 5, 3, 6, 2, 10 };

            int temp;
            int smallist;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                smallist = i;
                // findsmallest
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[smallist] > arr[j])
                    {
                        smallist = j;
                    }
                }
                temp = arr[smallist];
                arr[smallist] = arr[i];
                arr[i] = temp;

            }
        }
    }
}
