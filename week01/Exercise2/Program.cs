using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string valueGrade = Console.ReadLine();
        int grade = int.Parse(valueGrade);

        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats! You passed! :D ");
        }
        else
        {
            Console.WriteLine(":( Better luck next time!");
        }

    }
}