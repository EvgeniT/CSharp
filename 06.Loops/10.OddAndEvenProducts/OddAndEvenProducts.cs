using System;

class OddAndEvenProducts
{
    static void Main()
    {

        string readNumbers = Console.ReadLine();
        string[] numbers = readNumbers.Split();
        int even = 1;
        int odd = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = int.Parse(numbers[i]);
            if (i % 2 == 0)
            {
                even = even * number;
            }
            else
            {
                odd = odd * number;
            }
        }
        if (even == odd)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = " + even);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = " + odd);
            Console.WriteLine("even_product = " + even);
        }
    }
}

