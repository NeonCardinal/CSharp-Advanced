using System;
using System.Collections.Generic;
using System.Linq;

public class FashionBoutique
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int rackCapacity = int.Parse(Console.ReadLine());

        Stack<int> stack = new Stack<int>(numbers);

        int racksCounter = 1;
        int sum = 0;

        while(stack.Count > 0)
        {
            int curElement = stack.Pop();

            if(sum + curElement <= rackCapacity)
            {
                sum += curElement;
            }
            else
            {
                sum = curElement;
                racksCounter++;
            }
        }

        Console.WriteLine(racksCounter);
    }
}