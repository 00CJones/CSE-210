using System;

class Program
{
    static void Main(string[] args)
    {
        List<SmartDevice> Lights = new List<SmartDevice>();
        List<SmartDevice> TVs = new List<SmartDevice>();
        List<SmartDevice> Heaters = new List<SmartDevice>();
        List<SmartDevice> Devices = new List<SmartDevice>();

        //Sample Smart Devices in hardcoded locations initialized to off
        SmartLight frontRoomLight = new SmartLight("front room", false);
        Devices.Add(frontRoomLight);
        Lights.Add(frontRoomLight);

        SmartLight bathroomLight = new SmartLight("bathroom", false);
        Devices.Add(bathroomLight);
        Lights.Add(bathroomLight);

        SmartLight kitchenLight = new SmartLight("kitchen", false);
        Devices.Add(kitchenLight);
        Lights.Add(kitchenLight);

        SmartTV tv = new SmartTV("front room", false);
        Devices.Add(tv);
        TVs.Add(tv);

        SmartHeater bathroomHeater = new SmartHeater("bathroom", false);
        Devices.Add(bathroomHeater);
        Heaters.Add(bathroomHeater);

        Menu menu = new Menu{};
        menu.CreateLightList(Lights);
        menu.CreateTVList(TVs);
        menu.CreateHeaterList(Heaters);
        bool keepRunning = true;
        while(keepRunning)
        {
            keepRunning = menu.RunFirstMenu();
        }
    }
}