using System;

namespace arrayShiftApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 1, 2, 3, 4 };
            Console.WriteLine(String.Join(",", ArrayShift(arr, 5)));
        }
        static int[] ArrayShift(int[] arr, int num)
        {
            int arrLength = arr.Length;
            int arrMidpoint = arrLength / 2;
            Console.WriteLine(arrLength + "And" + arrMidpoint);
            int[] newArr = new int[arrLength + 1];

            for (int i = 0; i < arrMidpoint; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[arrMidpoint] = num;
            for (int i = arrMidpoint + 1; i < newArr.Length; i++)
            {
                newArr[i] = arr[i - 1];
            }
            return newArr;
        } 
    }
}
