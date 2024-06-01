using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 1;
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");
        while (userChoice != 0)
        {
            Console.WriteLine("\nPlease select a scripture to memorize: ");
            Console.WriteLine("1. Proverbs 3:5-6");
            Console.WriteLine("2. John 3:16");
            Console.WriteLine("0. Exit Program");
            Console.Write("\nPress a number to choose scripture or exit the program: ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                Reference reference = new Reference("Proverbs", 3, 5, 6);
                string text = "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
                Scripture scripture1 = new Scripture(reference, text);
                reference.Memorize(scripture1);
            }

            else if (userChoice == 2)
            {
                Reference reference2 = new Reference("John", 3, 16);
                string text2 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
                Scripture scripture2 = new Scripture(reference2, text2);
                reference2.Memorize(scripture2);
            }
        }
    }
}
