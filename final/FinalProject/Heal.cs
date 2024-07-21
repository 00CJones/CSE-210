using System;
using System.Security.Cryptography.X509Certificates;

public class Heal : Ability
{
    public Heal(string name) : base(name)   // this ability will make it so that the player gains 2 health each turn, but does not dodge attacks
    {
        this.name = name;
    }
    public override void Use(Character player, int health)
    {
        if (health < 10)
        {
            if (health == 9)
            {
                health += 1;
            }
            else
            {
                health += 2;
            }
            player.SetHealth(health);
            Console.WriteLine($"{player.GetName()} Healed!");
        }
    }
}