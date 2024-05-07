using System;

class Program
{
    static void Main(string[] args)
    {
        //using System


        //This is equivalent to Python print
        Console.WriteLine("Hello, what is your name?");

        //this is equivalent to Python's input function
        string name = Console.ReadLine();

        //This is equivalent to Python's f-string
        Console.WriteLine($"Hello, {name}!");

        Console.Write("Enter your age");
        int age = int.Parse(Console.ReadLine());
    }
}