using System;

class RandomNumbers
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Random random = new Random();

        for (int i = 0; i < numbers; i++)
        {

            int newNumber = random.Next(min, max);
            Console.Write(newNumber+" ");
        }
        Console.WriteLine();
    }
}

