using System;

abstract class Activity
{
    public virtual void Loading(int seconds = 3)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        string[] spinner = {"|", "/", "-", "\\"};
        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;

            if (i >= 4)
            {
                i = 0;
            }
        }
    }
    public virtual void Run()
    {
        DisplayStartingMessage();
        int duration = EnterTimeDuration();
        PerformActivity(duration);
        DisplayEndingMessage(duration);
    }
    public abstract void PerformActivity(int duration);
    public abstract string GetDescription();

    public virtual void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public virtual void breatheInCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($".{i}");
            Thread.Sleep(1000);
            Console.Write("\b");
        }
    }
    public virtual void breatheOutCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            // Print dots for shrinking effect
            Console.Write(new string('.', i));
            
            // Calculate the position to write the number
            int numberLength = i.ToString().Length;
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write(i); // Write the countdown number
            
            Thread.Sleep(1000);
            
            // Move the cursor back and overwrite the previous dots and number
            for (int j = 0; j < i + numberLength; j++)
            {
                Console.Write("\b \b");
            }
        }
    }
    
    public virtual void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Loading {this.GetType()} Activity");
        Loading();
        Console.WriteLine("");
        Console.WriteLine(GetDescription());
        this.Loading(8);
    }
    public virtual int EnterTimeDuration()
    {
        Console.WriteLine("");
        Console.Write("For how many seconds would you like to run the activity? ");
        int userSeconds = int.Parse(Console.ReadLine());
        Loading();
        return userSeconds;
    }
    public virtual void DisplayEndingMessage(int duration)
    {
        Console.WriteLine("");
        Console.WriteLine($"\nYou have completed {duration} seconds of the {this.GetType()} Activity!");
        Loading();
    }
}
