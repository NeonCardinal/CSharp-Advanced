using System;
using System.Collections.Generic;

public class BalancedParenthesis
{
    static void Main()
    {
        string input = Console.ReadLine();
        Stack<char> stack = new Stack<char>();
        bool isBalanced = false;

        foreach(var item in input)
        {
            if(item == '(' || item == '[' || item == '{')
            {
                stack.Push(item);
            }
            else if(item == ')' || item == ']' || item == '}') 
            {
                if(stack.Count == 0)
                {
                    isBalanced = false;
                    break;
                }

                char lastOpen = stack.Pop();

                if (lastOpen == '(' && item == ')')
                {
                    isBalanced = true;
                }
                else if(lastOpen == '[' && item == ']')
                {
                    isBalanced = true;
                }
                else if(lastOpen == '{' && item == '}')
                {
                    isBalanced = true;
                }
                else
                {
                    isBalanced = false;
                    break;
                }
            }
        }

        if (isBalanced)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}