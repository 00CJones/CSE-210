using System;

public class Resume
{
    public string name;
    public List<Job> myListOfJobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"{this.name}");
        Console.WriteLine($"Jobs: ");

        foreach (Job job in myListOfJobs)
        {
            job.Display();
        }
    }
}
