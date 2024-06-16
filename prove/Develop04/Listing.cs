using System;
class Listing : Activity
{
    Random random = new Random();
    private static readonly string[] Prompts = 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public override void PerformActivity(int seconds)
    {
        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine("");
        int index = random.Next(Prompts.Length);
        Console.WriteLine($" --- {Prompts[index]} ---");
        Console.WriteLine("");
        Console.Write("You may begin in...");
        this.Countdown(5);
        Console.Write("\n");
        int items = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            items += 1;
        }
        Console.Write("\n");
        Console.WriteLine($"You wrote {items} items!!");
        Loading();
    }
    public override string GetDescription()
    {
        return "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
}