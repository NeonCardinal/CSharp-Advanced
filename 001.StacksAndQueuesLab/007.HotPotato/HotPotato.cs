using System;
using System.Collections.Generic;
using System.Linq;

public class HotPotato
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split();
        int n = int.Parse(Console.ReadLine());
        Queue<string> players = new Queue<string>(names);

        while(players.Count > 1)
        {
            for(int i = 1; i <= n - 1; i++)
            {
                string player = players.Dequeue();
                players.Enqueue(player);
            }

            string lostPlayer = players.Dequeue();

            Console.WriteLine($"Removed {lostPlayer}");
        }

        Console.WriteLine($"Last is {players.Dequeue()}");
    }
}