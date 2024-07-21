using System;

class Program
{
    static void Main(string[] args)
    {
        bool runGame = true;

        Sword sword = new Sword("Sword", 3, 1, 5);
        Sword goblinsword = new Sword("Goblin Sword", 1, 2, 2);
        Sword orcsword = new Sword("Orc Sword", 3, 3, 6);
        Sword bigsword = new Sword("Big Sword", 4, 4, 7);
        Mace mace = new Mace("Mace", 5, 2);
        Shield shield = new Shield("Shield", 0, 3);

        None none = new None("None");
        Dodge dodge = new Dodge("Dodge");
        // Console.WriteLine(sword);

        WeaponsManager playerinventory = new WeaponsManager();

        Player1 player1 = new Player1("Player 1", 10, sword, shield, none);
        Enemy goblin = new Enemy("Goblin", 10, goblinsword, goblinsword);
        Enemy orc = new Enemy("Orc", 14, orcsword, orcsword);
        Villager oldman = new Villager("Old Man", 10, dodge);
        Enemy darknight = new Enemy("Dark Knight", 16, mace, mace);

        Game game = new Game();
        Location forest = new Location("Forest", goblin, player1, game);
        Location village = new Location("Village", oldman, player1, game);
        Location cave = new Location("Cave", orc, player1, game);
        Location castle = new Location("Castle", darknight, player1, game);

        // game.BattleMode(player1, goblin);
        while (runGame)
        {
            Menu menu = new Menu();
            runGame = menu.MainMenu(village, forest, cave, castle, player1.GetHealth(), playerinventory, player1);
        }



    }
}