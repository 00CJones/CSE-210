using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

public abstract class Character
{
    protected string name;
    protected Weapon attackWeapon;
    protected Weapon defenseWeapon;
    protected List<Weapon> weaponsList;
    protected int hitPoints;
    protected List<Weapon> equippedWeapons;
    protected List<Ability> abilities;
    protected Ability equippedAbility;
    protected bool attackStatus;

    public Character(string name, int hitpoints)
    {
        this.name = name;
        this.hitPoints = hitpoints;
        this.abilities = new List<Ability>();
        this.weaponsList = new List<Weapon>();
    }
    public Character(string name, int hitpoints, Ability ability)
    {
        this.name = name;
        this.hitPoints = hitpoints;
        this.abilities = new List<Ability>();
        abilities.Add(ability);
        this.weaponsList = new List<Weapon>();
    }

    public void EquipAbility(Ability ability)
    {
        this.equippedAbility = ability;
        Console.WriteLine($"{ability.GetName()} equipped.");
    }
    public Ability GetEquippedAbility()
    {
        return equippedAbility;
    }
    public List<Weapon> GetWeaponsList()
    {
        return weaponsList;
    }
    public List<Ability> GetAbilitiesList()
    {
        return abilities;
    }
    public void SetAbilitiesList(List<Ability> list)
    {
        this.abilities = list;
    }
    public void SetAttackStatus(bool status)
    {
        this.attackStatus = status;
    }
    public bool GetAttackStatus()
    {
        return attackStatus;
    }

    public Weapon GetAttackWeapon()
    {
        return attackWeapon;
    }
    public void SetAttackWeapon(Weapon attackWeapon)
    {
        this.attackWeapon = attackWeapon;
    }
    public Weapon GetDefenseWeapon()
    {
        return defenseWeapon;
    }
    public void SetDefenseWeapon(Weapon defenseWeapon)
    {
        this.defenseWeapon = defenseWeapon;
    }
    public string GetName()
    {
        return name;
    }
    public void SetHealth(int hitpoints)
    {
        this.hitPoints = hitpoints;
    }
    public int GetHealth()
    {
        return hitPoints;
    }
    // public virtual void SetDefendMode(Character character, Weapon defenseWeapon)
    // {
    //     int addedDefense = defenseWeapon.GetDefense();
    //     int hitpoints = character
    // }
    // For Attack(), put in the character you wish to attack and your attack weapon you wish to use on them. attackStatus is the receiving character's attack status, indicating whether he is attacking or defending
    public virtual void Attack(Character character, Weapon weapon, bool attackStatus)
    {
        Weapon attackingWeapon = GetAttackWeapon();
        Console.WriteLine($"{this.GetName()} attacked with {attackingWeapon.GetName()}!");
        int hitpoints = character.GetHealth();
        int attack = weapon.GetAttack();
        if (attackStatus == true)
        {
            if (hitpoints > attack)
            {
                int remainingHealth = hitpoints - attack;
                character.SetHealth(remainingHealth);
            }
            else
            {
                character.SetHealth(0);
                Console.WriteLine($"{character.GetName()} defeated!");
            }
        }
        else
        {
            character.Defend(weapon);
        }


    }
    // For Defend(), put in attacking character attack weapon
    public virtual void Defend(Weapon weapon)
    {
        Weapon defendingWeapon = this.GetDefenseWeapon();
        int hitpoints = GetHealth();
        int attack = weapon.GetAttack();
        int defense = defenseWeapon.GetDefense();
        if (attack > defense)
        {
            int reducedDamage = attack - defense;
            int remainingHealth = hitpoints - reducedDamage;
            if (remainingHealth > 0)
            {
                SetHealth(remainingHealth);
                Console.WriteLine($"{this.GetName()} blocked with {defendingWeapon.GetName()}!");
            }
            else
            {
                SetHealth(0);
                Console.WriteLine($"{this.GetName()} defeated!");
            }           
        }
        else
        {
            Console.WriteLine($"{this.GetName()} blocked with {defendingWeapon.GetName()}!");
        }
    }
    public override string ToString()
    {
        return $"{name} | Health: {hitPoints} | Attack Weapon: {attackWeapon.GetName()} | Defense Weapon: {defenseWeapon.GetName()} |";
    }
}