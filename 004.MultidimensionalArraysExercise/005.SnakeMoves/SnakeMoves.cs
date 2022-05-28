using System;
using System.Linq;

public class SnakeMoves
{
    static void Main()
    {
        int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = size[0];
        int cols = size[1];
        char[,] matrix = new char[rows, cols];
        string snake = Console.ReadLine();

        int index = 0;

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            if(i % 2 == 0)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = snake[index];
                    index++;

                    if (index >= snake.Length)
                    {
                        index = 0;
                    }
                }
            }
            else
            {
                for(int j = matrix.GetLength(1) - 1; j >= 0; j--)
                {
                    matrix[i, j] = snake[index];
                    index++;

                    if (index >= snake.Length)
                    {
                        index = 0;
                    }
                }
            }
        }

        PrintMatrix(matrix);
    }

    static void PrintMatrix(char[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}");
            }

            Console.WriteLine();
        }
    }
}