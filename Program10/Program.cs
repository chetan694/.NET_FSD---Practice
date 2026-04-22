using System;
using System.Diagnostics;

class BinarySearchProgram
{
    static int BinarySearch(int[] arr, int key)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == key)
                return mid;
            else if (arr[mid] < key)
                left = mid + 1;
            else
                right = mid - 1;
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

        // IMPORTANT: Sort before Binary Search
        Array.Sort(arr);

        Stopwatch sw = new Stopwatch();

        sw.Start();
        int result = BinarySearch(arr, key);
        sw.Stop();

        if (result != -1)
            Console.WriteLine($"Element found at index {result}");
        else
            Console.WriteLine("Element not found");

        Console.WriteLine($"Execution Time: {sw.Elapsed.TotalMilliseconds} ms");

        Console.WriteLine("Time Complexity: O(log n)");
    }
}