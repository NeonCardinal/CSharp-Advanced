using System;
using System.Collections.Generic;
using System.Linq;

public class ReverseAString
{
    static void Main()
    {
        string str = Console.ReadLine();
        Stack<char> stack = new Stack<char>();

        for(int i = 0; i < str.Length; i++)
        {
            stack.Push(str[i]);
        }

        Console.WriteLine(string.Join("", stack));
    }
}