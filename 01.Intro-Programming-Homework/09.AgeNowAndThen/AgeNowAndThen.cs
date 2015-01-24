using System;

class AgeNowAndThen
{
    static void Main()
    {
        int AgeNow;
        Console.WriteLine("Please enter your age:");
        if ((int.TryParse(Console.ReadLine(), out AgeNow)) && (AgeNow > 0) && (AgeNow < 120))
        {
            Console.WriteLine("Your age after 10 years will be" +" "+ (AgeNow + 10));
        }
        else
        {
            Main();
        }

    }
}

