using System;


public class Sword : Weapon
{
    private int swordLength;
    public Sword(string name, int attack, int defense, int swordLength) 
        : base(name, attack, defense) 
    {
        this.swordLength = swordLength;
    }
    // public override string ToString()
    // {
    //     return $"{weaponName} {swordLength}";
    // }

}
