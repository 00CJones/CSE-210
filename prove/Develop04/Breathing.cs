using System;
class Breathing : Activity
{
    public override void PerformActivity(int seconds)
    {
        int totalSeconds = seconds;
        int breatheInSeconds = 4;
        int breatheOutSeconds = 6;
        int cycleDuration = breatheInSeconds + breatheOutSeconds;
        int remainder = totalSeconds % 10;
        int halfRemainder = remainder / 2;
        Console.Clear();
        Console.Write("Get ready to breathe in ");
        Countdown(5);
        while (totalSeconds > 1)
        {
            if (remainder > 1)
            {
                Console.WriteLine("");
                Console.Write("\nBreathe in...");
                Countdown(halfRemainder);
                Console.Write("\nBreathe out...");
                Countdown(halfRemainder);
                totalSeconds -= remainder;
                remainder = 0;
                
            }
            
            if (totalSeconds >= cycleDuration)
            {
                Console.WriteLine("");
                Console.Write("\nBreathe in...");
                Countdown(breatheInSeconds);
                totalSeconds -= breatheInSeconds;

                Console.Write("\nBreathe out...");
                Countdown(breatheOutSeconds);
                totalSeconds -= breatheOutSeconds;
            }
        }
    }

    public override string GetDescription()
    {
        return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }


}