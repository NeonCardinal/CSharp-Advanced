using System;
using System.Collections.Generic;
using System.Linq;

public class LargestThreeNumbers
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] sortedNumber = numbers.OrderByDescending(x => x).ToArray();

        for(int i = 0; i < sortedNumber.Length; i++)
        {
            if(i > 2)
            {
                break;
            }

            Console.Write($"{sortedNumber[i]} ");
        }
    }
}