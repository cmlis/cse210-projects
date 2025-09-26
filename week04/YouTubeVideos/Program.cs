using System;

class Program
{
    static void Main(string[] args)
    {
        //First Video
        Video video1 = new Video("Learning C#", "Camila", "800");

        Comment com1 = new Comment("Gabriel", "Great explanation!");
        Comment com2 = new Comment("Maria", "Very helpful, thanks!");
        Comment com3 = new Comment("Lucas", "Love it!");
        video1.AddComment(com1);
        video1.AddComment(com2);
        video1.AddComment(com3);
        video1.DisplayVideoInfo();
        Console.ReadLine();

        //Second Video
        Video video2 = new Video("Review Abstraction", "Brother Reading", "900");

        Comment com4 = new Comment("Ian", "Awsome!");
        Comment com5 = new Comment("Bia", "Thanks for the video! Just sent an email wiht a question ");
        video2.AddComment(com4);
        video2.AddComment(com5);
   
       
        video2.DisplayVideoInfo();
        Console.ReadLine();

       
    }
}