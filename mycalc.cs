using System;

class MyCalculator
{
    static void Main()
    {
        int number1;
        int number2;

        Console.Clear();
        Console.WriteLine("Please enter value 1: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter value 2: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The sum of {0} and {1} is {2}", number1, number2, number1 + number2);

    }
}