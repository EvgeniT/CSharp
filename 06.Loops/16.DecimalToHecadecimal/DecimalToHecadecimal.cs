using System;

class DecimalToHecadecimal
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        string hex = string.Format("{0:X}", n);
        Console.WriteLine(hex);
    }
}

