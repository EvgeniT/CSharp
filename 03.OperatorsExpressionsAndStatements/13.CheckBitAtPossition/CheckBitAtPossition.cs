﻿using System;
class CheckBitAtPossition
{
    static void Main()
    {
        Console.Write("Number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Possition: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = n & mask; // koe e 4isloto
        int bit = nAndMask >> p;
        bool valueOne = bit == 1;
        Console.WriteLine(valueOne);
    }
}

