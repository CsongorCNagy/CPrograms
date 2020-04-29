using System;

class CarDetails
{
    string make;
    string model;
    int year;
    string color;
    string regNumb;

    public CarDetails(string m, string mod, int y, string c, string r)
    {
        make = m;
        model = mod;
        year = y;
        color = c;
        regNumb = r;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Make: " + make);
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Year: " + year);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Regitration number: " + regNumb);
        Console.WriteLine("========================");
    }
}