using System;

class Challenge9
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("How many beeps?");
        int numb = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numb; i++)
        {
            Console.Beep();
        }
        Console.WriteLine("You hear {0} beeps.", numb);
    }
}
