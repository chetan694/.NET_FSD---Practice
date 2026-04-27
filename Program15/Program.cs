using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }

        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}