using System;
using System.Linq;

    class Program
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());               
            }
            double average = numbers.Average();
            Console.WriteLine("min = {0}",numbers.Min());
            Console.WriteLine("max = {0}", numbers.Max());
            Console.WriteLine("sum = {0}", numbers.Sum());
            Console.WriteLine("avg = {0:0.00}", numbers.Average());
        }
    }

