using System;

public class MathAssignment : Assignment
{
    private string textbookSection;
    private string mathProblems;

    public MathAssignment(string studentName, string topic, string textbookSection, string mathProblems) : base(studentName, topic)
    {
        this.textbookSection = textbookSection;
        this.mathProblems = mathProblems;
    }
    public string GetHomeWorkList()
    {
        return $"Section {textbookSection} Problems {mathProblems}";
    }
}