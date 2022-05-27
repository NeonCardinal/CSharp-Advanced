using System;
using System.Linq;

public class JaggedArrayModification
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[][] array = new int[n][];

        for(int i = 0; i < n; i++)
        {
            array[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        while(true)
        {
            string[] command = Console.ReadLine().Split();

            if (command[0] == "END")
            {
                break;
            }

            int row = int.Parse(command[1]);
            int col = int.Parse(command[2]);
            int val = int.Parse(command[3]);

            if (command[0] == "Add")
            {
                if(row >= 0 && row <= array.Length && col >= 0 && col <= array[row].Length)
                {
                    array[row][col] += val;
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }
            else if(command[0] == "Subtract")
            {
                if (row >= 0 && row < array.Length && col >= 0 && col < array[row].Length)
                {
                    array[row][col] -= val;
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }
        }

        for(int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(string.Join(" ", array[i]));
        }
    }
}