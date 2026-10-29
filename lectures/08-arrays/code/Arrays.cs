// Arrays and List<T> examples

int[] arr = { 1, 2, 3, 4, 5 };
Console.WriteLine($"First: {arr[0]}, Length: {arr.Length}");

// Multi-dimensional
int[,] matrix = { { 1, 2 }, { 3, 4 } };
Console.WriteLine(matrix[0, 1]);

// List (equivalent to ArrayList)
List<int> list = new() { 10, 20, 30 };
list.Add(40);
list.RemoveAt(0);
foreach (var item in list)
    Console.Write($"{item} ");

// Max in array
int max = arr.Max();
Console.WriteLine($"\nMax: {max}");