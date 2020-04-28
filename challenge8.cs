using System;

class Challenge8
{
    static void Main()
    {
        Console.Clear();
        decimal[] values = {7.03m, 7.64m, 0.12m, -0.12m, -7.1m, -7.6m};
        Console.WriteLine("  Value          Ceiling          Floor");
        foreach (decimal v in values)
        {
            Console.WriteLine("{0,7} {1,16} {2,14}", v, Math.Ceiling(v), Math.Floor(v));
        }
    }
}