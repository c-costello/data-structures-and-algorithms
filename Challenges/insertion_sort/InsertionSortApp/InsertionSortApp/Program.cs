using System;

namespace InsertionSortApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 5, 3, 7, 2, 1 };
            Console.WriteLine(String.Join("",(InsertionSort(array))));
        }

        /// <summary>
        /// Takes in an array of integers and returns a sorted array
        /// </summary>
        /// <param name="array">int[]</param>
        /// <returns>int[] array </returns>
        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i - 1;
                int temp = array[i];

                while (j >= 0 && temp < array[j])
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = temp;
            }
            return array;
        }
    }
}
