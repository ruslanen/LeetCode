namespace LeetCode._392_Is_Subsequence;

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length > t.Length)
        {
            return false;
        }

        if (s == string.Empty)
        {
            return true;
        }

        var subsequence = 0;
        for (var i = 0; i < t.Length; i++)
        {
            if (s.Length > subsequence && s[subsequence] == t[i])
            {
                subsequence++;
            }
        }

        return subsequence == s.Length;
    }
}