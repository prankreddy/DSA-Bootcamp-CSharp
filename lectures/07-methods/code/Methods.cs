// Methods examples

static int Sum(int a, int b) => a + b;

static void Swap(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}

static void Greet(string name = "User")
{
    Console.WriteLine($"Hello, {name}!");
}

// Overloading
static double Sum(double a, double b) => a + b;

int x = 5, y = 10;
Swap(ref x, ref y);
Console.WriteLine($"Swapped: {x}, {y}");
Greet();
Greet("Praneesh");