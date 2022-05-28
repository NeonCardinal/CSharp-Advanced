using System;
using System.Linq;

public class JaggedArrayManipulator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[][] jaggedArray = new int[n][];

        for(int i = 0; i < n; i++)
        {
            jaggedArray[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        for(int i = 0; i < jaggedArray.Length - 1; i++)
        {
            if (jaggedArray[i].Length == jaggedArray[i + 1].Length)
            {
                jaggedArray[i] = jaggedArray[i].Select(x => x * 2).ToArray();
                jaggedArray[i + 1] = jaggedArray[i + 1].Select(x => x * 2).ToArray();
            }
            else
            {
                jaggedArray[i] = jaggedArray[i].Select(x => x / 2).ToArray();
                jaggedArray[i + 1] = jaggedArray[i + 1].Select(x => x / 2).ToArray();
            }
        }

        string command = Console.ReadLine();

        while(command != "End")
        {
            if(command.StartsWith("Add"))
            {
                int row = int.Parse(command.Split()[1]);
                int col = int.Parse(command.Split()[2]);
                int val = int.Parse(command.Split()[3]);

                if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray.Length)
                {
                    jaggedArray[row][col] += val;
                }
            }
            else if(command.StartsWith("Subtract"))
            {
                int row = int.Parse(command.Split()[1]);
                int col = int.Parse(command.Split()[2]);
                int val = int.Parse(command.Split()[3]);

                if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                {
                    jaggedArray[row][col] -= val;
                }
            }

            command = Console.ReadLine();
        }

        for(int i = 0; i < jaggedArray.Length; i++)
        {
            Console.WriteLine(String.Join(" ", jaggedArray[i]));
        }
    }
}