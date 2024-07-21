using System;
using System.Collections;

public class Menu
{
    private int choice;
    private List<Location> locations;
    private List<Character> characters;
    private string[] LocationMenu = {
        "Forest",
        "Village",
        "Cave",
        "Castle",
        "Weapons Inventory",
        "Quit Game"
    };
    public bool MainMenu(Location village, Location forest, Location cave, Location castle, int playerHealth, WeaponsManager inventory, Player1 player1)
    {
        if (playerHealth == 0)
        {
            choice = 6;
            Console.WriteLine("Game Over!");
        }
        else
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("");
            Console.WriteLine("Where would you like to go? ");
            for (int i = 0; i < LocationMenu.Length; i++)
                {
                    Console.WriteLine($"    {i + 1}. {LocationMenu[i]}");
                }
            Console.Write("Select a number choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
        }
        switch (choice)
        {
            case 1:
                forest.Run();
                break;

            case 2:
                village.Run();
                break;

            case 3:
                cave.Run();
                break;

            case 4:
                castle.Run();
                break;
            case 5:
                inventory.Run(player1);
                break;
            case 6:
                return false;
            
        
        }return true;

    }
}