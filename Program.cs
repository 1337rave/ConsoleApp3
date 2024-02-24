using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the text:");
        string text = Console.ReadLine();

        Console.WriteLine("Enter the forbidden word:");
        string forbiddenWord = Console.ReadLine();

        int count = 0;
        string censoredText = CensorForbiddenWord(text, forbiddenWord, out count);
        Console.WriteLine($"Result:\n{censoredText}");
        Console.WriteLine($"\nStatistics: {count} replacements of the word '{forbiddenWord}'.");

        Console.ReadLine(); // Pause the console
    }

    static string CensorForbiddenWord(string text, string forbiddenWord, out int count)
    {
        count = 0;
        string[] words = text.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Equals(forbiddenWord, StringComparison.OrdinalIgnoreCase))
            {
                words[i] = new string('*', forbiddenWord.Length);
                count++;
            }
        }

        return string.Join(" ", words);
    }
}
