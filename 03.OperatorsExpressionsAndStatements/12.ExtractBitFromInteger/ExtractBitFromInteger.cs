using System;
class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Possition: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        Console.WriteLine(bit);
    }
}

