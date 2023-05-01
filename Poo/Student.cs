namespace Poo;

public class Student : People
{
    public string ClassRoom { get; private set; } = string.Empty;
    public List<int> Notes { get; private set; } = new List<int>();

    public Student(string classRoom,string name, string document, DateTime dateTime) : base(name, document, dateTime)
    {
        ClassRoom = classRoom;
        Notes = new List<int> { 1, 2, 3, 4, 5 };
    }

    public override void presentation()
    {
        base.presentation();
        var average = Notes.Average();
        Console.WriteLine($"I am a student in class: {ClassRoom} and I have the grade: {average}");
    }
}