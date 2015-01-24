using System;

class BinaryToDecimal
{
    static void Main()
    {
        string bin = Console.ReadLine();
        long l = Convert.ToInt64(bin, 2);
        Console.WriteLine(l);
    }
}

