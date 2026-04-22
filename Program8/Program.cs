using System;

class Program
{
    delegate void MyDelegate();

    static void Method1()
    {
        Console.WriteLine("Method 1 called");
    }

    static void Method2()
    {
        Console.WriteLine("Method 2 called");
    }

    static void Main()
    {
        MyDelegate d;

        d = Method1;   // first method
        d += Method2;  // add second method

        d();  // calls both methods
    }
}
// multicast delegate code 