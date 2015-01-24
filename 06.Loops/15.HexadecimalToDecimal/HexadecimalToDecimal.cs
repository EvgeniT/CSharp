using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        string str = Console.ReadLine();
        long l = Convert.ToInt32(str, 16);
        Console.WriteLine(l);
    }
}

