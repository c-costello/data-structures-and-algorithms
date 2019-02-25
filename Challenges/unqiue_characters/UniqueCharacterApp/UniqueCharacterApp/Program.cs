using hashtablesApp.Classes;
using System;

namespace UniqueCharacterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NoDuplicates("Hello"));
            Console.WriteLine(NoDuplicates("the sad cow"));

        }

        public static bool NoDuplicates(string str)
        {
            Hashtable hashtable = new Hashtable();
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] != ' ')
                {
                    if (hashtable.Contains(str[i].ToString()))
                    {
                        return false;
                    }
                    hashtable.Add(str[i].ToString(), str[i].ToString());
                }
            }
            return true;
        }
    }
}
