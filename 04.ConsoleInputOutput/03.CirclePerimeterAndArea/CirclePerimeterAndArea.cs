using System;
class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("radius: ");
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI*Math.Pow(r, 2);
        Console.WriteLine("Perimeter: " + "{0:0.00}",perimeter);
        Console.WriteLine("Area: " + "{0:0.00}",area);
    }
}

