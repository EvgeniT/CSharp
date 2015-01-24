using System;
class ExtractThirdBit
{
    static void Main()
    {
        Console.Write("Number: ");
        int n = int.Parse(Console.ReadLine());
        int mask = 1<<3;    //00001000
        int nAndMask = n & mask;    
        int bit = nAndMask >> 3;
        Console.WriteLine(bit);

    }
}

