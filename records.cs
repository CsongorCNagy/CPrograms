using System;

class MyContacts
{
    static void Main()
    {
        Person friend = new Person("Jim Wilson", "34 Bay Road");
        Person friend2 = new Person("Bill Todds", "15 Mills Crescent");

        Console.Clear();
        friend.PrintDetails();
        friend2.PrintDetails();
    }
}