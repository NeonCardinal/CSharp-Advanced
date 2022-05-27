using System;
using System.Linq;

public class SquareWithMaximumSum
{
    static void Main()
    {
        int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int rows = size[0];
        int cols = size[1];
        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = line[j];
            }
        }

        string bestSquare = string.Empty;
        int bestSum = int.MinValue;

        for(int i = 0; i < rows - 1; i++)
        {
            for(int j = 0; j < cols - 1; j++)
            {
                int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                if(sum > bestSum)
                {
                    bestSum = sum;
                    bestSquare = matrix[i, j] + " " + matrix[i, j + 1] + "\r\n" + matrix[i + 1, j] + " " + matrix[i + 1, j + 1];
                }
            }
        }

        Console.WriteLine(bestSquare);
        Console.WriteLine(bestSum);
    }
}