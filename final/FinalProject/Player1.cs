using System;

public class Player1 : Character
{


    public Player1(string name, int hitpoints, Weapon attackWeapon, Weapon defenseWeapon, Ability ability) : base(name, hitpoints, ability)
    {
        this.attackWeapon = attackWeapon;
        this.defenseWeapon = defenseWeapon;
        this.weaponsList = new List<Weapon>();
        weaponsList.Add(attackWeapon);
        weaponsList.Add(defenseWeapon);
    }
}