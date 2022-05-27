using System;
using System.Collections.Generic;
using System.Text;

public class SimpleTextEditor
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Stack<string> stack = new Stack<string>();
        StringBuilder sb = new StringBuilder();

        for(int i = 0; i < n; i++)
        {
            string command = Console.ReadLine();

            if(command.StartsWith("1"))
            {
                stack.Push(sb.ToString());
                string text = command.Split()[1];
                sb.Append(text);
            }
            else if(command.StartsWith("2"))
            {
                stack.Push(sb.ToString());
                int count = int.Parse(command.Split()[1]);
                sb.Remove(sb.Length - count, count);
            }
            else if(command.StartsWith("3"))
            {
                int index = int.Parse(command.Split()[1]);
                Console.WriteLine(sb[index - 1]);
            }
            else if(command.StartsWith("4"))
            {
                string text = stack.Pop();
                sb = new StringBuilder(text);
            }
        }
    }
}