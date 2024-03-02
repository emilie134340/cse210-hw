namespace Mindfulness;
using System;

class ReflectionActivity : Activity
{
    // reflection prompts array, random indexes will be selected
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    // questions array, random indexes will be selected
    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // constructor where there is the activity name and description, with the duration being filled in with user input
    public ReflectionActivity(int duration) : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration) { }

    // choose a random prompt and then ask random questions about that prompt. 
    protected override void PerformActivity()
    {
        Random random = new Random();
        int index = random.Next(prompts.Length);
        Console.WriteLine("Consider this promt:\n");
        Console.WriteLine($"----- {prompts[index]} -----\n");
        Console.Write("When you have something in mind, press Enter to continue: ");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Use each of the following questions to expound on this experience.");
        Console.WriteLine($"Starting soon... \b");
        ShowSpinner();
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            int index2 = random.Next(questions.Length);
            Console.Write($"> {questions[index2]} ");
            ShowSpinner(); 
        }

        Console.WriteLine("\nWell done!");
    }
}