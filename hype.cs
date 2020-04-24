using System;

class HypotenuseCalc
{
    static void Main()
    {
        string sideA;
        string sideB;

        Console.Clear();
        Console.WriteLine("Let's calculate the Hypotenuse!!");
        Console.WriteLine("Please enter lengh of side A: ");
        sideA = Console.ReadLine();
        Console.WriteLine("Please enter lengh of side B: ");
        sideB = Console.ReadLine();

        float a = Convert.ToSingle(sideA);
        float b = Convert.ToSingle(sideB);
        double h2 = Math.Pow(a,2) + Math.Pow(b,2);
        double h = Math.Sqrt(h2);

        Console.WriteLine("The lengh is {0}", h);
    }
}