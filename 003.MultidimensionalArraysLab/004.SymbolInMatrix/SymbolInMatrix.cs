using System;
using System.Linq;

public class SymbolInMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[,] matrix = new char[n, n];

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            string input = Console.ReadLine();

            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = (char)input[j];
            }
        }

        char symbol = char.Parse(Console.ReadLine());
        bool isFound = false;
        int row = 0;
        int col = 0;

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if(symbol == matrix[i, j])
                {
                    isFound = true;
                    row = i;
                    col = j;
                    break;
                }
            }

            if(isFound)
            {
                break;
            }
        }

        if(isFound)
        {
            Console.WriteLine($"({row}, {col})");
        }
        else
        {
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}