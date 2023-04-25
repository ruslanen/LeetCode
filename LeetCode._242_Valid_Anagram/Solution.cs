namespace LeetCode._242_Valid_Anagram;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        
        var dictionary = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (dictionary.TryGetValue(s[i], out var value))
                dictionary[s[i]] = ++value;
            else
                dictionary[s[i]] = 1;
        }
        
        for (int i = 0; i < t.Length; i++)
        {
            if (!dictionary.ContainsKey(t[i]) || dictionary[t[i]] < 0)
                return false;
            else
                dictionary[t[i]]--;
        }

        return true;
    }
}