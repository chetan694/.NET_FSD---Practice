using System;

class Program
{
    // Step 1: Declare delegate
    delegate int MathOperation(int a, int b);

    // Step 2: Methods
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
        // Step 3: Assign Add method
        MathOperation op = Add;

        // Step 4: Invoke Add
        int result1 = op(10, 5);
        Console.WriteLine("Addition: " + result1);

        // Step 5: Change to Subtract
        op = Subtract;
        int result2 = op(10, 5);
        Console.WriteLine("Subtraction: " + result2);
    }
}