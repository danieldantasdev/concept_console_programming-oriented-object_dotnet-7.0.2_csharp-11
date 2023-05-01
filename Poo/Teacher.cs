namespace Poo;

public class Teacher : People
{
    public List<string> ClassRoom { get; private set; } = new List<string>();
    public decimal Salary { get; private set; } = decimal.MinValue;

    public Teacher(decimal salary, string name, string document, DateTime dateTime) : base(name, document, dateTime)
    {
        ClassRoom = new List<string> { "A", "B", "C", "D" };
        Salary = salary;
    }
    
    public override void presentation()
    {
        base.presentation();
        var classRoom = string.Join(",", ClassRoom);
        Console.WriteLine($"My salary is {Salary} and i teach classes: {classRoom}");
    }
}