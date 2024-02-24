using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a text:");
        string text = Console.ReadLine();

        string result = CapitalizeSentences(text);
        Console.WriteLine("Result:");
        Console.WriteLine(result);

        Console.ReadLine(); // Pause the console
    }

    static string CapitalizeSentences(string text)
    {
        StringBuilder result = new StringBuilder(text);

        // Перетворення першої літери кожного речення у верхній регістр
        bool capitalizeNext = true;
        for (int i = 0; i < result.Length; i++)
        {
            if (char.IsLetter(result[i]))
            {
                if (capitalizeNext)
                {
                    result[i] = char.ToUpper(result[i]);
                    capitalizeNext = false;
                }
            }
            else if (result[i] == '.' || result[i] == '?' || result[i] == '!')
            {
                capitalizeNext = true;
            }
        }

        return result.ToString();
    }
}
