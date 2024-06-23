using System;

public class SmartTV : SmartDevice
{
    public SmartTV(string room, bool status) : base(room, status)
    {
        SetRoom(room);
        SetStatus(status);
    }
}