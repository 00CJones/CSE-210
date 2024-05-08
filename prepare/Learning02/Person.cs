using System;
using System.Runtime.CompilerServices;
public class Person
{

    public string givenName;
    public string familyName;

    public Person()
    {

    }
    public void EasternStyleName()
    {
        Console.WriteLine($"{this.familyName}, {this.givenName}");
    }
    public void WesternStyleName()
    {
        Console.WriteLine($"{this.familyName} {this.givenName}");
    }
}