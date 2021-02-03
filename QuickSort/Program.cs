using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 5, 3, 6, 2, 10 };
            QuickSort(arr, 0, arr.Length - 1);
        }

        static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                QuickSort(arr, left, pivot - 1);
                QuickSort(arr, pivot + 1, right);

            }
        }

        static int Partition(int[] arr, int left, int right)
        {
            int i = left;
            int pivot = arr[right];
            int temp;
            for (int j = left; j <= right; j++)
            {
                if (arr[j] < pivot)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                }
            }
            temp = arr[right];
            arr[right] = arr[i];
            arr[i] = temp;
            return i;
        }
    }
}
