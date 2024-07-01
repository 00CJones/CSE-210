using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public abstract class Goal
{

    private string name;
    private string description;
    private int points;
    private string completionStatus;
    private int tallyNumerator;
    private int tallyDenominator;
    private int bonusPoints;

    public string GetDescription()
    {
        return description;
    }
    public void SetDescription(string description)
    {
        this.description = description;
    }
    public string GetName()
    {
        return name;
    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public int GetPoints()
    {
        return points;
    }
    public void SetPoints(int number)
    {
        points = number;
    }
    public int GetTallyDenominator()
    {
        return tallyDenominator;
    }
    public void SetTallyDenominator(int number)
    {
        tallyDenominator = number;
    }
    public int GetTallyNumerator()
    {
        return tallyNumerator;
    }
    public void SetTallyNumerator(int number)
    {
        tallyNumerator = number;
    }
    public int GetBonusPoints()
    {
        return bonusPoints;
    }
    public void SetBonusPoints(int number)
    {
        bonusPoints = number;
    }
    public string GetCompletionStatus()
    {
        return completionStatus;
    }
    public string SetCompletionStatus(string completion)
    {
        completionStatus = completion;
        return completionStatus;
    }
    public Goal()
    {
        completionStatus = "[ ]";
        tallyNumerator = 0;
    }
    public virtual void createNewGoal()
    {
        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
        Console.Write("What is the number of points associated with this goal? ");
        points = int.Parse(Console.ReadLine());
    }
    public abstract int RecordEvent(Menu menu, Goal goal);


    public override string ToString()
    {
        return $"{completionStatus} {name} ({description})";
    }
}