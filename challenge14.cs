using System;

class Challenge14
{
    static void Main()
    {
        string word1 = "apple";
        string word2 = "orange";

        Console.Clear();
        if (String.Compare(word1, word2) < 0)
            Console.WriteLine(word1 + " aphabeticaly comes before " + word2);
        else if (String.Compare(word1, word2) > 0)
            Console.WriteLine(word2 + " aphabeticaly comes before " + word1);
        else
            Console.WriteLine("Words are the same");
    }
}