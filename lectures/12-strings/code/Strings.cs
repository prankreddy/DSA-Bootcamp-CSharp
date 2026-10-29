// Strings examples
string s = "Hello World";
Console.WriteLine(s.ToLower());
Console.WriteLine(s.Contains("World"));
Console.WriteLine(s.Replace("World", "C#"));

// Palindrome check
static bool IsPalindrome(string str)
{
    int left = 0, right = str.Length - 1;
    while (left < right)
    {
        if (str[left] != str[right]) return false;
        left++; right--;
    }
    return true;
}

Console.WriteLine(IsPalindrome("racecar")); // true
Console.WriteLine(IsPalindrome("hello"));   // false

// StringBuilder for efficiency
var sb = new System.Text.StringBuilder();
sb.Append("C#");
sb.Append(" is");
sb.Append(" fast");
Console.WriteLine(sb.ToString());