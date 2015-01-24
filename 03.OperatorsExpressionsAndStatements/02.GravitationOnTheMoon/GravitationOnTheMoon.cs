using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Your weight: ");
        double earthWeight = double.Parse(Console.ReadLine());
        double moonWeight = earthWeight * 0.17;
        Console.WriteLine("Your weight on the moon: " + moonWeight);
    }
}

