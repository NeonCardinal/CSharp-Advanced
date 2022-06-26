using System;
using System.Collections.Generic;

public class SetsOfElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        int n = int.Parse(input.Split()[0]);
        int m = int.Parse(input.Split()[1]);

        HashSet<int> firstSet = new HashSet<int>();
        HashSet<int> secondSet = new HashSet<int>();

        for(int i = 0; i < n; i++)
        {
            firstSet.Add(int.Parse(Console.ReadLine()));
        }
        
        for(int i = 0; i < m; i++)
        {
            secondSet.Add(int.Parse(Console.ReadLine()));
        }

        firstSet.IntersectWith(secondSet);

        Console.WriteLine(string.Join(" ", firstSet));
    }
}