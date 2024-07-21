using System;

public class WeaponsManager
{
    private bool browseWeapons = true;
    private string[] weaponsMenu = {
    "Display All Weapons You Have",
    "Set Attack Weapon",
    "Set Defense Weapon (can be same as attack)",
    "Quit Weapons Inventory"
    };
    private List<Weapon> weaponList;
    public WeaponsManager()
    {
        this.weaponList = new List<Weapon>();
    }

    public void DisplayWeaponsList(Character player)
    {
        this.weaponList = new List<Weapon>();
        weaponList = player.GetWeaponsList();
        for (int i = 0; i < weaponList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {weaponList[i]}");
        }
        // Weapon attackweapon = player.GetAttackWeapon();
        // Weapon defenseweapon = player.GetDefenseWeapon();
        // Console.WriteLine($"Equipped Attack Weapon: {attackweapon.GetName()}");
        // Console.WriteLine($"Equipped Defense Weapon: {defenseweapon.GetName()}");
    }
    public void SetAttackingWeapon(Character player)
    {
        this.weaponList = new List<Weapon>();
        weaponList = player.GetWeaponsList();
        for (int i = 0; i < weaponList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {weaponList[i]}");
        }
        Console.Write("Select a number choice from the menu: ");
        int weaponChoice = int.Parse(Console.ReadLine());
        player.SetAttackWeapon(weaponList[weaponChoice - 1]);
        Console.WriteLine($"Attack weapon set to {weaponList[weaponChoice -1].GetName()}.");
    }
    public void SetDefendingWeapon(Character player)
    {
        this.weaponList = new List<Weapon>();
        weaponList = player.GetWeaponsList();
        for (int i = 0; i < weaponList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {weaponList[i]}");
        }
        Console.Write("Select a number choice from the menu: ");
        int weaponChoice = int.Parse(Console.ReadLine());
        player.SetDefenseWeapon(weaponList[weaponChoice - 1]);
        Console.WriteLine($"Defense weapon set to {weaponList[weaponChoice -1].GetName()}.");
    }
    public void Run(Character player)
    {
        browseWeapons = true;
        while (browseWeapons)
        {
            Console.WriteLine("Inventory Options:");
            for (int i = 0; i < weaponsMenu.Length; i++)
                {
                    Console.WriteLine($"    {i + 1}. {weaponsMenu[i]}");
                }
            Console.Write("Select a number choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1: //display weapons
                    DisplayWeaponsList(player);
                    break;

                case 2: // set attack
                    SetAttackingWeapon(player);
                    break;

                case 3: // set defense
                    SetDefendingWeapon(player);
                    break;

                case 4: // quit
                    browseWeapons = false;
                    break;
            }
        }
    }
}