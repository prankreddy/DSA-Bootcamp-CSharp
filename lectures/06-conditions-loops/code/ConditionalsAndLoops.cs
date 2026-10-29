// Conditionals and Loops examples

// Largest of three
int a = 10, b = 20, c = 15;
int max = a > b ? (a > c ? a : c) : (b > c ? b : c);
Console.WriteLine($"Max: {max}");

// Switch expression
int day = 3;
string dayName = day switch
{
    1 => "Monday",
    2 => "Tuesday",
    3 => "Wednesday",
    _ => "Other"
};
Console.WriteLine(dayName);

// Fibonacci
int n = 10;
int prev = 0, curr = 1;
for (int i = 0; i < n; i++)
{
    Console.Write($"{prev} ");
    int next = prev + curr;
    prev = curr;
    curr = next;
}