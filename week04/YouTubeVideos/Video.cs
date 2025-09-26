public class Video
{
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments;

    // Constructor
    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }


    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Display video info
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (in sec): {_length}");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}