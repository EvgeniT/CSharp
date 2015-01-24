using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("a: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double secondNum = double.Parse(Console.ReadLine());
        double greater = Math.Max(firstNum, secondNum);
        Console.WriteLine(greater);

    }
}

