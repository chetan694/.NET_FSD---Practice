using System;


class SleepingAfterMidnightException : Exception
{
    public SleepingAfterMidnightException(string msg) : base(msg) { }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter hour (0-23): ");
            int h = int.Parse(Console.ReadLine());

            if (h >= 0 && h < 6)
                throw new SleepingAfterMidnightException("Sleeping after midnight!");

            if (h < 0 || h > 23 )
                throw new SleepingAfterMidnightException("Please enter between 0 to 23...I think you are from another planet!");
            
                Console.WriteLine("Good sleeping time.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}