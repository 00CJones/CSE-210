using System;


public abstract class Weapon
{
    protected string weaponName;
    protected int weaponAttack;
    protected int weaponDefense;

    public Weapon(string name, int attack, int defense)
    {
        weaponName = name;
        weaponAttack = attack;
        weaponDefense = defense;
    }

    public int GetAttack()
    {
        return weaponAttack;
    }

    public int GetDefense()
    {
        return weaponDefense;
    }

    public string GetName()
    {
        return weaponName;
    }

    public override string ToString()
    {
        return $"| {weaponName} | Attack: {weaponAttack} | Defense: {weaponDefense} |";
    }
}

