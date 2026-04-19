using System;

class Calculator
{
    // Method 1: Add two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Method 2: Add three integers
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Method 3: Add two doubles
    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program2
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Add 2 ints: " + calc.Add(10, 20));
        Console.WriteLine("Add 3 ints: " + calc.Add(10, 20, 30));
        Console.WriteLine("Add 2 doubles: " + calc.Add(5.5, 4.5));
    }
}