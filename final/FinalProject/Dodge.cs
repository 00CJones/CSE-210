using System;

public class Dodge : Ability
{
    public Dodge(string name) : base(name)
    {
        
    }
    public override void Use(Character player, int health)
    {
        if (health < 10)
        {
            health += 1;
            player.SetHealth(health);
            Console.WriteLine($"{player.GetName()} dodged!");
        }
    }
}