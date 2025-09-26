using System;
using System.Collections.Generic;

public class Comment
{
    private string _userName;
    private string _text;

    // Constructor
    public Comment(string userName, string text)
    {
        _userName = userName;
        _text = text;
    }

    // Display the comment info
    public void DisplayComment()
    {
        Console.WriteLine($"User: {_userName} - Comment: {_text}");
    }
}