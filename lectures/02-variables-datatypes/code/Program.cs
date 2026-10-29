// Variables and Data Types deep examples

// Value types
int i = 42;
double d = 3.14;
decimal money = 99.99m;          // Always use decimal for money
bool flag = true;
char c = 'A';

// Reference type
string text = "C# is powerful";

// Nullable
int? optional = null;
string? maybe = null;

// Type inference
var count = 100;                 // int
var message = "Hello";           // string

// Constants
const double Pi = 3.14159;

Console.WriteLine($"int: {i}, decimal: {money}, string: {text}");
Console.WriteLine($"Nullable int has value: {optional.HasValue}");
