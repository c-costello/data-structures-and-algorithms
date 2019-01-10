using System;

namespace BinarySearchApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 6, 7, 8, 9, 10 };
            int[] arrOne = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(BinarySearch(arrOne, 6));
            Console.WriteLine(BinarySearch(arrOne, 3));

        }
        public static int BinarySearch(int[] arr, int num)
        {
            int arrMidpoint = arr.Length / 2;
            Console.WriteLine(arrMidpoint);

            if (num == arr[arrMidpoint])
            {
                return arrMidpoint;
            }
            
            return -1;
        }
    }
}
