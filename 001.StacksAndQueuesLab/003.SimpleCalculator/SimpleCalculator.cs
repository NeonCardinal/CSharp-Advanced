using System;
using System.Collections.Generic;
using System.Linq;

public class SimpleCalculator
{
    static void Main()
    {
        string[] expression = Console.ReadLine().Split();

        Array.Reverse(expression);

        Stack<string> stack = new Stack<string>(expression);

        while(stack.Count > 1)
        {
            int firstNumber = int.Parse(stack.Pop());
            string opt = stack.Pop();
            int secondNumber = int.Parse(stack.Pop());

            if(opt == "+")
            {
                stack.Push((firstNumber + secondNumber).ToString());
            }
            else if(opt == "-")
            {
                stack.Push((firstNumber - secondNumber).ToString());
            }
        }

        Console.WriteLine(stack.Pop());
    }
}