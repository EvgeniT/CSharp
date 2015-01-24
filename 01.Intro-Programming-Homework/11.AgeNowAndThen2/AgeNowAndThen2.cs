using System;

class AgeNowAndThen2
{
    static void Main()
    {
        Console.WriteLine("Please enter your birthday and hit enter:");
        DateTime age = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;
        Console.WriteLine("Your age now:" + (today.Year - age.Year));
        Console.WriteLine("Your age after 10 years:" + (today.Year - age.Year + 10));
    }
}

