using System;

class Program
{
    static void Main(string[] args)
    {
        int userchoice = 1;
        List<int> numbers = new List<int>();

        while (userchoice != 0)
        {
            Console.Write("Enter a number. Press 0 when you are finished: ");
            userchoice = int.Parse(Console.ReadLine());

            if (userchoice != 0)
            {
                numbers.Add(userchoice);
            }

        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"Total Sum: {sum}");


        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"Average: {average}");

        int maximum = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }
        Console.WriteLine($"Maximum: {maximum}");
    }
}