using System;

public class Location
{
    private string name;
    private Player1 player1;
    private Enemy residentEnemy;
    private Villager person;
    private Weapon weaponToBeFound;
    private bool isEnemy;
    private Game game;

    public string GetName()
    {
        return name;
    }
    // be sure to specify enemy type class
    public Location(string name, Enemy residentEnemy, Player1 player1, Game game)
    {
        this.name = name;
        this.residentEnemy = residentEnemy;
        this.isEnemy = true;
        this.game = game;
        this.player1 = player1;
    }
    public Location(string name, Villager person, Player1 player1, Game game)
    {
        this.name = name;
        this.person = person;
        this.isEnemy = false;
        this.game = game;
        this.player1 = player1;
    }
    public void Run()
    {
        Console.WriteLine(this.ToString());
        Console.WriteLine("What do you do?");
        Console.WriteLine("1. Interact");
        Console.WriteLine("2. Leave");
        Console.Write("Select a number to continue: ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            if (isEnemy)
            {

                Console.WriteLine($"{residentEnemy.GetName()} attacks you!");
                // Console.WriteLine($"{player1} {residentEnemy}");
                game.BattleMode(player1, residentEnemy);
            }
            else
            {
                person.OldManInteract(player1);
            }
        }


    }
    public override string ToString()
    {
        if (isEnemy)
        {
            return $"You have entered the {this.GetName()} where you encounter a {residentEnemy.GetName()}";
        }
        else
        {
            return $"You have entered the {this.GetName()} where you encounter a {person.GetName()}";
        }
    }
}