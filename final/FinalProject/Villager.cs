using System;

public class Villager : Character
{
    private Dodge dodge;
    public Villager(string name, int hitpoints, Dodge dodge) : base(name, hitpoints)
    {
        // this.attackWeapon = attackWeapon;
        // this.defenseWeapon = defenseWeapon;
        this.dodge = dodge;
    }
    public void OldManInteract(Character player)
    {
        Console.WriteLine("Hello there you young whipper snapper!");
        Console.WriteLine("Did you know that if you dodge enemy attacks you can avoid damage? It'll even give you 1 health!");
        Thread.Sleep(5000);
        AddAbility(player);
        Thread.Sleep(3000);
    }
    public void AddAbility(Character player)
    {
        this.abilities = player.GetAbilitiesList();
        if (!abilities.Any(a => a.GetType() == dodge.GetType()))
        {
            abilities.Add(dodge);
            player.SetAbilitiesList(abilities);
            Console.WriteLine($"Ability \"{dodge.GetName()}\" learned!");
            player.EquipAbility(dodge);
        }
    }
    
}