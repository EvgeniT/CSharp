using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string binary = Convert.ToString(number,2);
        Console.WriteLine(binary);
    }
}

