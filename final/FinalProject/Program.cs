using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello FinalProject World!");
        Sword sword = new Sword("Sword", 3, 1, 5);
        Sword goblinsword = new Sword("Goblin Sword", 1, 2, 2);
        Shield shield = new Shield("Shield", 0, 5);
        Console.WriteLine(sword);

        Player1 player1 = new Player1("Bob", 10, sword, shield);
        Enemy goblin = new Enemy("Goblin", 10, goblinsword, goblinsword);

        Game game = new Game();
        game.BattleMode(player1, goblin);

    }
}