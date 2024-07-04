public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string book, string problem) : base(name, topic)
    {
        _textbookSection = book;
        _problems = problem;
    }

    public string GetHomeworkList()
    {
        return $"{_textbookSection}, {_problems}";
    }
}