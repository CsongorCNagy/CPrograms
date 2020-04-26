using System;

class ScoreProcessing
{
    static void Main()
    {
        int numScores;

        Console.Clear();
        Console.WriteLine("How many scores?");
        numScores = Convert.ToInt32(Console.ReadLine());
        int[] scores = new int[numScores];

        
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine("Enter score number {0}", i+1);
            scores[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Processing here:");

        foreach (int box in scores)
        {
            Console.WriteLine("{0}", box/numScores *100);
        }
    }
}