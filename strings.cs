using System;

class StringExplorer
{
    static void Main()
    {
        string name;
        string age;
        Console.Clear();
        Console.WriteLine("Hello, what is your name?");
        name = Console.ReadLine();
        Console.WriteLine("Nice to meet you {0}. How old are you?", name);
        age = Console.ReadLine();
        Console.WriteLine("Interesting, I'm also {0}.", age);
    }
}