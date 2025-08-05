using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 65 || age <= 12)
            Console.WriteLine("Ticket price: GHC7");
        else
            Console.WriteLine("Ticket price: GHC10");
    }
}
