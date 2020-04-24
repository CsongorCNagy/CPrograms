using System;

class Challenge3
{
    static void Main()
    {
        string name;
        int year;
        float price;

        Console.Clear();
        Console.WriteLine("Enter Your Name:");
        name = Console.ReadLine();
        Console.WriteLine("Please Enter your year of birth:");
        year = Convert.ToInt32(Console.ReadLine());

        if (year<1950 || year>2000)
            price = 5.3f;
        else
            price = 25f;
        Console.WriteLine("|**********************|");
        Console.WriteLine("|   -- ADMIT ONE --    |");
        Console.WriteLine("|Name:{0,17}|", name);
        Console.WriteLine("|Price: ${0,14:0.00}|", price);
        Console.WriteLine("|----------------------|");
    }
}