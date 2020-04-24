using System;

class GuessMyNumber
{
    static void Main()
    {
        string myName = "Merlin";
        string guess;

        Console.Clear();
        Console.WriteLine("What is my name?");
        guess = Console.ReadLine();

        if (guess == myName)
            Console.WriteLine("Correct!");
        else
            Console.WriteLine("Wrong!");
    }
}