using StacksAndQueues;
using System;

namespace MultiBracketValidationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(multiBracketValidation("{}()"));
            Console.WriteLine(multiBracketValidation("{}([])"));
            Console.WriteLine(multiBracketValidation("{}([)"));

        }

        public static bool multiBracketValidation(string input)
        {
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
            return true;        
        }
    }

}
