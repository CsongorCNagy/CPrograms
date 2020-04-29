using System;

class CarDetails
{
    string make;
    string model;
    int year;
    string color;

    public CarDetails(string m, string mod, int y, string c)
    {
        make = m;
        model = mod;
        year = y;
        color = c;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Make: " + make);
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Year: " + year);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("========================");
    }
}