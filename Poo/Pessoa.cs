namespace Poo;

public abstract class People
{
    public string Name { get; protected set; } = string.Empty;
    public string Document { get; protected set; } = string.Empty;
    public DateTime DateTime { get; protected set; } = DateTime.Now;

    protected People(string name, string document, DateTime dateTime)
    {
        Name = name;
        Document = document;
        DateTime = dateTime;
    }

    public virtual void presentation()
    {
        Console.WriteLine($"Hello, your name is: {Name}, document: {Document}, dateTime: {DateTime}");
    }
}