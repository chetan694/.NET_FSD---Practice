using System;
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program
{
    static void Main()
    {
        
        Console.Write("Enter something: ");
        string input = Console.ReadLine();

        object value;

        
        if (int.TryParse(input, out int intVal))
            value = intVal;
        else if (double.TryParse(input, out double doubleVal))
            value = doubleVal;
        else
            value = input;

        
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

       
        var rectangle = (length: 10, width: 5);

        switch (rectangle)
        {
            case (int l, int w):
                Console.WriteLine($"Rectangle -> Length: {l}, Width: {w}");
                break;
        }

      
        var person = new Person { Name = "Chetan", Age = 12 };

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

//pattern matching
