using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int n = int.Parse(Console.ReadLine()); 
        //By definition, the first two numbers in the Fibonacci sequence are 1 and 1, or 0 and 1, depending on the chosen starting point of the sequence, and each subsequent number is the sum of the previous two.
        int firstNumber = 0;
        int secondNumber = 1;
        int thirdNumber = 1;
        for (int i = 0; i < n; i++)
        {
            
            Console.Write(firstNumber+" ");
            firstNumber = secondNumber;
            secondNumber = thirdNumber;
            thirdNumber = firstNumber + secondNumber;
        }
    }
}

