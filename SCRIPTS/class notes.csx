//using System
using System;
using Internal;

// //This is equivalent to Python print
// Console.WriteLine("Hello, what is your name?");

// //this is equivalent to Python's input function
// string name = Console.ReadLine();

// //This is equivalent to Python's f-string
// Console.WriteLine($"Hello, {name}!");

// Console.Write("Enter your age");
// int age = int.Parse(Console.ReadLine());

class Greeter
{
    public static string name = "Stan";

    public static string Greet()
    {
        return $"Hello, {name}";
    }
}
Console.WriteLine(Greeter.Greet());