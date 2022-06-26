using System;
using System.Collections.Generic;

public class PeriodicTable
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        SortedSet<string> chElements = new SortedSet<string>();

        for(int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] elements = input.Split();

            foreach(var element in elements)
            {
                chElements.Add(element);
            }
        }

        Console.WriteLine(string.Join(" ", chElements));
    }
}