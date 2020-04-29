using System;

public class Person
{
    string name;
    string address;
    string phone;
    float height;

    public Person(string n, string a)
    {
        name = n;
        address = a;
        phone = "0786543786";
        height = 180;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Name: " + name + "\n" +
                          "Address: " + address + "\n" +
                          "Phone: " + phone + "\n" +
                          "Height: " + height);
    }
    

}