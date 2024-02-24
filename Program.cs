using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an arithmetic expression using only + and - operators:");
        string expression = Console.ReadLine();

        double result = CalculateArithmeticExpression(expression);
        Console.WriteLine($"Result: {result}");

        Console.ReadLine(); // Pause the console
    }

    static double CalculateArithmeticExpression(string expression)
    {
        double result = 0;
        char operation = '+';
        int currentNumber = 0;

        for (int i = 0; i < expression.Length; i++)
        {
            if (char.IsDigit(expression[i]))
            {
                currentNumber = currentNumber * 10 + (expression[i] - '0');
            }

            if (!char.IsDigit(expression[i]) || i == expression.Length - 1)
            {
                if (operation == '+')
                {
                    result += currentNumber;
                }
                else if (operation == '-')
                {
                    result -= currentNumber;
                }

                if (i < expression.Length)
                {
                    operation = expression[i];
                    currentNumber = 0;
                }
            }
        }

        return result;
    }
}
