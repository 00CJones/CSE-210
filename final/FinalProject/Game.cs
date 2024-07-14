using System;

public class Game 
{
    Random random = new Random();
    private bool attack = true;
    private bool defend = false;

    private string[] battleModeMenu = {
        "Attack",
        "Defend",
        "Do Nothing"
    };
    public void BattleMode(Character player1, Enemy enemy)
    {
        while (enemy.GetHealth() > 0)
        {
            Console.WriteLine(player1);
            Console.WriteLine(enemy);
            for (int i = 0; i < battleModeMenu.Length; i++)
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
                    break;
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
}