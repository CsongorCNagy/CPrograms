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
            if (c == ' ')
                Console.Write(" ");
            else
            {
                char letter = c;
                int changed = letter+change;
            

                if ((char)changed<='A' && (char)changed>='Z')
                {
                    Console.Write("{0}", changed);
                }
                else if((char)changed > 'A')


                Console.Write("{0}", (char)(l+shift)
            }
        }
    }
}


/*
 if ((l+shift)>)
*/