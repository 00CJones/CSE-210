using System;

public class None : Ability
{
    public None(string name):base(name)
    {
        this.name = name;
    }
    public override void Use(Character player, int health)
    {

    }
}