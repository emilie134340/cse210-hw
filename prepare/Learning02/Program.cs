using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        // new Job instance job1
        Job job1 = new Job();
        // set member variables using the dot notation ex: job1._jobTitle = "Software Engineer";
        job1._jobTitle = "Digital Accessibility Team Lead";
        job1._company = "BYU-Idaho";
        job1._startYear = 2023;
        job1._endYear = 2024;
        // verify the company displays correctly using dot notation to access the member variable
        job1.Display();
        // create another Job instance job2 and display the company on the screen too
        Job job2 = new Job();
        job2._jobTitle = "TA Virtualized Enterprise Systems";
        job2._company = "BYU-Idaho";
        job2._startYear = 2023;
        job2._endYear = 2023;
        // verify the company displays correctly using dot notation to access the member variable
        job2.Display();

        // new instance of Resume class
        Resume resume1 = new Resume();
        resume1._name = "Emilie Mickelsen";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}