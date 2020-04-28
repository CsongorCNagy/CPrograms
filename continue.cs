using System;

class ContinueStatement
{
    static void Main()
    {
        Console.Clear();
        for (int i = 0; i < 20; i++)
        {
            if (i % 2 == 1)
                continue;
            Console.WriteLine("{0} is even.", i);
        }
    }
}