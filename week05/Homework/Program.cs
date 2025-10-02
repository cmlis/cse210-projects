using System;

class Program
{
    static void Main(string[] args)
    {
    
        Assignment a1 = new Assignment("Camila Santana", "Classes");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();

    
        MathAssignment a2 = new MathAssignment("Miguel Santos", "Addition", "2", "3");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment a3 = new WritingAssignment("Thailis Gonzalez", "Public Health", "COVID19");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}