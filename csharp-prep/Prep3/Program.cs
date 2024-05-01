using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Please list the magic number: ");
        // int MagicNumber = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1, 101);
        Console.WriteLine("The magic number is between 1 and 101.");
        int guess = -1;

        while (guess != MagicNumber)
        {
            Console.Write("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < MagicNumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else if (guess > MagicNumber)
            {
                Console.WriteLine("Your guess is too high.");
            }
        }
        Console.Write("You guessed the magic number!");
        
    }
}