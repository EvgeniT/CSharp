using System;

class ComparingFloats
{
    static void Main()
    {
        decimal eps = 0.000001m;

        Console.Write("Number a: ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("Number b: ");
        decimal b = decimal.Parse(Console.ReadLine());

        if (Math.Abs(a - b) > eps)
        {
            Console.WriteLine("false");
            Console.WriteLine("The difference of" + (a - b) + " is > " + eps);
        }
        else if(Math.Abs(a - b) < eps)
        {
            Console.WriteLine("true");
            Console.WriteLine("The difference of" + (a - b) + " is < " + eps);
        }
        else if (Math.Abs(a - b) == eps)
        {
            Console.WriteLine("false");
            Console.WriteLine("Border case. The difference 0.000001 == eps. We consider the numbers are different.");
        }
    }
}

