
using System;

class Box<T>
{
    private T data;

    public void SetValue(T value)
    {
        data = value;
    }

    public T GetValue()
    {
        return data;
    }

    public void Display()
    {
        Console.WriteLine("Value: " + data);
    }
}

class Program
{
    static void Main()
    {
       
        Box<int> intBox = new Box<int>();
        intBox.SetValue(100);
        intBox.Display();

       
        Box<string> strBox = new Box<string>();
        strBox.SetValue("Hello Chetan");
        strBox.Display();
    }
}