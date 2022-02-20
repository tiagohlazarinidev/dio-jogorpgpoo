using System;
class Program
{
    public static void Main()
    {
        knight arus = new("Arus", 23, "Knight");
        Wizard wizard = new("Jennica", 23, "White Wizard");

        Console.WriteLine(wizard.Attack(1));
        Console.WriteLine(wizard.Attack(7));
    }
}