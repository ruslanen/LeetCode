namespace LeetCode._409_Longest_Palindrome;

public class Solution
{
    public int LongestPalindrome(string s)
    {
        var array = s.ToArray();
        var dictionary = new Dictionary<char, int>();
        for (int i = 0; i < array.Length; i++)
        {
            var letter = array[i];
            if (dictionary.ContainsKey(letter))
            {
                dictionary[letter] = ++dictionary[letter];
            }
            else
            {
                dictionary[letter] = 1;
            }
        }

        var maxLength = 0;
        var reservedLetterForOdd = 0;
        foreach (var entry in dictionary)
        {
            if (entry.Value % 2 == 1)
            {
                reservedLetterForOdd = 1;
                maxLength += entry.Value - 1;
            }
            else
            {
                maxLength += entry.Value;
            }
        }

        return maxLength + reservedLetterForOdd;
    }
}