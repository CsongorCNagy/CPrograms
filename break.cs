using System;

class BreakStatement
{
    static void Main()
    {
        string input;
        Console.Clear();
        while(true)
        {
            Console.WriteLine("Do you want to quid?");
            input = Console.ReadLine();
            
            if (input == "y")
                break;
        }
        Console.WriteLine("Okay Quitting Now.");
    }
}