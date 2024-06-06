using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Calvin", "Math");
        Console.WriteLine(a1.GetSummary());

        MathAssignment m1 = new MathAssignment("Ary", "Calculus", "9.2", "2-9");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeWorkList());

        WritingAssignment w1 = new WritingAssignment("Emily", "English 101", "Final REsearch Paper");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());

    }
}
