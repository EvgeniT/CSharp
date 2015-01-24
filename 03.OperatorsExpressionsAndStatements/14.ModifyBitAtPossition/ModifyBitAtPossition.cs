using System;
class ModifyBitAtPossition
{
    static void Main()
    {
        Console.Write("Number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Position: ");
        int pos = int.Parse(Console.ReadLine());
        Console.Write("Value: ");
        int val = int.Parse(Console.ReadLine());

        if (val == 0)
        {
            int setZero = ~(1 << pos);
            int bitZero = num & setZero;
            Console.WriteLine(Convert.ToString(bitZero, 2).PadLeft(16, '0'));
            Console.WriteLine(bitZero);
        }
        else
        {
            int setOne = 1 << pos;
            int bitOne = num | setOne;
            Console.WriteLine(Convert.ToString(bitOne, 2).PadLeft(16, '0'));
            Console.WriteLine(bitOne);
        }
    }
}

