using System;

class CarCollection
{
    static void Main()
    {
        CarDetails[] mycars = new CarDetails[2];
        string make;
        string model;
        int year;
        string color;

        for (int i = 0; i < mycars.Length; i++)
        {
            Console.WriteLine("Enter details for car {0}: ", i+1);
            Console.Write("Make: ");
            make = Console.ReadLine();
            Console.Write("Model: ");
            model = Console.ReadLine();
            Console.Write("Year: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Color: ");
            color = Console.ReadLine();

            mycars[i] = new CarDetails(make, model, year, color);
        }

        Console.Clear();
        for (int i = 0; i < mycars.Length; i++)
        {
            mycars[i].PrintDetails();
        }


    }
}