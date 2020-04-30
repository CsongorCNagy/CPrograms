using System;
using System.IO;

class Challenge15
{
    static void Main()
    {
        string filename = "prices.txt";
        if(!File.Exists(filename)) return;

        int count = 0;
        float total = 0;
        foreach (string line in File.ReadLines(filename))
        {
            float value;
            if (float.TryParse(line, out value))
            {
                count++;
                total += value;
            }
        }
        Console.Clear();
        Console.WriteLine("Average of values in file is: {0:0.00}", (total/count));
    }
}
