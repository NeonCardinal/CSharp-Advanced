using System;
using System.Collections.Generic;
using System.Linq;


public class SongsQueue
{
    static void Main()
    {
        Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));

        while(true)
        {
            string command = Console.ReadLine();
            
            if(command == "Play")
            {
                songs.Dequeue();
            }
            else if(command.Contains("Add"))
            {
                string song = command.Substring(4);
                if(songs.Contains(song))
                {
                    Console.WriteLine($"{song} is already contained!");
                }
                else
                {
                    songs.Enqueue(song);
                }
            }
            else if(command == "Show")
            {
                Console.WriteLine(string.Join(", ", songs));
            }

            if(songs.Count == 0)
            {
                Console.WriteLine("No more songs!");
                break;
            }
        }
    }
}