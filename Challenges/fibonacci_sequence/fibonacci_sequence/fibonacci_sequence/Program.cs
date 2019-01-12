﻿using System;

namespace fibonacci_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(FindNthTerm(5));
        }
        static long FindNthTerm(int n)
        {
            long[] fibArr = new long[n + 1];
            fibArr[0] = 0;
            fibArr[1] = 1;
            long nthTerm = 0;
            for (int i = 2; i < n + 1; i++)
            {
                fibArr[i] = fibArr[i - 1] + fibArr[i - 2];
                nthTerm = fibArr[i];
            }
            return nthTerm;
        }

    }
}
