using System;
using System.Linq;

public class DiagonalDifference
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        ReadMatrix(matrix, n);

        int primSum = 0;
        int secSum = 0;

        for(int i = 0; i < n; i++)
        {
            primSum += matrix[i, i];
            secSum += matrix[i, n - 1 - i];
        }

        Console.WriteLine(Math.Abs(primSum - secSum));
    }

    static void ReadMatrix(int[,] matrix, int size)
    {
        for(int i = 0; i < size; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for(int j = 0; j < size; j++)
            {
                matrix[i, j] = input[j];
            }
        }
    }
}