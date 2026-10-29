// Pattern printing examples

static void Pattern1(int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
            Console.Write("* ");
        Console.WriteLine();
    }
}

static void Pattern2(int n)
{
    for (int i = n; i >= 1; i--)
    {
        for (int j = 1; j <= i; j++)
            Console.Write("* ");
        Console.WriteLine();
    }
}

Pattern1(5);
Console.WriteLine();
Pattern2(5);