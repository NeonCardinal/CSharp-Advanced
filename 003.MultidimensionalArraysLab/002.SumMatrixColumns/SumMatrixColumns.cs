using System;
using System.Linq;

public class SumMatrixColumns
{
    static void Main()
    {
        int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int rows = size[0];
        int cols = size[1];
        int[,] matrix = new int[rows, cols];

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = line[j];
            }
        }
        int[] sum = new int[matrix.GetLength(1)];

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                sum[j] += matrix[i, j];
            }
        }

        foreach(var item in sum)
        {
            Console.WriteLine(item);
        }
    }
}