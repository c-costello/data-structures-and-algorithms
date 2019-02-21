using hashtablesApp.Classes;
using System;
using System.Collections.Generic;

namespace LeftJoinApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public List<string[]> LeftJoin(Hashtable table1, Hashtable table2)
        {
            List<string[]> list = new List<string[]>();
            for (int i = 0; i < table1.Array.Length; i++)
            {
                if (table1.Array[i] != null)
                {
                    if(table1.Array[i].Next != null)
                    {
                        Node current = table1.Array[i];
                        do
                        {
                            string[] str = new string[3];
                            str[0] = current.Value.Key;
                            str[1] = current.Value.Value;
                            str[2] = table2.Get(current.Value.Key);
                            list.Add(str);
                            current = current.Next;
                        } while (current.Next != null);
                    }
                    if (table1.Array[i].Next == null)
                    {
                        string[] str = new string[3];
                        str[0] = table1.Array[i].Value.Key;
                        str[1] = table1.Array[i].Value.Value;
                        str[2] = table2.Get(table1.Array[i].Value.Key);
                        list.Add(str);
                    }
                }
            }
            return list;
        }
    }
}
