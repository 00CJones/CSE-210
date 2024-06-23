using System;

public class SmartHeater : SmartDevice
{
    public SmartHeater(string room, bool status) : base(room, status)
    {
        SetRoom(room);
        SetStatus(status);
    }
}