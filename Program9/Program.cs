using System;
using System.Diagnostics;

class LinearSearchProgram
{
    static int LinearSearch(int[] arr, int key)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key)
                return i;
        }
        return -1;
    }

    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter element to search: ");
        int key = int.Parse(Console.ReadLine());

        Stopwatch sw = new Stopwatch();

        sw.Start();
        int result = LinearSearch(arr, key);
        sw.Stop();

        if (result != -1)
            Console.WriteLine($"Element found at index {result}");
        else
            Console.WriteLine("Element not found");

        Console.WriteLine($"Execution Time: {sw.Elapsed.TotalMilliseconds} ms");

        Console.WriteLine("Time Complexity: O(n)");
    }
}