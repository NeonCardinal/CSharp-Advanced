using System;
using System.Collections.Generic;

public class UniqueUsernames
{
    static void Main()
    {
        HashSet<string> usernames = new HashSet<string>();

        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            string username = Console.ReadLine();
            usernames.Add(username);
        }

        Console.WriteLine(string.Join(Environment.NewLine, usernames));
    }
}