using System;
using System.Collections.Generic;
using System.Linq;

public class Supermarket
{
    static void Main()
    {
        Queue<string> names = new Queue<string>();

        while(true)
        {
            string cmd = Console.ReadLine();

            if(cmd == "Paid")
            {
                foreach(var item in names)
                {
                    Console.WriteLine(item);
                }

                names.Clear();
            }
            else if(cmd == "End")
            {
                Console.WriteLine($"{names.Count} people remaining.");
                break;
            }
            else
            {
                names.Enqueue(cmd);
            }
        }
    }
}