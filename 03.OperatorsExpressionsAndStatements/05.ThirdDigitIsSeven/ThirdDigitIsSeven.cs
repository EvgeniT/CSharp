using System;
class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.Write("Number: ");
        int n = Math.Abs(int.Parse(Console.ReadLine()));
        if ((n / 100) % 10 == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

