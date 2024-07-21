using System;

public class Enemy : Character
{
    private string[] behavior = {
        "1",
        "1",
        "1",
        "0"
    };
    public Enemy(string name, int hitpoints, Weapon attackWeapon, Weapon defenseWeapon) : base(name, hitpoints)
    {
        this.attackWeapon = attackWeapon;
        this.defenseWeapon = defenseWeapon;
        this.weaponsList = new List<Weapon>();
        weaponsList.Add(attackWeapon);
        if (!attackWeapon.Equals(defenseWeapon))
        {
            weaponsList.Add(defenseWeapon);
        }
        this.attackStatus = true;
    }
    public bool GenerateEnemyAttackStatus(Random random)
    {
        // return attackStatus;
        int enemyChoice = random.Next(behavior.Length);
        if (behavior[enemyChoice] == "1")
        {
            this.SetAttackStatus(true);
        }
        else
        {
            this.SetAttackStatus(false);
            
        }
        return this.attackStatus;
    }
    public bool GetEnemyAttackStatus(Random random)
    {
        return GenerateEnemyAttackStatus(random);
    }

}