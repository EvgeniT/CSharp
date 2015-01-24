using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("score:");
        int input = int.Parse(Console.ReadLine());
        if (input > 0 && input < 10)
        {
            if (input >= 1 && input <= 3)
            {
                int result = input * 10;
                Console.WriteLine(result);
            }
            if (input >= 4 && input <= 6)
            {
                int result = input * 100;
                Console.WriteLine(result);
            }
            if (input >= 7 && input <= 9)
            {
                int result = input * 1000;
                Console.WriteLine(result);
            }
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}


