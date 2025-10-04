using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    public int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }


    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity\n");
        
        Console.WriteLine($"{_description} \n");
        
        Console.Write("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out _duration))
        {
            _duration = 30; // default if invalid input
        }
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }
        
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(6);
    }

    // Spinner animation
    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
            i++;
        }
    }

    // Countdown animation
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}
