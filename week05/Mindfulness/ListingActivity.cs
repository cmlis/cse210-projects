using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> AllPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    private List<string> unusedPrompts;
    private Random rand;

    public ListingActivity()
        : base("Listing",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        rand = new Random();
        unusedPrompts = new List<string>(AllPrompts);
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        if (prompt != null)
        {

            Console.WriteLine("\nList as many responses you can to the following prompt:");
            Console.WriteLine($" --- {prompt} ---");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            
            
        }
    

        List<string> items = GetListFromUser();
        Console.WriteLine($"You listed {items.Count} items!");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        if (unusedPrompts.Count == 0)
        {
            Console.WriteLine("All prompts have already been listed in this session.");
            return null;
        }

        int index = rand.Next(unusedPrompts.Count);
        string prompt = unusedPrompts[index];
        unusedPrompts.RemoveAt(index);
        return prompt;
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        // Console.WriteLine("Start listing items (press Enter after each):");

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                items.Add(input.Trim());

            if (DateTime.Now >= endTime)
                break;
        }

        return items;
    }
}
