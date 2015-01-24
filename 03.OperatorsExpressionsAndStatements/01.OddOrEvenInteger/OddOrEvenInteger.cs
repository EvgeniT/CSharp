using System;

class OddOrEvenInteger
{
    static void Main()
    {
        Console.Write("Number: ");
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0 | n == 0)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
        }
    }
}

