using System;

class Challenge4
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Please enter text!");
        string text = Console.ReadLine();
        Console.WriteLine("How many characters to shift by?");
        int shift = Convert.ToInt32(Console.ReadLine());

        foreach(char c in text)
        {
            int letter = Convert.ToInt32(c);
            if (c == ' ' || (c+shift) == ' ')
                Console.Write(" ");
            else
            {
                if ((letter+shift) > 'Z' && (letter+shift) < 'a')
                    letter -= 26;
                else if ((letter+shift) > 'z')
                    letter -= 26;
                
                Console.Write("{0}", (char)(letter+shift));
            }
        }
        Console.WriteLine("");
    }
}
