using System;

class Hello{
 
  public static void Main(){
    
    Console.WriteLine("Enter the Number to print=");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"The Number that you entered is {a}");
  }
}