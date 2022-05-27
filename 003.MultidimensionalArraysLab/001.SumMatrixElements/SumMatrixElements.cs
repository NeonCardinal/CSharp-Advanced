using System;
using System.Linq;

public class SumMatrixElements
{
    static void Main()
    {
        int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int[,] matrix = new int[size[0], size[1]];

        for(int i = 0; i < size[0]; i++)
        {
            int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            for(int j = 0; j < size[1]; j++)
            {
                matrix[i, j] = line[j];
            }
        }

        int sum = 0;

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
        }

        Console.WriteLine(matrix.GetLength(0));
        Console.WriteLine(matrix.GetLength(1));
        Console.WriteLine(sum);
    }
}