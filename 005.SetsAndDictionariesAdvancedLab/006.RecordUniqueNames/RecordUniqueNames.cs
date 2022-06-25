using System;
using System.Collections.Generic;

public class RecordUniqueNames
{
    static void Main()
    {
        HashSet<string> uniqueNames = new HashSet<string>();

        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            uniqueNames.Add(name);
        }

        foreach(var item in uniqueNames)
        {
            Console.WriteLine(item);
        }
    }
}