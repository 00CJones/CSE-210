using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        // Convert the input string to an integer
        int number;
        if (int.TryParse(input, out number))
        {
            // The input was successfully converted to an integer
            string letter = "";
            if (number >= 90)
                {
                    letter = "A";
                }
            else if (number >= 80)
            {
                letter = "B";
            }
            else if (number >= 70)
            {
                letter = "C";
            }
            else if (number >= 60)
            {
                letter = "D";
            }
            else if (number < 60)
            {
                letter = "F";
            }
            Console.WriteLine($"Your grade is: {letter}");
            if (number >= 70)
            {
                Console.WriteLine("Congrats! You passed the class!");
            }
            else
            {
                Console.WriteLine("You suck.");
            }
        }
        else
        {
            // The input was not a valid integer
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
            }
}