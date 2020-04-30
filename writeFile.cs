using System;
using System.IO;

class FileWriting
{
    static void Main()
    {
        string filename = "cars.txt";
        File.Delete(filename);
        CarDetails c1 = new CarDetails("Audi", "A3", 2014, "black", "EF63XVG");
        Console.Clear();
        c1.PrintDetails(filename);
    }
}