using System;
using System.Collections.Generic;

// Simple Customer class
class Customer
{
    public int Id;
    public string Name;

    public Customer(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

// Simple Order class
class Order
{
    public int OrderId;
    public string Product;
    public string Category;
    public string Status;

    public Stack<string> StatusHistory = new Stack<string>();

    public Order(int id, string product, string category)
    {
        OrderId = id;
        Product = product;
        Category = category;
        Status = "Placed";

        StatusHistory.Push(Status);
    }

    public void UpdateStatus(string newStatus)
    {
        Status = newStatus;
        StatusHistory.Push(newStatus);
    }
}

class Program
{
    static void Main()
    {
        // Collections
        List<Order> orders = new List<Order>();
        Dictionary<int, Customer> customers = new Dictionary<int, Customer>();
        HashSet<string> categories = new HashSet<string>();
        Queue<Order> queue = new Queue<Order>();

        // Add customers
        customers.Add(1, new Customer(1, "Chetan"));
        customers.Add(2, new Customer(2, "Rahul"));

        // Create orders
        Order o1 = new Order(1, "Laptop", "Electronics");
        Order o2 = new Order(2, "Shoes", "Fashion");

        // Add to list
        orders.Add(o1);
        orders.Add(o2);

        // Add categories (no duplicates)
        categories.Add(o1.Category);
        categories.Add(o2.Category);

        // Add to queue
        queue.Enqueue(o1);
        queue.Enqueue(o2);

        // Process orders
        Console.WriteLine("Processing Orders:");
        while (queue.Count > 0)
        {
            Order o = queue.Dequeue();
            Console.WriteLine("Order " + o.OrderId);

            o.UpdateStatus("Processing");
            o.UpdateStatus("Delivered");
        }

        // Show orders
        Console.WriteLine("\nOrders:");
        foreach (Order o in orders)
        {
            Console.WriteLine(o.OrderId + " - " + o.Product + " - " + o.Status);
        }

        // Show status history
        Console.WriteLine("\nStatus History:");
        foreach (Order o in orders)
        {
            Console.WriteLine("Order " + o.OrderId);
            foreach (string s in o.StatusHistory)
            {
                Console.WriteLine(s);
            }
        }

        // Show categories
        Console.WriteLine("\nCategories:");
        foreach (string c in categories)
        {
            Console.WriteLine(c);
        }
    }
}