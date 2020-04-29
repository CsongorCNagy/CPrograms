using System;

class MyContacts
{
    static void Main()
    {
        Person friend = new Person("Jim Wilson", "34 Bay Road", "076654321", 181);
        Person friend2 = new Person("Bill Todds", "15 Mills Crescent", "087654321", 157);

        Console.Clear();
        friend.PrintDetails();
        friend2.PrintDetails();
    }
}