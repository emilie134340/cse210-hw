namespace Fourdation1;
using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Video 1", "Author 1", "10:30");
        video1.AddComment("Commenter 1", "Great video!");
        video1.AddComment("Commenter 2", "Maybe make it shorter next time.");
        video1.AddComment("Commenter 3", ":)");

        Video video2 = new Video("Video 2", "Author 2", "15:32");
        video2.AddComment("Commenter 1", "Wow");
        video2.AddComment("Commenter 2", "Okay");
        video2.AddComment("Commenter 3", "Hmmmmm");
        
        Video video3 = new Video("Video 3", "Author 3", "34:54");
        video3.AddComment("Commenter 1", "Yeehaw");
        video3.AddComment("Commenter 2", "<3");
        video3.AddComment("Commenter 3", "One more comment.");

        List<Video> videos = new List<Video> { video1, video2, video3 };

        // display the information about the videos along with the comments
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length);
            Console.WriteLine("Number of Comments: " + video.NumberOfComments());
            Console.WriteLine("Comments: ");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine(" - " + comment.Name + ": " + comment.Text);
            }
            Console.WriteLine();
        }
    }
}