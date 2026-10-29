// OOP Basics - Class example
public class Student
{
    public string Name { get; set; } = "";
    public int Roll { get; set; }

    public Student(string name, int roll)
    {
        Name = name;
        Roll = roll;
    }

    public void Display() => Console.WriteLine($"{Name} - {Roll}");
}

var s = new Student("Ravi", 101);
s.Display();

// Inheritance
public class Car : Student // just demo
{
    public string Model { get; set; } = "";
}