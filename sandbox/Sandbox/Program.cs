using System;

class Program
{
    static void Main(string[] args)
    {
        int seconds = 10;
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
}
