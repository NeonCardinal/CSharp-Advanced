using System;
using System.Collections.Generic;
using System.Linq;

public class BasicQueueOperations
{
    static void Main()
    {
        int[] firstInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<int> secondInput = Console.ReadLine().Split().Select(int.Parse).ToList();
        Queue<int> queue = new Queue<int>();

        int n = firstInput[0];
        int s = firstInput[1];
        int x = firstInput[2];

        for(int i = 0; i < n; i++)
        {
            queue.Enqueue(secondInput[i]);
        }

        for(int i = 0; i < s; i++)
        {
            queue.Dequeue();
        }

        if(queue.Count == 0)
        {
            Console.WriteLine(0);
        }
        else if(queue.Contains(x))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine(queue.Min());
        }
    }
}

