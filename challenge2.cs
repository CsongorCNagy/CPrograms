using System;

class Challenge2
{
    static void Main()
    {
        float rate;
        float amount;

        Console.Clear();
        Console.WriteLine("Enter unit/USD rate:");
        rate = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter Amount to Convert:");
        amount = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("You will receive ${0:0.00}", amount * rate);
    }
}