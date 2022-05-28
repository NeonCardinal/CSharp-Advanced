﻿using System;
using System.Linq;

public class SquaresInMatrix
{
    static void Main()
    {
        int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string[,] matrix = new string[size[0], size[1]];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string[] input = Console.ReadLine().Split();

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = input[j];
            }
        }

        int counter = 0;

        for(int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for(int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i + 1, j] 
                    && matrix[i, j] == matrix[i + 1, j + 1])
                {
                    counter++;
                }
            }
        }

        Console.WriteLine(counter);
    }
}