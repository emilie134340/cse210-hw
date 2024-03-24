namespace Fourdation1;
using System;

class Comment
{
    // get and set variables for comment
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}