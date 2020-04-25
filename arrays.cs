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
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine("{0}", scores[i]/numScores * 100);
        }
    }
}