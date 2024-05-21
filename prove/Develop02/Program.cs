//Program
using System;
 
class Program
{
    static Journal journal = new Journal(); // Create an instance of the Journal class
 
    static void Main(string[] args)
    {
        int userChoice = 1;
        while (userChoice != 0)
        {  
            Console.WriteLine("Journal Options");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("0. Exit Program.");
            Console.Write("Choose a number: ");
            userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    journal.NewEntry();
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                case 4:
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                case 0:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}