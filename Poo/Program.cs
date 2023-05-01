using Poo;

var teacher = new Teacher(500m, "Daniel", "12345", new DateTime());
var student = new Student("A", "Luis", "54321", new DateTime());

var peoples = new List<People> { student, teacher };

foreach (var people in peoples)
{
    people.presentation();
}