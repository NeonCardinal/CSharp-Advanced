using System;
using System.Collections.Generic;
using System.Linq;

public class StackSum
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Stack<int> stack = new Stack<int>(array);

        while(true)
        {
            string cmd = Console.ReadLine().ToLower();
            string[] tokens = cmd.Split();

            if(tokens[0] == "end")
            {
                break;
            }
            else if(tokens[0] == "add")
            {
                stack.Push(int.Parse(tokens[1]));
                stack.Push(int.Parse(tokens[2]));
            }
            else if(tokens[0] == "remove")
            {
                int len = int.Parse(tokens[1]);
                if(len < stack.Count)
                {
                    for(int i = 0; i < len; i++)
                    {
                        stack.Pop();
                    }
                }
            }
        }

        Console.WriteLine(stack.Sum());
    }
}