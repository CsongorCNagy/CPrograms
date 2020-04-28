using System;

class Challenge5
{
    static void Main()
    {
        string fileContent = Console.In.ReadToEnd();
        Console.Clear();

        string[] lines = fileContent.Split("\n");

        foreach (string l in lines)
        {
            if(l.IndexOf("NULL") >= 0 || l == lines[0])
            {
                continue;
            }
            string[] fields = l.Split(',');
            float lat = Convert.ToSingle(fields[2]);
            if (lat > 0)
            {
                Console.WriteLine("{0}", fields[1]);
            }
        }
    }
}