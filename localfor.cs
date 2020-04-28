using System;

class LocalVariables
{
    static int i = 99;
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("i before loop is {0}", i);

        Counter();

        Console.WriteLine("i after loop is {0}", i);
    }

    static void Counter()
    {
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}