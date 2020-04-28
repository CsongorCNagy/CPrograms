using System;
using System.Net;

class Challenge7
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Enter a URL.");
        string url = Console.ReadLine();

        WebClient wc = new WebClient();
        string webText = wc.DownloadString(url);

        foreach (char c in webText)
        {
            if (c == ' ')
                Console.Write(" ");
            else if (c == '\n')
                Console.Write("\n");
            // Could specify a lot more, like to parse all numbers or special characters
            // and leave them, to make only the letters be encrypted. But that's not the point of this exercise
            // Could even apply encryption only on letters and use 'continue' on every other character be it
            // space, linebreak, special character, numbers, ect.
            else
            {
                char letter = c;
                Console.Write((char)(letter+5));
            }
        }

        Console.WriteLine();
    }
}