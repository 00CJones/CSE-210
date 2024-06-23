using System;

public class SmartLight : SmartDevice
{
    public SmartLight(string room, bool status) : base(room, status) 
    {
        SetRoom(room);
        SetStatus(status);
    }
}