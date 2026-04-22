using System;

class Program
{
    // Declare delegate
    delegate int MathOperation(int a, int b);

    // Methods
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static void Main()
    {
        // Assign Add method
        MathOperation op = Add;

        // Invoke Add
        int result1 = op(10, 5);
        Console.WriteLine("Addition: " + result1);

        // Change to Subtract
        op = Subtract;
        int result2 = op(10, 5);
        Console.WriteLine("Subtraction: " + result2);
    }
}