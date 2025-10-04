using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> AllPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private List<string> AllQuestions = new List<string>
    {
        "Why was this meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn from this experience?",
        "How could you apply this lesson in the future?"
    };

    private List<string> unusedPrompts;
    private List<string> unusedQuestions;
    private Random rand;

    public ReflectionActivity()
        : base("Reflection",
               "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
        rand = new Random();
        unusedPrompts = new List<string>(AllPrompts);
        unusedQuestions = new List<string>(AllQuestions);
    }

    public void Run()
    {
        DisplayStartingMessage();


        // Show one random prompt
        string prompt = GetRandomPrompt();
        if (prompt != null)
        {

            Console.WriteLine("\nConsider the following prompt:");
            Console.WriteLine($"\n --- {prompt} ---");
            Console.WriteLine("\nWhen you have something in mind, press enter to continue");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            
            
        }

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.Clear();
        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            if (question == null)
                break;

            Console.Write($"> {question} ");
            ShowSpinner(8);
            Console.WriteLine();
            
       
        }

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

    public string GetRandomQuestion()
    {
        if (unusedQuestions.Count == 0)
        {
            Console.WriteLine("All questions have already been listed in this session.");
            return null;
        }

        int index = rand.Next(unusedQuestions.Count);
        string question = unusedQuestions[index];
       //Taking out the questions from the list that have already been asked
        unusedQuestions.RemoveAt(index);
        return question;
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        if (prompt != null)
        {
            Console.WriteLine(prompt);
            ShowCountDown(5);
        }
    }

    public void DisplayQuestions()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            if (question == null) break;

            Console.WriteLine(question);
            ShowSpinner(5);
        }
    }
}
