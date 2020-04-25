using System;

class NestedLoops
{
    static void Main()
    {
        for (int i = 0; i <= 2; i++)
        {
            for (int j = 0; j <= 2; j++)
            {
                for (int k = 0; k <= 2; k++)
                {
                    Console.WriteLine("I is {0}, J is {1}, K is {2}", i, j, k);
                }
            }
        }
    }
}