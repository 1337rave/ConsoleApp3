using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaration of a one-dimensional array A and a two-dimensional array B
        double[] A = new double[5];
        double[,] B = new double[3, 4];

        // Filling the one-dimensional array A with numbers entered by the user
        Console.WriteLine("Enter 5 numbers for array A:");
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Filling the two-dimensional array B with random numbers
        Random rnd = new Random();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                B[i, j] = rnd.NextDouble() * 100; // Generate a random number between 0 and 100
            }
        }

        // Displaying the values of the arrays
        Console.WriteLine("Array A:");
        foreach (var num in A)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\nArray B:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(B[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Finding the maximum and minimum elements in the arrays
        double maxA = A[0];
        double minA = A[0];
        double maxB = B[0, 0];
        double minB = B[0, 0];
        double sumA = 0;
        double productA = 1;
        double sumEvenA = 0;
        double sumOddColumnsB = 0;

        foreach (var num in A)
        {
            if (num > maxA)
                maxA = num;
            if (num < minA)
                minA = num;
            sumA += num;
            productA *= num;
            if (num % 2 == 0)
                sumEvenA += num;
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (B[i, j] > maxB)
                    maxB = B[i, j];
                if (B[i, j] < minB)
                    minB = B[i, j];
                if (j % 2 != 0)
                    sumOddColumnsB += B[i, j];
            }
        }

        Console.WriteLine($"Maximum element of array A: {maxA}");
        Console.WriteLine($"Minimum element of array A: {minA}");
        Console.WriteLine($"Maximum element of array B: {maxB}");
        Console.WriteLine($"Minimum element of array B: {minB}");
        Console.WriteLine($"Total sum of elements of array A: {sumA}");
        Console.WriteLine($"Total product of elements of array A: {productA}");
        Console.WriteLine($"Sum of even elements of array A: {sumEvenA}");
        Console.WriteLine($"Sum of odd columns of array B: {sumOddColumnsB}");

        Console.ReadLine(); // To pause the console
    }
}
