using System;
class Breathing : Activity
{
    public override void PerformActivity(int seconds)
    {
        int totalSeconds = seconds;
        int breatheInSeconds = 5;
        int breatheOutSeconds = 5;
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
                breatheInCountdown(halfRemainder);
                Console.Write("\nBreathe out.....");
                breatheOutCountdown(halfRemainder);
                totalSeconds -= remainder;
                remainder = 0;
                
            }
            
            if (totalSeconds >= cycleDuration)
            {
                Console.WriteLine("");
                Console.Write("\nBreathe in...");
                breatheInCountdown(breatheInSeconds);
                totalSeconds -= breatheInSeconds;

                Console.Write("\nBreathe out.......");
                breatheOutCountdown(breatheOutSeconds);
                totalSeconds -= breatheOutSeconds;
            }
        }
    }

    public override string GetDescription()
    {
        return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }


}