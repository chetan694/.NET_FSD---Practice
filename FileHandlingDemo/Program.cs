using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Step 1: Define file paths
        string filePath = "sample.txt";
        string copyPath = "copy.txt";

        try
        {
            // Step 2: Create file
            Console.WriteLine("Creating a file...");
            File.Create(filePath).Close(); 

            // Step 3: Write data to file
            Console.WriteLine("Writing to the file...");
            File.WriteAllText(filePath, "Hello, this is the first line of the file..!!");

            // Step 4: Append data
            Console.WriteLine("Appending data to the file...");
            File.AppendAllText(filePath, "\nThis data is appended to the text.");

           
            File.WriteAllText(filePath, "New Text");

            // Step 5: Read data
            Console.WriteLine("Reading from the file...");
            string content = File.ReadAllText(filePath);
            Console.WriteLine("\nFile Content:\n" + content);

            // Step 6: Copy file
            Console.WriteLine("\nCopying file...");
            File.Copy(filePath, copyPath, true);

            Console.WriteLine("File copied successfully!");

           
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred: " + ex.Message);
        }
    }
}