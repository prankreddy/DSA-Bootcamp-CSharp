// Sorting Algorithms

static void BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
        for (int j = 0; j < arr.Length - i - 1; j++)
            if (arr[j] > arr[j + 1])
                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
}

static void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minIdx = i;
        for (int j = i + 1; j < arr.Length; j++)
            if (arr[j] < arr[minIdx]) minIdx = j;
        (arr[i], arr[minIdx]) = (arr[minIdx], arr[i]);
    }
}

static void InsertionSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int key = arr[i], j = i - 1;
        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = key;
    }
}

int[] a = { 64, 34, 25, 12, 22 };
BubbleSort(a);
Console.WriteLine(string.Join(", ", a));