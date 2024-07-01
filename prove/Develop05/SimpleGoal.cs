using System;

public class SimpleGoal : Goal
{
    public override int RecordEvent(Menu menu, Goal goal)
    {    
        int ExistingPoints = menu.GetPointsEarned();
        int PointsToAdd = goal.GetPoints();
        int TotalPoints = ExistingPoints + PointsToAdd;
        Console.WriteLine($"Congratulations! You earned {PointsToAdd} points!");
        string completion = "[X]";
        SetCompletionStatus(completion);
        return TotalPoints;    
    }
}