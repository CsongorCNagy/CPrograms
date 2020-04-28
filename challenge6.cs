using System;

class Challenge6
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
            if (lat < 30 && lat > -30)
            {
                Console.WriteLine("{0}, {1}", fields[1], fields[0]);
            }
        }
    }
}