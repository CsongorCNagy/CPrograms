using System;

class MyContacts
{
    static void Main()
    {
        Person friend = new Person("Jim Wilson", "34 Bay Road", "076654321", 181);
        Person friend2 = new Person("Bill Todds", "15 Mills Crescent", "087654321", 157);
        Person friend3 = new Person("Joe Johnas", "2 High Street", "098765432", 175);
        Person friend4 = new Person("Anna Clinton", "6 Town Avenue", "01234567", 161);
        Person friend5 = new Person("Julia Hill", "67 Brand Way", "023456789", 166);

        Console.Clear();
        friend.PrintDetails();
        friend2.PrintDetails();
        friend3.PrintDetails();
        friend4.PrintDetails();
        friend5.PrintDetails();
    }
}