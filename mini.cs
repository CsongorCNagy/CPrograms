using System;

class CheapestPrice
{
    static void Main()
    {
        float[] breadPrices = {3.45f, 3.10f, 2.56f, 2.05f, 3.95f};
        float[] milkPrices = {1.50f, 2.50f, 1.75f, 2.05f, 1.25f, 2.35f, 3.05f};
        float[] eggPrices = {4.50f, 3.65f, 2.90f, 4.10f};

        Console.Clear();
        MinCalc(breadPrices, "bread");
        MinCalc(milkPrices, "milk");
        MinCalc(eggPrices, "egg");

    }

    static void MinCalc(float[] numbers, string typeP)
    {
        float minimum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (minimum > numbers[i])
                minimum = numbers[i];
        }
        Console.WriteLine("Lowest price of {0} is ${1}.", typeP, minimum);
    }
}