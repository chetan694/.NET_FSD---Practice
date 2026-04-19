using System;

// Base class
class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

// Derived class
class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

// Another derived class
class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    static void Main()
    {
        Animal a;

        a = new Dog();
        a.Sound();   // Dog barks

        a = new Cat();
        a.Sound();   // Cat meows
    }
}