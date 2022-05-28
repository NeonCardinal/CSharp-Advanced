using System;
using System.Linq;

public class MatrixShuffling
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = input[0];
        int cols = input[1];
        string[,] matrix = new string[rows, cols];

        ReadMatrix(matrix);

        string command = Console.ReadLine();

        while(command != "END")
        {
            if(!ValidateCommand(command, rows, cols))
            {
                Console.WriteLine("Invalid input!");
                command = Console.ReadLine();
                continue;
            }
            else
            {
                string[] cmd = command.Split();
                int row1 = int.Parse(cmd[1]);
                int col1 = int.Parse(cmd[2]);
                int row2 = int.Parse(cmd[3]);
                int col2 = int.Parse(cmd[4]);

                string firstElement = matrix[row1, col1];
                string secondElement = matrix[row2, col2];

                matrix[row1, col1] = secondElement;
                matrix[row2, col2] = firstElement;

                PrintMatrix(matrix);
            }

            command = Console.ReadLine();
        }
    }

    static void ReadMatrix(string[,] matrix)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            string[] input = Console.ReadLine().Split();

            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = input[j];
            }
        }
    }

    static bool ValidateCommand(string command, int rows, int cols)
    {
        string[] arr = command.Split();

        if (arr[0] == "swap" && arr.Length == 5)
        {
            int row1 = int.Parse(arr[1]);
            int col1 = int.Parse(arr[2]);
            int row2 = int.Parse(arr[3]);
            int col2 = int.Parse(arr[4]);

            if(row1 >= 0 && row1 < rows && col1 >= 0 && col1 < cols && row2 >= 0 && row2 < rows && col2 >= 0 && col2 < cols)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    static void PrintMatrix(string[,] matrix)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }

            Console.WriteLine();
        }
    }
}