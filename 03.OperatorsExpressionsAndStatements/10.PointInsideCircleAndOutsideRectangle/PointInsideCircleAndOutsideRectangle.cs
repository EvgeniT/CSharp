using System;

class PointInsideCircleAndOutsideRectangle
{
    static void Main()
    {
        double xo = 1;  //xcoord for circle
        double yo = 1;  //ycoord for circle
        double radius = 1.5;
        Console.Write("x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y: ");
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = ((x - xo) * (x - xo)) + ((y - yo) * (y - yo)) <= radius * radius;
        //Console.WriteLine(isInCircle);
        bool isInRectangle = ((x >= -1 && x <= 5) && (y >= -1 && y <= 1));
        //Console.WriteLine(isInRectangle);
        if (isInCircle && !isInRectangle)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}