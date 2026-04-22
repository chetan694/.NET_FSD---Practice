using System;

class Program
{
    // Method returning tuple (area, perimeter)
    static (double area, double perimeter) CalculateRectangle(double length, double width)
    {
        double area = length * width;
        double perimeter = 2 * (length + width);
        return (area, perimeter);
    }

    static void Main()
    {
        // Calling method
        var result = CalculateRectangle(10, 7);

        // Printing output
        Console.WriteLine("Output for the tuple implementation: " + result);

        // Access individually if needed
        Console.WriteLine("Area: " + result.area);
        Console.WriteLine("Perimeter: " + result.perimeter);
    }
}
//tuple implementation