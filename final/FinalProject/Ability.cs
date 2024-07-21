using System;

abstract public class Ability
{
    protected int addedHealth;
    protected string name;

    public Ability(string name)
    {
        this.name = name;
    }
    public abstract void Use(Character player, int health);
    public string GetName()
    {
        return this.name;
    }
    
    public override bool Equals(object obj)
    {
        return obj is Ability ability &&
               name == ability.name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(name);
    }
}