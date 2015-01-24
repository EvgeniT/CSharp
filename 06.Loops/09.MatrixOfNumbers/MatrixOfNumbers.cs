using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n >= 1 && n <= 20)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1 ; j <= n+ i; j++)
                {
                    Console.Write("{0,2}", j);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Your number should be > 0 and < 20");
        }
    }
}

