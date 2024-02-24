using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to encrypt:");
        string input = Console.ReadLine();

        Console.WriteLine("Enter the encryption key (a number between 1 and 25):");
        int key = int.Parse(Console.ReadLine());

        string encryptedText = Encrypt(input, key);
        Console.WriteLine($"Encrypted text: {encryptedText}");

        string decryptedText = Decrypt(encryptedText, key);
        Console.WriteLine($"Decrypted text: {decryptedText}");

        Console.ReadLine(); // Pause the console
    }

    static string Encrypt(string input, int key)
    {
        string encryptedText = "";

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char encryptedChar = (char)(((c - 'A' + key) % 26) + 'A'); // Apply Caesar cipher
                encryptedText += encryptedChar;
            }
            else
            {
                encryptedText += c; // Keep non-alphabetic characters unchanged
            }
        }

        return encryptedText;
    }

    static string Decrypt(string input, int key)
    {
        string decryptedText = "";

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char decryptedChar = (char)(((c - 'A' - key + 26) % 26) + 'A'); // Apply reverse Caesar cipher
                decryptedText += decryptedChar;
            }
            else
            {
                decryptedText += c; // Keep non-alphabetic characters unchanged
            }
        }

        return decryptedText;
    }
}
