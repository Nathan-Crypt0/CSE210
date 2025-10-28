using System.Reflection.Metadata.Ecma335;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string summary = $"{_title}";
        return summary;
    }
}