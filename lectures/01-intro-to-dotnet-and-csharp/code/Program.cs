// Top-level statements example
Console.WriteLine("Hello from .NET / C#!");

string? name = Console.ReadLine();
Console.WriteLine($"Hello, {name ?? "Developer"}");

// Demonstrate basic types
int age = 25;
decimal salary = 75000.50m;
bool isActive = true;

Console.WriteLine($"Age: {age}, Salary: {salary}, Active: {isActive}");
