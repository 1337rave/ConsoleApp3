using System;

class MatrixOperations
{
    static void Main()
    {
        int[,] matrixA = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] matrixB = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };

        Console.WriteLine("Matrix A:");
        PrintMatrix(matrixA);
        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        int scalar = 2;

        Console.WriteLine($"\nScalar: {scalar}\n");

        Console.WriteLine("Matrix A multiplied by scalar:");
        PrintMatrix(MultiplyByScalar(matrixA, scalar));

        Console.WriteLine("\nMatrix A + Matrix B:");
        PrintMatrix(AddMatrices(matrixA, matrixB));

        Console.WriteLine("\nMatrix A * Matrix B:");
        PrintMatrix(MultiplyMatrices(matrixA, matrixB));

        Console.ReadLine(); // Pause the console
    }

    static int[,] MultiplyByScalar(int[,] matrix, int scalar)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        int[,] result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }

        return result;
    }

    static int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int columns = matrixA.GetLength(1);
        int[,] result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        return result;
    }

    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int columnsA = matrixA.GetLength(1);
        int columnsB = matrixB.GetLength(1);
        int[,] result = new int[rowsA, columnsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                int sum = 0;
                for (int k = 0; k < columnsA; k++)
                {
                    sum += matrixA[i, k] * matrixB[k, j];
                }
                result[i, j] = sum;
            }
        }

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
