using System;
using System.ComponentModel;

class Menu
{
    private List<SmartDevice> lights;
    private List<SmartDevice> TVs;
    private List<SmartDevice> Heaters;
    private string firstMenuChoice;
    private string[] menuOptions = {
        "Check Status",
        "Turn On/Off Smart Device",
        "Status Log",
        "Quit"
    };
    private string[] firstMenuOptions = {
        "Smart Light",
        "Smart TV",
        "Smart Heater",
        "Smart Devices in Room",
        "Quit"
    };

    public bool RunMenu(SmartDevice smartDevice)
    {
        Console.WriteLine("Smart Device Menu Options");
        Console.WriteLine("Please press a number to select an option.");
        for (int i = 0; i < menuOptions.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {menuOptions[i]}");
        }

        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (choice)
        {
            case 1:
                // Check Status
                bool status = smartDevice.ReadStatus();
                string statusText = status ? "on" : "off";
                Console.WriteLine($"{smartDevice.GetRoom()} {smartDevice.GetType()} is {statusText}");
                break;
            case 2:
                // Turn On/Off Smart Device
                Console.WriteLine("Would you like to turn on or off the smart device (press 0 for off and 1 for on)?");
                int writeStatus = int.Parse(Console.ReadLine());
                smartDevice.Toggle(writeStatus);
                bool status2 = smartDevice.ReadStatus();
                string statusText2 = status2 ? "on" : "off";
                Console.WriteLine($"{smartDevice.GetRoom()} {smartDevice.GetType()} is {statusText2}");
                break;
            case 3:
                // Status Log
                Console.WriteLine($"The {smartDevice.GetRoom()} {smartDevice.GetType()} has been on for {smartDevice.HowLong()}");
                break;
            case 4:
                // Quit the program
                Console.Clear();
                Console.WriteLine("Goodbye!");
                return false;
            default:
                // Invalid option, display error message
                Console.WriteLine("Invalid option please try again.");
                break;
        } return true;
    }
    public bool RunFirstMenu()
    {
        Console.Clear();
        Console.WriteLine("Smart Abode Menu Options");
        Console.WriteLine("Please press a number to select an option.");
        for (int i = 0; i < firstMenuOptions.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {firstMenuOptions[i]}");
        }

        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (choice)
        {
            case 1:
                // Smart Light
                SmartDevice light = DeviceMenu(lights);
                Console.Clear();
                bool keepRunning = true;
                while(keepRunning)
                {
                    keepRunning = RunMenu(light);
                }
                break;
            case 2:
                // Smart TV
                SmartDevice tv = DeviceMenu(TVs);
                bool keepRunning1 = true;
                while(keepRunning1)
                {
                    keepRunning1 = RunMenu(tv);
                }
                break;
            case 3:
                // Smart Heater
                SmartDevice heater = DeviceMenu(Heaters);
                bool keepRunning2 = true;
                while(keepRunning2)
                {
                    keepRunning2 = RunMenu(heater);
                }
                break;
            case 4:
                // Smart Devices in Room
                break;
            case 5:
                // Quit the program
                Console.Clear();
                Console.WriteLine("Goodbye!");
                return false;
            default:
                // Invalid option, display error message
                Console.WriteLine("Invalid option please try again.");
                break;
        } return true;
    }
    public void CreateLightList(List<SmartDevice> lights)
    {
        this.lights = lights;
    }
    public void CreateTVList(List<SmartDevice> TVs)
    {
        this.TVs = TVs;
    }
    public void CreateHeaterList(List<SmartDevice> Heaters)
    {
        this.Heaters = Heaters;
    }
    public SmartDevice DeviceMenu(List<SmartDevice> devices)
    {
        Console.WriteLine("Choose an available device");
        foreach (SmartDevice device in devices)
        {
            int i = 1;
            Console.WriteLine($"{i}. {device.GetRoom()}");
            i++;
        }
        int deviceChoice = int.Parse(Console.ReadLine());
        Console.WriteLine();
        SmartDevice chosenDevice = devices[deviceChoice - 1];
        return chosenDevice;
    }
}