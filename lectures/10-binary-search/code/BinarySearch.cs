// Binary Search
static int BinarySearch(int[] arr, int target)
{
    int left = 0, right = arr.Length - 1;
    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        if (arr[mid] == target) return mid;
        if (arr[mid] < target) left = mid + 1;
        else right = mid - 1;
    }
    return -1;
}

int[] sorted = { 1, 3, 5, 7, 9, 11 };
Console.WriteLine(BinarySearch(sorted, 7)); // 3
Console.WriteLine(BinarySearch(sorted, 6)); // -1