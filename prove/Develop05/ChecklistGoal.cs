using System;

public class ChecklistGoal : Goal
{
    private string tallyScore;
    private int tallyNumerator;
    private int tallyDenominator;
    private int bonusPoints;
    private int eventNumber;
    public string GetTallyScore()
    {
        return tallyScore;
    }
    public override void createNewGoal()
    {
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.Write("What is a short description of it? ");
        SetDescription(Console.ReadLine());
        Console.Write("What is the amount of points associated with this goal? ");
        SetPoints(int.Parse(Console.ReadLine()));
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        tallyDenominator = (int.Parse(Console.ReadLine()));
        Console.Write("What is the bonus for accomplishing it this many times? ");
        bonusPoints = (int.Parse(Console.ReadLine()));
        tallyNumerator = 0;
        tallyScore = $"{tallyNumerator}/{tallyDenominator}";
    }
    public override int RecordEvent(Menu menu, Goal goal)
    {   
        tallyNumerator += 1;
        if (tallyNumerator != tallyDenominator)
        {
            int ExistingPoints = menu.GetPointsEarned();
            int PointsToAdd = goal.GetPoints();
            int TotalPoints = ExistingPoints + PointsToAdd;
            Console.WriteLine($"Congratulations! You earned {PointsToAdd} points!");
            tallyScore = $"{tallyNumerator}/{tallyDenominator}";
            return TotalPoints; 
        }
        else
        {
            int ExistingPoints = menu.GetPointsEarned();
            int PointsToAdd = bonusPoints;
            string completion = "[X]";
            int TotalPoints = ExistingPoints + PointsToAdd;
            Console.WriteLine($"Congratulations! You earned {PointsToAdd} bonus points!");
            SetCompletionStatus(completion);
            tallyScore = $"{tallyNumerator}/{tallyDenominator}";
            return TotalPoints; 
        }
    }
    public override string ToString()
    {
        return $"{GetCompletionStatus()} {GetName()} ({GetDescription()}) -- {tallyScore}";
    }
}