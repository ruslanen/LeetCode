using System.Text;

namespace LeetCode._125_Valid_Palindrome;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        var stringBuilder = new StringBuilder();
        foreach (var symbol in s)
        {
            if (char.IsLetter(symbol))
            {
                stringBuilder.Append(char.ToLowerInvariant(symbol));
            }
            else if (char.IsDigit(symbol))
            {
                stringBuilder.Append(symbol);
            }
        }

        var result = stringBuilder.ToString();
        return result == string.Join("", result.ToCharArray().Reverse());
    }
}