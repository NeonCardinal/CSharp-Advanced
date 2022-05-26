using System;
using System.Collections.Generic;
using System.Linq;

public class FastFood
{
    static void Main()
    {
        int quantityFood = int.Parse(Console.ReadLine());
        List<int> ordersList = Console.ReadLine().Split().Select(int.Parse).ToList();
        Queue<int> queue = new Queue<int>(ordersList);

        Console.WriteLine(queue.Max());

        int queueLen = queue.Count;
        for(int i = 1; i <= queueLen; i++)
        {
            if(quantityFood >= queue.Peek())
            {
                quantityFood -= queue.Peek();
                queue.Dequeue();
            }
            else
            {
                break;
            }
        }

        if(queue.Count == 0)
        {
            Console.WriteLine("Orders complete");
        }
        else
        {
            Console.Write("Orders left: ");
            Console.WriteLine(String.Join(" ", queue));
        }
    }
}