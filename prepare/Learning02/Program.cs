using System;
using System.Collections.Frozen;

class Program
{
    static void Main(string[] args)
    {
        Person fred = new Person();
        fred.givenName = "Fred";
        fred.familyName = "Flinstone";

        Person steve = new Person();
        steve.givenName = "Steve";
        steve.familyName = "Minecraft";

        fred.EasternStyleName();
        steve.WesternStyleName();
    }
}