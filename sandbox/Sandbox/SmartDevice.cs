using System;

public abstract class SmartDevice
{
    private bool status;
    private DateTime startTime;
    private string room;

    public SmartDevice(string room, bool status)
    {
        this.room = room;
        this.status = status;
    }
    public virtual void Toggle(int Status)
    {
        if (Status == 0)
        {
            this.status = false;
        }
        else
        {
            this.status = true;
            this.startTime = DateTime.Now;
        }
    }
    public virtual bool ReadStatus()
    {
        return this.status;
    }
    public string HowLong()
    {
        if (status)
        {
            DateTime rightNow = DateTime.Now;
            TimeSpan totalTime = rightNow - startTime;
            string durationString = totalTime.Days + " days, " +
                            totalTime.Hours + " hours, " +
                            totalTime.Minutes + " minutes, " +
                            totalTime.Seconds + " seconds, ";
            return durationString;
        }
        else{
            return "The smart device is not turned on.";
        }
    }
    public void SetRoom(string room)
    {
        this.room = room;
    }
    public string GetRoom()
    {
        return this.room;
    }
    public void SetStatus(bool status)
    {
        this.status = status;
    }
    public void SetStartTime()
    {
        this.startTime = DateTime.Now;
    }
}