using System;
using System.Linq;

public class MaximalSum
{
    static void Main()
    {
        int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = size[0];
        int m = size[1];
        int[,] matrix = new int[n, m];

        ReadMatrix(matrix);

        int maxSum = int.MinValue;
        int maxRow = 0;
        int maxCol = 0;

        for(int i = 0; i < matrix.GetLength(0) - 2; i++)
        {
            for(int j = 0; j < matrix.GetLength(1) - 2; j++)
            {
                int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                    + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                    + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                if(sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        Console.WriteLine($"Sum = {maxSum}");
        Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]} {matrix[maxRow, maxCol + 2]}");
        Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]} {matrix[maxRow + 1, maxCol + 2]}");
        Console.WriteLine($"{matrix[maxRow + 2, maxCol]} {matrix[maxRow + 2, maxCol + 1]} {matrix[maxRow + 2, maxCol + 2]}");
    }

    static void ReadMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = input[j];
            }
        }
    }
}