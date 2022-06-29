using System;
using System.Collections.Generic;

public class CountSymbols
{
    static void Main()
    {
        string text = Console.ReadLine();
        SortedDictionary<char, int> dict = new SortedDictionary<char, int>();

        for(int i = 0; i < text.Length; i++)
        {
            if (!dict.ContainsKey(text[i]))
            {
                dict.Add(text[i], 1);
            }
            else
            {
                dict[text[i]]++;
            }
        }

        foreach(var item in dict)
        {
            Console.WriteLine($"{item.Key}: {item.Value} time/s");
        }
    }
}