// Linear Search
static int LinearSearch(int[] arr, int target)
{
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] == target) return i;
    return -1;
}

int[] nums = { 5, 3, 8, 1, 9 };
Console.WriteLine(LinearSearch(nums, 8)); // 2
Console.WriteLine(LinearSearch(nums, 10)); // -1