namespace Fourdation1;
using System;
using System.Transactions;

class Video
{
    // get and set variables for video
    public string Title { get; set; }
    public string Author { get; set; }
    public string Length { get; set; }
    // List of Comments
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, string length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(string name,  string text)
    {
        Comments.Add(new Comment(name, text));
    }

    public int NumberOfComments()
    {
        return Comments.Count;
    }
    
}