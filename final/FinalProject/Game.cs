using System;

public class Game 
{
    Random random = new Random();
    private bool attack = true;
    private bool defend = false;
    private List<Weapon> enemyweapons;
    private List<Weapon> player1weapons;

    private List<string> battleModeMenu = [
        "Attack",
        "Defend",
    ];
    public void BattleMode(Character player1, Enemy enemy)
    {
        List<Ability> abilities = player1.GetAbilitiesList();
        if (abilities.Any(a => a is Dodge))
        {
            if (!battleModeMenu.Contains("Dodge"))
            {
                battleModeMenu.Add("Dodge");
            }
        }
        // Console.WriteLine("Made it to battle mode");
        while (enemy.GetHealth() > 0 && player1.GetHealth() > 0)
        {
            Console.WriteLine(player1);
            Console.WriteLine(enemy);
            for (int i = 0; i < battleModeMenu.Count; i++)
            {
                Console.WriteLine($"    {i + 1}. {battleModeMenu[i]}");
            }
            Console.Write("Select a number choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            bool enemyAttackStatus = enemy.GetEnemyAttackStatus(random);
            switch (choice)
            {
                case 1:
                    player1.SetAttackStatus(attack);
                    player1.Attack(enemy, player1.GetAttackWeapon(), enemyAttackStatus);
                    EnemyAttack(enemy, player1, enemyAttackStatus, player1.GetAttackStatus());
                    break;
                case 2:
                    player1.SetAttackStatus(defend);
                    player1.Defend(player1.GetDefenseWeapon());
                    EnemyAttack(enemy, player1, enemyAttackStatus, player1.GetAttackStatus());
                    break;
                case 3:
                   if (battleModeMenu.Contains("Dodge"))
                    {
                        Ability dodge = abilities.FirstOrDefault(a => a is Dodge);
                        dodge?.Use(player1, player1.GetHealth());
                    }
                    break;
            }
        }
        if (player1.GetHealth() != 0)
        {
            StealWeapons(player1, enemy);
        }
        if (enemy.GetName() == "Dark Knight")
        {
            if(enemy.GetHealth() == 0)
            {
                Console.WriteLine("Congratulations adventurer! You defeated the Dark Knight. Narnia is free once again. Thank you for your help!");
            }
        }
    }
    public void EnemyAttack(Character enemy, Character player1, bool enemyAttackStatus, bool player1AttackStatus)
    {
        if (enemy.GetHealth() > 0)
        {
            // Console.WriteLine(enemy.GetAttackStatus());
            if (enemyAttackStatus == true)
            {
                enemy.Attack(player1, enemy.GetAttackWeapon(), player1AttackStatus);
            }
        }
    }

    public void StealWeapons(Character player1, Character enemy)
    {
        enemyweapons = new List<Weapon>();
        player1weapons = new List<Weapon>();
        enemyweapons = enemy.GetWeaponsList();
        player1weapons = player1.GetWeaponsList();
        for (int i = 0; i < enemyweapons.Count(); i++)
        {
            player1weapons.Add(enemyweapons[i]);
        }
    }
}