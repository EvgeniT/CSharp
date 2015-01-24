using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Write("a: ");
        double firstNum = double.Parse(Console.ReadLine());

        Console.Write("b: ");
        double secondNum = double.Parse(Console.ReadLine());

        Console.Write("c: ");
        double thirdNum = double.Parse(Console.ReadLine());

        double sum = firstNum + secondNum + thirdNum;

        Console.WriteLine(sum);
    }
}

