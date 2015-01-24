using System;

class BiggestNumber2
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        int biggestNumber = firstNumber;
        if(secondNumber>biggestNumber)
        {
            biggestNumber = secondNumber;
        }
        if(thirdNumber>biggestNumber)
        {
            biggestNumber = thirdNumber;
        }
        Console.WriteLine(biggestNumber);
    }
}
