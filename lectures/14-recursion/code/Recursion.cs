// Recursion examples

static int Factorial(int n) => n <= 1 ? 1 : n * Factorial(n - 1);

static int Fibonacci(int n) => n <= 1 ? n : Fibonacci(n - 1) + Fibonacci(n - 2);

static void Print1ToN(int n)
{
    if (n == 0) return;
    Print1ToN(n - 1);
    Console.Write($"{n} ");
}

Console.WriteLine(Factorial(5)); // 120
Console.WriteLine(Fibonacci(7)); // 13
Print1ToN(5);