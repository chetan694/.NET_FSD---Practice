using System;

class Program
{
    static void Main()
    {
        // STEP 1: Take input
        Console.Write("Enter something: ");
        string input = Console.ReadLine();

        object value;

        // Try converting input to int or double, otherwise keep as string
        if (int.TryParse(input, out int intVal))
            value = intVal;
        else if (double.TryParse(input, out double doubleVal))
            value = doubleVal;
        else
            value = input;

        // STEP 2: Pattern matching using switch
        switch (value)
        {
            case int i:
                Console.WriteLine($"You entered an Integer: {i}");
                break;

            case double d:
                Console.WriteLine($"You entered a Double: {d}");
                break;

            case string s:
                Console.WriteLine($"You entered a String: {s}");
                break;

            default:
                Console.WriteLine("Unknown type");
                break;
        }

        // STEP 3: Pattern matching with tuple
        var rectangle = (length: 10, width: 5);

        switch (rectangle)
        {
            case (int l, int w):
                Console.WriteLine($"Rectangle -> Length: {l}, Width: {w}");
                break;
        }

        // STEP 4: Pattern matching with properties
        var person = new Person { Name = "Chetan", Age = 22 };

        switch (person)
        {
            case { Age: > 18 }:
                Console.WriteLine($"{person.Name} is an Adult");
                break;

            case { Age: <= 18 }:
                Console.WriteLine($"{person.Name} is not an Adult");
                break;
        }
    }
}

// Class for property pattern matching
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}