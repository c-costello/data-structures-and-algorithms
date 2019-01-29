using StacksAndQueues;
using System;

namespace MultiBracketValidationApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(MultiBracketValidation("{}()"));
            Console.WriteLine(MultiBracketValidation("{}([])"));
            Console.WriteLine(MultiBracketValidation("{}([)"));

        }

        public static bool MultiBracketValidation(string input)
        {
            if (input == "")
            {
                return false;
            }
            char[] arr = input.ToCharArray();
            Stack<char> stack = new Stack<char>();
            Stack<char> helperStack = new Stack<char>();

            foreach (char symbol in arr)
            {
                stack.Push(symbol);
            }
            while (stack.Top != null)
            {
                Console.WriteLine("check" + stack.Top.Value);
                Node<char> peek = stack.Peek();
                if (peek.Value == '[' || peek.Value == '(' || peek.Value == '{')
                {

                    if (peek.Value == '[')
                    {
                        if (helperStack.Top != null && helperStack.Top.Value == ']')
                        {
                            stack.Pop();
                            helperStack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }

                    if (peek.Value == '{')
                    {
                        if (helperStack.Top != null && helperStack.Top.Value == '}')
                        {
                            stack.Pop();
                            helperStack.Pop();
                        }
                        else
                        {
                            return false;
                        }

                    }
                    if (peek.Value == '(')
                    {
                        if (helperStack.Top != null && helperStack.Top.Value == ')')
                        {
                            stack.Pop();
                            helperStack.Pop();
                        }
                        else
                        {
                            return false;
                        }

                    }
                }
                else if (peek.Value == ']' || peek.Value == ')' || peek.Value == '}')
                {
                    helperStack.Push(stack.Pop());
                }
                else
                {
                    stack.Pop();
                }
            }
            if (helperStack.Top != null)
            {
                return false;
            }
            return true;        
        }
    }

}
