using System;

class Program
{
    static void Main(string[] args)
    {
        var videos = new List<Video>();

        var video1 = new Video("How to Code in C#", "Code Ninja", 500);
        video1.AddComment("John", "Great video!");
        video1.AddComment("Joe", "Thanks so much, I learned a lot.");
        video1.AddComment("Krista", "That was so helpful!");
        videos.Add(video1);

        var video2 = new Video("The Concept of Abstraction", "Abstract Wizard", 300);
        video2.AddComment("Mary", "Awesome content!");
        video2.AddComment("Elizabeth", "Very helpful for me.");
        video2.AddComment("Cole", "You explained this very well.");
        videos.Add(video2);

        var video3 = new Video("Making a program", "Programmer", 1000);
        video3.AddComment("Tim", "Liked the examples.");
        video3.AddComment("Clive", "Very Nice!");
        video3.AddComment("Jill", "This was so helpful!");
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.PrintVideoInfo();
        }
    }
}