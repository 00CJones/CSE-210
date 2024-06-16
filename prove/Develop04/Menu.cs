using System;

class Menu
{
    private string[] menuOptions = {
        "Breathing",
        "Reflection",
        "Listing",
        "Quit"
    };

    public bool RunMenu()
    {
        Console.Clear();
        Console.WriteLine("Meditation Activites");
        for (int i = 0; i < menuOptions.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {menuOptions[i]}");
        }

        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (choice)
        {
            case 1:
                // Create an instance of Breathing class and run it
                Breathing breathing = new Breathing();
                breathing.Run();
                break;
            case 2:
                // Create an instance of Reflecting class and run it
                Reflecting reflecting = new Reflecting();
                reflecting.Run();
                break;
            case 3:
                // Create an instance of Listing class and run it
                Listing listing = new Listing();
                listing.Run();
                break;
            case 4:
                // Quit the program
                Console.Clear();
                Console.WriteLine("Goodbye!");
                return false;
            default:
                // Invalid option, display error message
                Console.WriteLine("Invalid option please try again.");
                break;
        } return true;
    }
}