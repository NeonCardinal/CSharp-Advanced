using System;
using System.Collections.Generic;
using System.Linq;

public class CountSameValuesInArray
{
    static void Main()
    {
        Dictionary<double, int> counter = new Dictionary<double, int>();

        double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

        foreach (var item in input)
        {
            if (!counter.ContainsKey(item))
            {
                counter[item] = 1;
            }
            else
            {
                counter[item]++;
            }
        }

        foreach (var item in counter)
        {
            Console.WriteLine($"{item.Key} - {item.Value} times");
        }
    }
}
