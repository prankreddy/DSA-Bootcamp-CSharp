// Inputs and Type Casting examples
Console.Write("Enter an integer: ");
int num = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Enter a decimal: ");
decimal d = decimal.Parse(Console.ReadLine() ?? "0");

// Type casting
double db = 10.7;
int i = (int)db; // explicit cast
Console.WriteLine($"Casted: {i}");

// Temperature conversion example
Console.Write("Enter Celsius: ");
double celsius = double.Parse(Console.ReadLine() ?? "0");
double fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine($"Fahrenheit: {fahrenheit}");