using System;
using hashtablesApp.Classes;

namespace RepeatedWordApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine(RepeatedWord("cat, cat "));
            Console.WriteLine(RepeatedWord("It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York..."));
            Console.ReadLine();
        }
        /// <summary>
        /// Takes in a string, returns the first repeated word.
        /// </summary>
        /// <param name="str">string</param>
        /// <returns>string</returns>
        public static string RepeatedWord(string str)
        {
            char[] charArr = { ';', ',', ' ', '/', '.', ':' };
            string[] arr = str.Split(charArr);

            Hashtable hashtable = new Hashtable();
            for (int i = 0; i < arr.Length; i++)
            {

                if (hashtable.Contains(arr[i].ToLower()) && arr[i] != "") 
                {
                    return arr[i].ToLower();
                }
                else
                {
                    hashtable.Add(arr[i].ToLower(), $"{arr[i]}{i}");
                }
            }
            return "";
        }
    }
}
