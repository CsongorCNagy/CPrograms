using System;
using System.IO;

class FileCipher
{
    static void Main()
    {
        string filename;
        string plaintext;
        Console.Clear();
        Console.WriteLine("Enter the filename:");
        filename = Console.ReadLine();
        plaintext = File.ReadAllText(filename);

        string filetext = "";

        foreach (char c in plaintext)
        {
            if (!char.IsLetter(c))
            {
                filetext += c;
            }
            else
            {
                char letter = c;
                if (letter >= 'X' && letter <= 'Z')
                {
                    letter = (char)(letter-26);
                }
                else if (letter >= 'x' && letter <= 'z')
                {
                    letter = (char)(letter-26);
                }

                filetext += (char)(letter+3);
            }
        }
        Console.Write("\n");
        File.WriteAllText("changed" + filename, filetext);
    }
}