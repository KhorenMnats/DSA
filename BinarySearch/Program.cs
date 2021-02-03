using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] @array = { 1, 3, 5, 7, 9, 12 };
            Console.WriteLine(BinarySearchIterative(@array, 3));
        }

        public static int? BinarySearchIterative(int[] arr, int key)
        {
            int min = 0;
            int max = arr.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == arr[mid])
                {
                    return mid;
                }
                else if (key < arr[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return null;

        }
    }
}
