using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaration of a 5x5 two-dimensional array filled with random numbers from -100 to 100
        int[,] array = new int[5, 5];
        Random rnd = new Random();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = rnd.Next(-100, 101); // Generate a random number between -100 and 100
            }
        }

        // Display the generated array
        Console.WriteLine("Generated Array:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Finding the minimum and maximum elements and their positions
        int minElement = array[0, 0];
        int maxElement = array[0, 0];
        int minRowIndex = 0;
        int minColIndex = 0;
        int maxRowIndex = 0;
        int maxColIndex = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    minRowIndex = i;
                    minColIndex = j;
                }
                if (array[i, j] > maxElement)
                {
                    maxElement = array[i, j];
                    maxRowIndex = i;
                    maxColIndex = j;
                }
            }
        }

        // Finding the sum of elements between the minimum and maximum elements
        int sum = 0;
        int startRow = Math.Min(minRowIndex, maxRowIndex) + 1;
        int endRow = Math.Max(minRowIndex, maxRowIndex) - 1;
        int startCol = Math.Min(minColIndex, maxColIndex) + 1;
        int endCol = Math.Max(minColIndex, maxColIndex) - 1;

        for (int i = startRow; i <= endRow; i++)
        {
            for (int j = startCol; j <= endCol; j++)
            {
                sum += array[i, j];
            }
        }

        // Display the sum of elements between the minimum and maximum elements
        Console.WriteLine($"\nSum of elements between the minimum and maximum elements: {sum}");

        Console.ReadLine(); // To pause the console
    }
}
