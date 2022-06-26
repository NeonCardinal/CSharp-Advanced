using System;
using System.Collections.Generic;

public class SoftUniParty
{
    static void Main()
    {
        HashSet<string> set = new HashSet<string>();

        while(true)
        {
            string input = Console.ReadLine();

            if(input == "PARTY")
            {
                break;
            }

            set.Add(input);
        }

        while(true)
        {
            string input = Console.ReadLine();

            if(input == "END")
            {
                break;
            }

            if(set.Contains(input))
            {
                set.Remove(input);
            }
        }

        Console.WriteLine(set.Count);

        foreach(var item in set)
        {
            if (char.IsDigit(item[0]))
            {
                Console.WriteLine(item);
            }
            //else
            //{
            //    Console.WriteLine(item);
            //}
        }

        foreach(var item in set)
        {
            if (char.IsLetter(item[0]))
            {
                Console.WriteLine(item);
            }
        }
    }
}