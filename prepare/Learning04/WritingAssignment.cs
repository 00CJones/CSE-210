using System;

public class WritingAssignment : Assignment
{
    private string title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        this.title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{title} by {studentName}";
    }
}