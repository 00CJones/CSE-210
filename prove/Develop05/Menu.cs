using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;
public class Menu
{
    private List<Goal> goals = new List<Goal>();
    
    private static int pointsEarned;
    private string goalsDirectory = "Goals";
    private string[] menuOptions = {
        "Create New Goal",
        "List Goals",
        "Save Goals",
        "Load Goals",
        "Record Event",
        "Quit"
    };
    private string[] menuOptions2 = {
    "Simple Goal",
    "Eternal Goal",
    "Checklist Goal"
    };
    public int GetPointsEarned()
    {
        return pointsEarned;
    }
    public Menu()
    {
        pointsEarned = 0;
    }
    public bool RunMenu()
    {
        Console.WriteLine("Menu Options:");
        for (int i = 0; i < menuOptions.Length; i++)
        {
            Console.WriteLine($"    {i + 1}. {menuOptions[i]}");
        }
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (choice)
        {
            case 1:
                selectGoalType();
                break;
            case 2:
                DisplayGoals();
                break;
            case 3:
                //save goals
                SaveGoals();
                break;
            case 4:
                //load goals
                LoadGoals();
                break;
            case 5:
                //record event
                RecordEvent();
                break;
            case 6:
                // Quit the program
                Console.Clear();
                Console.WriteLine("Goodbye!");
                return false;
            default:
                // Invalid option, display error message
                Console.WriteLine("Invalid option please try again.");
                break;
        } return true;
    }

    public void selectGoalType()
    {
        Console.WriteLine("The types of goals are:");
        for (int i = 0; i < menuOptions2.Length; i++)
        {
            Console.WriteLine($"    {i + 1}. {menuOptions2[i]}");
        }
        Console.Write("Select a goal type: ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();
       switch (choice)
        {
            case 1:
                SimpleGoal simplegoal = new SimpleGoal();
                simplegoal.createNewGoal();
                addToList(simplegoal); 
                break;
            case 2:
                EternalGoal eternalgoal = new EternalGoal();
                eternalgoal.createNewGoal();
                addToList(eternalgoal);
                break;
            case 3:
                ChecklistGoal checklistgoal = new ChecklistGoal();
                checklistgoal.createNewGoal();
                addToList(checklistgoal);
                break;
        }
    }
        public void addToList(Goal instance)
    {
        goals.Add(instance);
        DisplayGoals();
    }
    public void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {goals[i]}");
        }
        Console.WriteLine($"\nYou have {pointsEarned} points");
        Console.WriteLine("");
    }

    public void SaveGoals()
    {
        Console.Write("What do you want to name your goals file? ");
        string filename = Console.ReadLine();
        if (!Directory.Exists(goalsDirectory))
        {
            Directory.CreateDirectory(goalsDirectory);
        }

        string fileName = $"{filename}.json";
        string filePath = Path.Combine(goalsDirectory, fileName);

        string jsonString = JsonSerializer.Serialize(goals);
        File.WriteAllText(filePath, jsonString);

        Console.WriteLine($"Goals saved to {filePath}");
    }

    public void LoadGoals()
    {
        if (!Directory.Exists(goalsDirectory))
        {
            Console.WriteLine("No goals directory found.");
            return;
        }

        string[] files = Directory.GetFiles(goalsDirectory, "*.json");
        if (files.Length == 0)
        {
            Console.WriteLine("No goals files found.");
            return;
        }

        Console.WriteLine("Available goal files:");
        for (int i = 0; i < files.Length; i++)
        {
            Console.WriteLine($"    {i + 1}. {Path.GetFileName(files[i])}");
        }

        Console.Write("Choose a number to select a file to load: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice < 0 || choice >= files.Length)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        string selectedFile = files[choice];
        string jsonFromFile = File.ReadAllText(selectedFile);

        goals = JsonSerializer.Deserialize<List<Goal>>(jsonFromFile);

        Console.WriteLine($"Goals loaded from {selectedFile}");
        DisplayGoals();
    }

    public void RecordEvent()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {goals[i].GetName()}");
        }
        Console.WriteLine("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        pointsEarned = goals[choice-1].RecordEvent(this, goals[choice-1]);
        DisplayGoals();
    }
}