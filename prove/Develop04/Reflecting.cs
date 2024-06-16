using System;
class Reflecting : Activity
{
    Random random = new Random();
    private static readonly string[] Prompts = 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private static readonly string[] Questions = 
    {
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

    public override void PerformActivity(int seconds)
    {
        int timer = seconds / 2;    // asks two questions per prompt
        int remainder = seconds % 2;
        if (remainder > 0)          // handles any odd number cases
        {
            timer += 1;
        }
        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        int index = random.Next(Prompts.Length);
        Console.WriteLine($" --- {Prompts[index]} ---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter.");
        Console.ReadLine();
        Console.Write("Get ready to reflect in...");
        this.Countdown(5);
        Console.WriteLine("");
        while (seconds > 0)
        {         
            int index2 = random.Next(Questions.Length);
            Console.Write($"{Questions[index2]}...");
            this.Loading(timer);
            seconds -= timer;
            Console.WriteLine("");
        }
    }
    public override string GetDescription()
    {
        return "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
}