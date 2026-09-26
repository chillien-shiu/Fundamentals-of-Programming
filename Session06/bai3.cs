using System;
using System.Collections.Generic;
using System.Text;

class Part3
{
    public static int[,] CreateRandomMatrix(int N, int M)
    {
        Random rand = new Random();
        int[,] matrix = new int[N, M];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                matrix[i, j] = rand.Next(1, 100);
            }
        }
        return matrix;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],4} ");
            }
            Console.WriteLine();
        }
    }

    public static void PrintRowAndColumn(int[,] matrix, int rowIndex, int colIndex)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rowIndex >= 0 && rowIndex < rows)
        {
            Console.Write($"Hàng {rowIndex}: ");
            for (int j = 0; j < cols; j++) Console.Write(matrix[rowIndex, j] + " ");
            Console.WriteLine();
        }

        if (colIndex >= 0 && colIndex < cols)
        {
            Console.Write($"Cột {colIndex}: ");
            for (int i = 0; i < rows; i++) Console.Write(matrix[i, colIndex] + " ");
            Console.WriteLine();
        }
    }

    public static int FindMaxMatrix(int[,] matrix)
    {
        int max = matrix[0, 0];
        foreach (int val in matrix)
        {
            if (val > max) max = val;
        }
        return max;
    }

    public static void FindMinRowCol(int[,] matrix, int rowIndex, int colIndex)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rowIndex >= 0 && rowIndex < rows)
        {
            int minRow = matrix[rowIndex, 0];
            for (int j = 1; j < cols; j++)
            {
                if (matrix[rowIndex, j] < minRow) minRow = matrix[rowIndex, j];
            }
            Console.WriteLine($"Giá trị nhỏ nhất trên hàng {rowIndex}: {minRow}");
        }

        if (colIndex >= 0 && colIndex < cols)
        {
            int minCol = matrix[0, colIndex];
            for (int i = 1; i < rows; i++)
            {
                if (matrix[i, colIndex] < minCol) minCol = matrix[i, colIndex];
            }
            Console.WriteLine($"Giá trị nhỏ nhất trên cột {colIndex}: {minCol}");
        }
    }

    public static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] transposed = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposed[j, i] = matrix[i, j];
            }
        }
        return transposed;
    }
    public static void PrintDiagonals(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            Console.WriteLine("Đây không phải là ma trận vuông, không có đường chéo chính/phụ.");
            return;
        }

        Console.Write("Đường chéo chính: ");
        for (int i = 0; i < rows; i++)
        {
            Console.Write(matrix[i, i] + " ");
        }
        Console.WriteLine();

        Console.Write("Đường chéo phụ: ");
        for (int i = 0; i < rows; i++)
        {
            Console.Write(matrix[i, rows - 1 - i] + " ");
        }
        Console.WriteLine();
    }
}

