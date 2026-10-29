// Methods examples

static int Add(int x, int y) => x + y;

static void Greet(string name, string greeting = "Hello")
{
    Console.WriteLine($"{greeting}, {name}!");
}

static bool TryGetPositive(int n, out int result)
{
    if (n > 0)
    {
        result = n;
        return true;
    }
    result = 0;
    return false;
}

// Usage
Console.WriteLine(Add(5, 7));
Greet("Praneesh");
Greet("Praneesh", "Hi");

if (TryGetPositive(10, out int val))
    Console.WriteLine($"Positive value: {val}");
