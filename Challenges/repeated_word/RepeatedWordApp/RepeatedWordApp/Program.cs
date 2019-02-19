using System;
using hashtablesApp.Classes;

namespace RepeatedWordApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(RepeatedWord("cat, cat "));
            Console.WriteLine(RepeatedWord("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only..."));
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

                if (hashtable.Contains(arr[i].ToLower()))
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
