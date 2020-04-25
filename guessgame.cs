using System;

class GuessGame
{
    static void Main()
    {
        Random rand = new Random();
        int number = rand.Next(1,101);
        int guess;

        Console.Clear();
        Console.WriteLine("What number am I thinking of?");

        do
        {
            guess = Convert.ToInt32(Console.ReadLine());

            if(guess == number)
                Console.WriteLine("Congratulations");
            else if (guess < number)
                Console.WriteLine("That's too low, try again");
            else
                Console.WriteLine("That's too high, try again");
        }
        while(guess != number);
        Console.WriteLine("Thanks for the game");
    }
}