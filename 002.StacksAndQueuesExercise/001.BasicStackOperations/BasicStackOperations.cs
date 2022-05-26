using System;
using System.Collections.Generic;
using System.Linq;

public class BasicStackOperations
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<int> listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        Stack<int> stack = new Stack<int>();

        int n = numbers[0];
        int s = numbers[1];
        int x = numbers[2];

        for(int i = 0; i < n; i++)
        {
            stack.Push(listOfNumbers[i]);
        }

        for(int i = 0; i < s; i++)
        {
            stack.Pop();
        }

        if(stack.Count == 0)
        {
            Console.WriteLine(0);
        }
        else if(stack.Contains(x))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine(stack.Min()); 
        }
    }
}

