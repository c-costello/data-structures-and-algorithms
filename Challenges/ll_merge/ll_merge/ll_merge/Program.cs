using LinkedList.classes;
using System;

namespace ll_merge
{
    public class Program
    {
        static void Main(string[] args)
        {
            LList listOne = new LList();
            LList listTwo = new LList();

            listOne.Insert(4);
            listOne.Insert(3);
            listOne.Insert(2);
            listOne.Insert(1);
            listTwo.Insert(8);
            listTwo.Insert(7);
            listTwo.Insert(6);
            listTwo.Insert(5);
            listTwo.Insert(4);

            Merge(listOne, listTwo);
        }
        /// <summary>
        /// Takes in two link lists and zips them together
        /// </summary>
        /// <param name="listOne">a link list</param>
        /// <param name="listTwo">another link list</param>
        /// <returns>an altered listOne link list</returns>
        public static LList Merge (LList listOne, LList listTwo)
        {
            Node Current1 = listOne.Head;
            Node Current2 = listTwo.Head;

            while (Current1.Next != null)
            {
                listOne.InsertAfter(Current1.Value, Current2.Value);
                Current1 = Current1.Next.Next;
                Current2 = Current2.Next;
                listOne.Print();
            }
            if(Current2 != null)
            {
                while (Current2.Next != null)
                {
                   listOne.Append(Current2.Value);
                    Current2 = Current2.Next;

                }
            listOne.Append(Current2.Value);
            }
            listOne.Print();
            Console.WriteLine("A thing is happening");
            return listOne;
        }
    }
}
