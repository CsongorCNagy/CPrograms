using System;

class CircleCalcs
{
    static void Main()
    {
        string input;
        int radius;
        double c;
        double a;

        Console.Clear();
        Console.WriteLine("Enter the radius: ");
        input = Console.ReadLine();

        if(int.TryParse(input, out radius))
        {
            if(circle(radius, out c, out a))
            {
                Console.WriteLine("A circle with a radius of {0} has a circumference of {1:0.00} and an area of {2:0.00}", radius, c, a);
            }
            else
            {
                Console.WriteLine("Radius was zero!");
            }
        }
        else
        {
            Console.WriteLine("Incorrect Input.");
        }
    }

    static bool circle(int radius, out double circumference, out double area)
    {
        circumference = 0;
        area =0;
        if (radius == 0)
            return false;
        circumference = 2 * radius * Math.PI;
        area = Math.Pow(radius, 2) * Math.PI;
        return true; 
    }
}