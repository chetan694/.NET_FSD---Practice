using System;
using System.Collections;

namespace Demo_NonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------- STACK ----------------
            Console.WriteLine("Non Generic Collection Implementation");

            Stack stack = new Stack();

            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14);
            stack.Push(true);

            Console.WriteLine("Length of stack is " + stack.Count);

            Console.WriteLine("Removing values from stack:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Element removed from stack is " + stack.Pop());

            // ---------------- STACK 2 ----------------
            Stack stack1 = new Stack();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);

            Console.WriteLine("Stack Length initially is " + stack1.Count);

            stack1.Push(4);
            stack1.Push(5);

            Console.WriteLine("Stack Length after adding 2 more elements is " + stack1.Count);

            Stack stack2 = new Stack();
            stack2.Push(10);
            stack2.Push(20);
            stack2.Push(30);
            stack2.Push(40);
            stack2.Push(50);

            Console.WriteLine("Stack Length after adding 2 more elements in stack2 is " + stack2.Count);

            // ---------------- HASHTABLE ----------------
            Hashtable hashtable = new Hashtable();

            // Adding key-value pairs
            hashtable.Add("Name", "John");
            hashtable.Add("Age", 30);
            hashtable.Add("City", "New York");
            hashtable.Add("IsStudent", true);
            hashtable.Add("Salary", 50000.0);

            // Retrieving values
            Console.WriteLine("Name: " + hashtable["Name"]);
            Console.WriteLine("Age: " + hashtable["Age"]);
            Console.WriteLine("City: " + hashtable["City"]);

            // Display all key-value pairs
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
            }

            Console.ReadKey();
        }
    }
}