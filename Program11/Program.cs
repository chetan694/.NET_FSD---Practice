using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
    public int Attendance { get; set; }
    public int Participation { get; set; }
}

class Program
{
    // Delegate for evaluation
    public delegate void Evaluate(Student s);

    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student { Name = "Aman", Marks = 60, Attendance = 80, Participation = 70 },
            new Student { Name = "Riya", Marks = 45, Attendance = 75, Participation = 60 },
            new Student { Name = "Karan", Marks = 85, Attendance = 90, Participation = 80 }
        };

        // Anonymous method
        Evaluate eval = delegate (Student s)
        {
            int total = s.Marks + s.Attendance + s.Participation;

            Console.WriteLine("Student: " + s.Name);
            Console.WriteLine("Total Score: " + total);

            if (total > 200)
                Console.WriteLine("Performance: Excellent");
            else if (total > 150)
                Console.WriteLine("Performance: Good");
            else
                Console.WriteLine("Performance: Average");

            Console.WriteLine();
        };

        foreach (var s in students)
        {
            eval(s);
        }

        // Lambda expression: eligibility check
        Func<Student, bool> isEligible = s => s.Marks > 50;

        Console.WriteLine("Eligible Students:");
        var eligibleStudents = students.Where(isEligible);

        foreach (var s in eligibleStudents)
        {
            Console.WriteLine(s.Name);
        }

        Console.WriteLine();

        // Lambda expression: filtering high performers
        var topStudents = students.Where(s => s.Marks > 70);

        Console.WriteLine("Top Performers:");
        foreach (var s in topStudents)
        {
            Console.WriteLine(s.Name);
        }
    }
}