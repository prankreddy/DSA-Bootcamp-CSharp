// Operators, Conditions, Loops

int a = 15, b = 4;

// Operators
Console.WriteLine($"Sum: {a + b}");
Console.WriteLine($"Quotient: {a / b}");
Console.WriteLine($"Remainder: {a % b}");
Console.WriteLine($"Ternary: {(a > b ? "A bigger" : "B bigger")}");

// Switch expression
int score = 85;
string grade = score switch
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    _ => "Fail"
};
Console.WriteLine($"Grade: {grade}");

// Loops
Console.WriteLine("\nFor loop:");
for (int i = 1; i <= 5; i++)
    Console.Write($"{i} ");

Console.WriteLine("\n\nForeach:");
string[] names = { "Ravi", "Anu", "Kiran" };
foreach (var name in names)
    Console.WriteLine(name);
