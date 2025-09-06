using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        int number;
        int totalSum = 0;
        List<int> numbers = new List<int>();
       

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {

            Console.Write("Enter number:");
            string valueNumber = Console.ReadLine();
            number = int.Parse(valueNumber);


            if (number != 0)
            {
            numbers.Add(number);
            }
          

        } while (number != 0);

        int largest = numbers[0];   

        foreach (int value in numbers)
        {
            totalSum += value;

            if (value > largest)
            {
                largest = value;
            }
        }
        float average = (float)totalSum / numbers.Count;

        Console.WriteLine("The sum is = " + totalSum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + largest);

    }
}