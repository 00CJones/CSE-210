using System;

public class Player1 : Character
{


    public Player1(string name, int hitpoints, Weapon attackWeapon, Weapon defenseWeapon) : base(name, hitpoints)
    {
        this.attackWeapon = attackWeapon;
        this.defenseWeapon = defenseWeapon;
    }
}