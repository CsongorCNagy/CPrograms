using System;

class Challenge1
{
    static void Main()
    {
        string name;
        string job;
        string company;

        Console.Clear();
        Console.WriteLine("Please enter your Name!");
        name = Console.ReadLine();
        Console.WriteLine("Please enter the Company you work for!");
        company = Console.ReadLine();
        Console.WriteLine("Please enter your Job title!");
        job = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("|**********************|");
        Console.WriteLine("|Name:{0,17}|", name);
        Console.WriteLine("|{0,22}|", job);
        Console.WriteLine("|----------------------|");
        Console.WriteLine("|{0,22}|", company);
        Console.WriteLine("|**********************|");
    }
}
