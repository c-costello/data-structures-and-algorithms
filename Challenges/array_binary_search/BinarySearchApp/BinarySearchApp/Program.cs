using System;

namespace BinarySearchApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int[] arrOne = { 1, 2, 3, 4, 5 };
            Console.WriteLine("index" + BinarySearch(arrOne, 3));
            Console.WriteLine("index" + BinarySearch(arrOne, 4));
            Console.WriteLine("index" + BinarySearch(arrOne, 2));


        }
        public static int BinarySearch(int[] arr, int num)
        {
            int arrMidpoint = arr.Length / 2;
            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine("arrMidpoint: " + arrMidpoint);
                if (arrMidpoint > arr.Length)
                {
                    return -1;
                }
                if (arr[arrMidpoint] == num)
                {
                    if (arrMidpoint > arr.Length)
                    {
                        return -1;
                    }
                    Console.WriteLine("num: " + num);
                    return arrMidpoint;
                } else if (num < arr[arrMidpoint])
                {
                    if (arrMidpoint == 1)
                    {
                        arrMidpoint = 0;
                    } 
                    Console.WriteLine("Something is happening");
                    arrMidpoint = (arrMidpoint + 1)/ 2;
                    if (arrMidpoint > arr.Length)
                    {
                        return -1;
                    }
                    Console.WriteLine("new midpoint :" + arrMidpoint);
                    Console.WriteLine("arr" + arr[arrMidpoint]);
                
                } else if (num > arr[arrMidpoint])
                {
                    arrMidpoint = (arrMidpoint) + (arrMidpoint / 2);
                    if (arrMidpoint > arr.Length)
                    {
                        return -1;
                    }
                    Console.WriteLine("new midpoint 2:" + arrMidpoint);
                    Console.WriteLine("arr" + arr[arrMidpoint]);
                
                }
            }
            
                
            return -1;
        }
    }
}
